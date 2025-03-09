using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector;
using Microsoft.Extensions.Logging;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using static Maple.BeastSaga.Metadata.PlayerItemData;
using static Maple.BeastSaga.Metadata.PlayerKangFu;

namespace Maple.BeastSaga.Metadata
{
    public partial class BeastSagaGameEnv(BeastSagaGameCache gameCache)
    {
        public BeastSagaGameCache GameCache { get; } = gameCache;
        public BeastSagaGameContext Context => GameCache.Context;
        private ILogger Logger => Context.Logger;

        private PlayerDataManager.Ptr_PlayerDataManager Ptr_PlayerDataManager { get; } = PlayerDataManager.Ptr_PlayerDataManager._INSTANCE;
        private PlayerData.Ptr_PlayerData Ptr_PlayerData => Ptr_PlayerDataManager._PLAYER_DATA;

        public void Test()
        {
            var p = LogicHelper.Ptr_LogicHelper._INSTANCE;

            var data = ExcelDataManager.Ptr_ExcelDataManager.INSTANCE;
            foreach (var table in data.P_FRIEND_LOVE_TABLE.DICT.AsRefArray())
            {
                var tableItem = table.Value;
                this.Logger.LogInformation("name:{name},name2:{name2},id:{id}", tableItem.NAME.ToString(), tableItem.NAME2.ToString(), tableItem.ID);
                p.FRIEND_ADD(tableItem.NAME2);
            }


        }

        public bool ThrowIfNotInGame()
        {
            var mgr = this.Ptr_PlayerDataManager;
            if (mgr.M_CACHED_PTR != nint.Zero && mgr._PLAYER != nint.Zero)
            {
                return true;
            }
            return GameException.ThrowIfNotLoaded<bool>();
        }


        public GameCurrencyInfoDTO GetCurrencyInfoDTO(GameCurrencyObjectDTO objectDTO)
        {

            var count = 0;
            if (this.TryGetItemByHad(objectDTO.CurrencyObject, out var ptr_PlayerItemData))
            {
                count += ptr_PlayerItemData._COUNT;
            }
            return new GameCurrencyInfoDTO() { ObjectId = objectDTO.CurrencyObject, DisplayValue = count.ToString() };

        }

        public GameCurrencyInfoDTO UpdateCurrencyInfoDTO(GameCurrencyModifyDTO objectDTO)
        {
            var item = this.GameCache.Currencies.Where(p => p.ObjectId == objectDTO.CurrencyObject).FirstOrDefault();
            if (item is null)
            {
                return GameException.Throw<GameCurrencyInfoDTO>($"NOT FOUND:{objectDTO.CurrencyObject}");
            }
            var count = objectDTO.IntValue;
            if (this.TryGetItemByHad(objectDTO.CurrencyObject, out var ptr_PlayerItemData))
            {
                ptr_PlayerItemData._COUNT = count;
            }
            else
            {
                this.Ptr_PlayerDataManager.AWARD_ITEM(item.Ptr, count);
            }
            return new GameCurrencyInfoDTO() { ObjectId = objectDTO.CurrencyObject, DisplayValue = count.ToString() };

        }


        #region PlayerData

        private bool TryGetItemByDress(ReadOnlySpan<char> name, out PlayerItemData.Ptr_PlayerItemData ptr_PlayerItemData)
        {
            Unsafe.SkipInit(out ptr_PlayerItemData);
            foreach (var item in this.Ptr_PlayerData.DRESS_ITEM.AsRefArray())
            {
                ptr_PlayerItemData = item.Value;
                if (ptr_PlayerItemData._ITEM_DATA._NAME.AsReadOnlySpan().SequenceEqual(name))
                {
                    return true;
                }
            }
            return false;

        }
        private bool TryGetItemByHad(ReadOnlySpan<char> name, out PlayerItemData.Ptr_PlayerItemData ptr_PlayerItemData)
        {
            Unsafe.SkipInit(out ptr_PlayerItemData);
            foreach (var item in this.Ptr_PlayerData.ITEM_HAD.AsRefArray())
            {
                ptr_PlayerItemData = item.Value;
                if (ptr_PlayerItemData._ITEM_DATA._NAME.AsReadOnlySpan().SequenceEqual(name))
                {
                    return true;
                }
            }
            return false;
        }

        private bool TryGetEquipByDress(ReadOnlySpan<char> name, out PlayerEquipData.Ptr_PlayerEquipData ptr_PlayerEquipData)
        {
            Unsafe.SkipInit(out ptr_PlayerEquipData);
            foreach (var item in this.Ptr_PlayerData.PLAYER_DRESS_EQUIP.AsRefArray())
            {
                ptr_PlayerEquipData = item.Value;
                if (ptr_PlayerEquipData._EQUIP_DATA._NAME.AsReadOnlySpan().SequenceEqual(name))
                {
                    return true;
                }
            }
            return false;
        }
        private bool TryGetEquipByHad(ReadOnlySpan<char> name, out ReadOnlySpan<PlayerEquipData.Ptr_PlayerEquipData> playerEquipDatas)
        {
            Unsafe.SkipInit(out playerEquipDatas);
            foreach (var item in this.Ptr_PlayerData.EQUIP_HAD.AsRefArray())
            {
                if (item.Key.AsReadOnlySpan().SequenceEqual(name))
                {
                    playerEquipDatas = item.Value.AsReadOnlySpan();
                    return true;
                }

            }
            return false;
        }


        private bool TryGetInKangFuByHad(ReadOnlySpan<char> name, out PlayerInKangFu.Ptr_PlayerInKangFu ptr_PlayerInKangFu)
        {
            Unsafe.SkipInit(out ptr_PlayerInKangFu);
            foreach (var item in this.Ptr_PlayerData.IN_KANG_FU_HAD.AsRefArray())
            {
                ptr_PlayerInKangFu = item.Value;

                if (ptr_PlayerInKangFu._IN_KANG_FU_DATA.NAME.AsReadOnlySpan().SequenceEqual(name))
                {
                    return true;
                }

            }
            return false;
        }
        private bool TryGetInKangFuByDress(ReadOnlySpan<char> name, out PlayerInKangFu.Ptr_PlayerInKangFu ptr_PlayerInKangFu)
        {
            ptr_PlayerInKangFu = this.Ptr_PlayerData.DRESS_IN_KANG_FU;
            return ptr_PlayerInKangFu && ptr_PlayerInKangFu._IN_KANG_FU_DATA.NAME.AsReadOnlySpan().SequenceEqual(name);
        }

        private bool TryGetKangFuByHad(ReadOnlySpan<char> name, out PlayerKangFu.Ptr_PlayerKangFu ptr_PlayerKangFu)
        {
            Unsafe.SkipInit(out ptr_PlayerKangFu);
            foreach (var item in this.Ptr_PlayerData.KANG_FU_HAD.AsRefArray())
            {
                ptr_PlayerKangFu = item.Value;

                if (ptr_PlayerKangFu._KANG_FU_DATA.NAME.AsReadOnlySpan().SequenceEqual(name))
                {
                    return true;
                }

            }
            return false;
        }
        private bool TryGetKangFuByDress(ReadOnlySpan<char> name, out PlayerKangFu.Ptr_PlayerKangFu ptr_PlayerKangFu)
        {
            Unsafe.SkipInit(out ptr_PlayerKangFu);
            foreach (var item in this.Ptr_PlayerData.DRESS_KANG_FU.AsRefArray())
            {
                ptr_PlayerKangFu = item.Value;
                if (ptr_PlayerKangFu._KANG_FU_DATA.NAME.AsReadOnlySpan().SequenceEqual(name))
                {
                    return true;
                }

            }
            return false;
        }


        private bool TryGetChongByHad(ReadOnlySpan<char> name, out PlayerChong.Ptr_PlayerChong ptr_PlayerChong)
        {
            Unsafe.SkipInit(out ptr_PlayerChong);
            foreach (var item in this.Ptr_PlayerData.CHONG_HAD)
            {
                ptr_PlayerChong = item;

                if (ptr_PlayerChong._DATA_SET._NAME.AsReadOnlySpan().SequenceEqual(name))
                {
                    return true;
                }

            }
            return false;
        }
        private bool TryGetChongByDress(ReadOnlySpan<char> name, out PlayerChong.Ptr_PlayerChong ptr_PlayerChong)
        {
            ptr_PlayerChong = this.Ptr_PlayerData.DRESS_CHONG;
            return ptr_PlayerChong && ptr_PlayerChong._DATA_SET._NAME.AsReadOnlySpan().SequenceEqual(name);
        }

        private bool TryGetChongPotByHad(ReadOnlySpan<char> name, out PlayerChongPot.Ptr_PlayerChongPot ptr_PlayerChongPot)
        {
            Unsafe.SkipInit(out ptr_PlayerChongPot);
            foreach (var item in this.Ptr_PlayerData.CHONG_POT_HAD)
            {
                ptr_PlayerChongPot = item;

                if (ptr_PlayerChongPot._DATA_SET._NAME.AsReadOnlySpan().SequenceEqual(name))
                {
                    return true;
                }

            }
            return false;
        }
        private bool TryGetChongPotByDress(ReadOnlySpan<char> name, out PlayerChongPot.Ptr_PlayerChongPot ptr_PlayerChongPot)
        {
            Unsafe.SkipInit(out ptr_PlayerChongPot);

            return false;
        }
        private IEnumerable<GameSwitchDisplayDTO> GetPlayerData()
        {
            PlayerData.Ptr_PlayerData playerData = this.Ptr_PlayerData;
            //yield return new GameSwitchDisplayDTO() { ObjectId = $"{EnumPlayerPropType.属性}.{nameof(PlayerData.Ptr_PlayerData.LV)}", DisplayName = "属性.等级", ContentValue = playerData.LV.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            yield return new GameSwitchDisplayDTO() { ObjectId = $"{nameof(EnumPlayerPropType.属性)}.{nameof(PlayerData.Ptr_PlayerData.EXP)}", DisplayName = "属性.经验", ContentValue = playerData.EXP.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            yield return new GameSwitchDisplayDTO() { ObjectId = $"{nameof(EnumPlayerPropType.属性)}.{nameof(PlayerData.Ptr_PlayerData.ADD_PRO_SPOT)}", DisplayName = "属性.六维加点", ContentValue = playerData.ADD_PRO_SPOT.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            //   yield return new GameSwitchDisplayDTO() { ObjectId = $"{EnumPlayerPropType.属性}.{nameof(PlayerData.Ptr_PlayerData.USE_PRO_SPOT)}", DisplayName = "属性.USE_PRO_SPOT", ContentValue = playerData.USE_PRO_SPOT.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            yield return new GameSwitchDisplayDTO() { ObjectId = $"{nameof(EnumPlayerPropType.属性)}.{nameof(PlayerData.Ptr_PlayerData.ADD_LIFE_SPOT)}", DisplayName = "属性.生活加点", ContentValue = playerData.ADD_LIFE_SPOT.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            //      yield return new GameSwitchDisplayDTO() { ObjectId = $"{EnumPlayerPropType.属性}.{nameof(PlayerData.Ptr_PlayerData.USE_LIFE_SPOT)}", DisplayName = "属性.USE_LIFE_SPOT", ContentValue = playerData.USE_LIFE_SPOT.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            yield return new GameSwitchDisplayDTO() { ObjectId = $"{nameof(EnumPlayerPropType.属性)}.{nameof(PlayerData.Ptr_PlayerData._BASE_HP)}", DisplayName = "属性.基础气血", ContentValue = playerData._BASE_HP.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            yield return new GameSwitchDisplayDTO() { ObjectId = $"{nameof(EnumPlayerPropType.属性)}.{nameof(PlayerData.Ptr_PlayerData._HP)}", DisplayName = "属性.当前气血", ContentValue = playerData._HP.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            yield return new GameSwitchDisplayDTO() { ObjectId = $"{nameof(EnumPlayerPropType.属性)}.{nameof(PlayerData.Ptr_PlayerData._MAX_HP)}", DisplayName = "属性.最大气血", ContentValue = playerData._MAX_HP.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            yield return new GameSwitchDisplayDTO() { ObjectId = $"{nameof(EnumPlayerPropType.属性)}.{nameof(PlayerData.Ptr_PlayerData.POWER)}", DisplayName = "六维.力道", ContentValue = playerData.POWER.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            yield return new GameSwitchDisplayDTO() { ObjectId = $"{nameof(EnumPlayerPropType.属性)}.{nameof(PlayerData.Ptr_PlayerData.PERCEPTION)}", DisplayName = "六维.感知", ContentValue = playerData.PERCEPTION.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            yield return new GameSwitchDisplayDTO() { ObjectId = $"{nameof(EnumPlayerPropType.属性)}.{nameof(PlayerData.Ptr_PlayerData.AGILITY)}", DisplayName = "六维.灵巧", ContentValue = playerData.AGILITY.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            yield return new GameSwitchDisplayDTO() { ObjectId = $"{nameof(EnumPlayerPropType.属性)}.{nameof(PlayerData.Ptr_PlayerData.PHYSICAL_POWER)}", DisplayName = "六维.体魄", ContentValue = playerData.PHYSICAL_POWER.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            yield return new GameSwitchDisplayDTO() { ObjectId = $"{nameof(EnumPlayerPropType.属性)}.{nameof(PlayerData.Ptr_PlayerData.CHANNEL)}", DisplayName = "六维.经脉", ContentValue = playerData.CHANNEL.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            yield return new GameSwitchDisplayDTO() { ObjectId = $"{nameof(EnumPlayerPropType.属性)}.{nameof(PlayerData.Ptr_PlayerData.BERATH_SKILL)}", DisplayName = "六维.速度", ContentValue = playerData.BERATH_SKILL.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            yield return new GameSwitchDisplayDTO() { ObjectId = $"{nameof(EnumPlayerPropType.属性)}.{nameof(PlayerData.Ptr_PlayerData.WU_XING)}", DisplayName = "六维.悟性", ContentValue = playerData.WU_XING.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            yield return new GameSwitchDisplayDTO() { ObjectId = $"{nameof(EnumPlayerPropType.属性)}.{nameof(PlayerData.Ptr_PlayerData.SPEED)}", DisplayName = "六维.脚程", ContentValue = playerData.SPEED.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            //yield return new GameSwitchDisplayDTO() { ObjectId = $"{EnumPlayerPropType.属性}.{nameof(PlayerData.Ptr_PlayerData.TALENT)}", DisplayName = "属性.特性", ContentValue = playerData.TALENT.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            yield return new GameSwitchDisplayDTO() { ObjectId = $"{nameof(EnumPlayerPropType.属性)}.{nameof(PlayerData.Ptr_PlayerData.TALENT_ADD)}", DisplayName = "属性.特性加点", ContentValue = playerData.TALENT_ADD.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            //yield return new GameSwitchDisplayDTO() { ObjectId = $"{EnumPlayerPropType.属性}.{nameof(PlayerData.Ptr_PlayerData.USE_TALENT)}", DisplayName = "属性.USE_TALENT", ContentValue = playerData.USE_TALENT.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            //yield return new GameSwitchDisplayDTO() { ObjectId = $"{EnumPlayerPropType.属性}.{nameof(PlayerData.Ptr_PlayerData.FOOD_ITEM_LIMIT)}", DisplayName = "属性.FOOD_ITEM_LIMIT", ContentValue = playerData.FOOD_ITEM_LIMIT.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            yield return new GameSwitchDisplayDTO() { ObjectId = $"{nameof(EnumPlayerPropType.属性)}.{nameof(PlayerData.Ptr_PlayerData._BATTLE_SPEED)}", DisplayName = "属性.战斗速度", ContentValue = playerData._BATTLE_SPEED.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            //yield return new GameSwitchDisplayDTO() { ObjectId = $"{EnumPlayerPropType.属性}.{nameof(PlayerData.Ptr_PlayerData._TI_LI_NUM)}", DisplayName = "属性.体力", ContentValue = playerData._TI_LI_NUM.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            //yield return new GameSwitchDisplayDTO() { ObjectId = $"{EnumPlayerPropType.属性}.{nameof(PlayerData.Ptr_PlayerData._TI_LI_CAN)}", DisplayName = "属性.激活体力", SwitchValue = playerData._TI_LI_CAN, UIType = (int)EnumGameSwitchUIType.Switches };



            foreach (var item in playerData.KONG_FU_TYPE_LV.AsRefArray())
            {
                var key = item.Key;
                var lv = this.Ptr_PlayerDataManager.GET_KONG_FU_TYPE_LV(key);

                var id = $"{nameof(EnumPlayerPropType.武学)}.{key}";

                yield return new GameSwitchDisplayDTO() { ObjectId = id, DisplayName = id, ContentValue = lv.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            }

            foreach (var item in playerData.LIFE_PRO.AsRefArray())
            {
                var name = item.Key.ToString();

                var id = $"{nameof(EnumPlayerPropType.生活)}.{name}";
                yield return new GameSwitchDisplayDTO() { ObjectId = id, DisplayName = id, ContentValue = item.Value.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            }

            //foreach (var item in playerData.LIFE_PRO_CURRENT.AsRefArray())
            //{
            //    var name = item.Key.ToString();

            //    var id = $"{EnumPlayerPropType.当前生活}.{name}";
            //    yield return new GameSwitchDisplayDTO() { ObjectId = id, DisplayName = id, ContentValue = item.Value.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            //}

            //foreach (var item in playerData.SIX_PRO_CURRENT.AsRefArray())
            //{
            //    var name = item.Key.ToString();

            //    var id = $"{EnumPlayerPropType.六维}.{name}";
            //    yield return new GameSwitchDisplayDTO() { ObjectId = id, DisplayName = id, ContentValue = item.Value.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            //}


            //foreach (var item in playerData.GAMBLE.AsRefArray())
            //{
            //    var name = item.Key.ToString();

            //    var id = $"{EnumPlayerPropType.赌博}.{name}";
            //    yield return new GameSwitchDisplayDTO() { ObjectId = id, DisplayName = id, ContentValue = item.Value.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            //}

            var characterHad = playerData.CHARACTER_HAD.AsRefArray();
            foreach (var item in this.GameCache.CharacterDataSets)
            {
                var had = characterHad.Where(p => p.Key.AsReadOnlySpan().SequenceEqual(item.ObjectId.AsSpan())).Any();

                var id = $"{nameof(EnumPlayerPropType.特性)}.{item.DisplayName}";
                yield return new GameSwitchDisplayDTO() { ObjectId = id, DisplayName = id, SwitchValue = had, UIType = (int)EnumGameSwitchUIType.Switches };

            }

            var friendLove = playerData.FRIEND_LOVE_NUM.AsRefArray();
            foreach (var item in this.GameCache.Characters.Where(p => p.DisplayCategory == nameof(FriendData)))
            {
                var love = friendLove.Where(p => p.Key.AsReadOnlySpan().SequenceEqual(item.DisplayName.AsSpan())).Select(p => p.Value).FirstOrDefault();

                var id = $"{nameof(EnumPlayerPropType.好感度)}.{item.DisplayName}";
                yield return new GameSwitchDisplayDTO() { ObjectId = id, DisplayName = id, ContentValue = love.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            }

            //内功

            //武艺

            //绝技
        }
        private void SetPlayerData(GameCharacterModifyDTO objectDTO)
        {
            PlayerData.Ptr_PlayerData playerData = this.Ptr_PlayerData;
            var propName = objectDTO.ModifyObject;
            if (string.IsNullOrEmpty(propName))
            {
                return;
            }
            //if (propName == $"{EnumPlayerPropType.属性}.{nameof(PlayerData.Ptr_PlayerData.LV)}")
            //{
            //    playerData.LV = objectDTO.IntValue;

            //}
            if (propName == $"{nameof(EnumPlayerPropType.属性)}.{nameof(PlayerData.Ptr_PlayerData.EXP)}")
            {
                int addExp = (int)(objectDTO.FloatValue - playerData.EXP);
                this.Ptr_PlayerDataManager.ADD_EXP(addExp);
            }
            else if (propName == $"{nameof(EnumPlayerPropType.属性)}.{nameof(PlayerData.Ptr_PlayerData.ADD_PRO_SPOT)}")
            {
                var add = objectDTO.IntValue;
                var use = playerData.USE_PRO_SPOT;
                if (add < use)
                {
                    add += use;
                }
                playerData.ADD_PRO_SPOT = add;
            }
            else if (propName == $"{nameof(EnumPlayerPropType.属性)}.{nameof(PlayerData.Ptr_PlayerData.ADD_LIFE_SPOT)}")
            {

                var add = objectDTO.IntValue;
                var use = playerData.USE_LIFE_SPOT;
                if (add < use)
                {
                    add += use;
                }
                playerData.ADD_LIFE_SPOT = add;
            }
            else if (propName == $"{nameof(EnumPlayerPropType.属性)}.{nameof(PlayerData.Ptr_PlayerData._BASE_HP)}")
            {
                playerData._BASE_HP = objectDTO.FloatValue;
            }
            else if (propName == $"{nameof(EnumPlayerPropType.属性)}.{nameof(PlayerData.Ptr_PlayerData._HP)}")
            {
                playerData._HP = objectDTO.FloatValue;
            }
            else if (propName == $"{nameof(EnumPlayerPropType.属性)}.{nameof(PlayerData.Ptr_PlayerData._MAX_HP)}")
            {
                playerData._MAX_HP = objectDTO.FloatValue;
            }
            else if (propName == $"{nameof(EnumPlayerPropType.属性)}.{nameof(PlayerData.Ptr_PlayerData.POWER)}")
            {
                playerData.POWER = objectDTO.FloatValue;
                this.Ptr_PlayerDataManager.SAVE_PRO_LIFE_POINTS();
            }
            else if (propName == $"{nameof(EnumPlayerPropType.属性)}.{nameof(PlayerData.Ptr_PlayerData.PERCEPTION)}")
            {
                playerData.PERCEPTION = objectDTO.FloatValue;
                this.Ptr_PlayerDataManager.SAVE_PRO_LIFE_POINTS();

            }
            else if (propName == $"{nameof(EnumPlayerPropType.属性)}.{nameof(PlayerData.Ptr_PlayerData.AGILITY)}")
            {
                playerData.AGILITY = objectDTO.FloatValue;
                this.Ptr_PlayerDataManager.SAVE_PRO_LIFE_POINTS();

            }
            else if (propName == $"{nameof(EnumPlayerPropType.属性)}.{nameof(PlayerData.Ptr_PlayerData.PHYSICAL_POWER)}")
            {
                playerData.PHYSICAL_POWER = objectDTO.FloatValue;
                this.Ptr_PlayerDataManager.SAVE_PRO_LIFE_POINTS();

            }
            else if (propName == $"{nameof(EnumPlayerPropType.属性)}.{nameof(PlayerData.Ptr_PlayerData.CHANNEL)}")
            {
                playerData.CHANNEL = objectDTO.FloatValue;
                this.Ptr_PlayerDataManager.SAVE_PRO_LIFE_POINTS();

            }
            else if (propName == $"{nameof(EnumPlayerPropType.属性)}.{nameof(PlayerData.Ptr_PlayerData.BERATH_SKILL)}")
            {
                playerData.BERATH_SKILL = objectDTO.FloatValue;
                this.Ptr_PlayerDataManager.SAVE_PRO_LIFE_POINTS();

            }
            else if (propName == $"{nameof(EnumPlayerPropType.属性)}.{nameof(PlayerData.Ptr_PlayerData.WU_XING)}")
            {
                playerData.WU_XING = objectDTO.FloatValue;
                //       this.Ptr_PlayerDataManager.SAVE_PRO_LIFE_POINTS();

            }
            else if (propName == $"{nameof(EnumPlayerPropType.属性)}.{nameof(PlayerData.Ptr_PlayerData.SPEED)}")
            {
                playerData.SPEED = objectDTO.FloatValue;
            }
            else if (propName == $"{nameof(EnumPlayerPropType.属性)}.{nameof(PlayerData.Ptr_PlayerData.TALENT_ADD)}")
            {
                var add = objectDTO.IntValue;
                var use = playerData.USE_TALENT;
                if (add < use)
                {
                    add += use;
                }
                playerData.TALENT_ADD = add;
            }
            else if (propName == $"{nameof(EnumPlayerPropType.属性)}.{nameof(PlayerData.Ptr_PlayerData._BATTLE_SPEED)}")
            {
                playerData._BATTLE_SPEED = objectDTO.IntValue;
            }
            else if (propName.StartsWith(nameof(EnumPlayerPropType.武学)))
            {
                foreach (var item in playerData.KONG_FU_TYPE_LV.AsRefArray())
                {
                    var key = item.Key;
                    var id = $"{nameof(EnumPlayerPropType.武学)}.{key}";

                    if (propName == id)
                    {
                        var lv = objectDTO.IntValue;
                        var expItem = this.GameCache.Ptr_ExcelDataManager.GET_KONGFU_EXP_ITEM_BY_ID(lv);
                        if (expItem.IsNull())
                        {
                            lv = this.Ptr_PlayerDataManager.GET_KONG_FU_TYPE_LV(key);
                            expItem = this.GameCache.Ptr_ExcelDataManager.GET_KONGFU_EXP_ITEM_BY_ID(lv);
                        }
                        if (expItem)
                        {
                            ref int ref_value = ref Unsafe.AsRef(in item.Value);
                            ref_value = expItem.TOTALEXP;
                        }


                    }

                }



            }
            else if (propName.StartsWith(nameof(EnumPlayerPropType.生活)))
            {
                foreach (var item in playerData.LIFE_PRO.AsRefArray())
                {
                    var id = $"{nameof(EnumPlayerPropType.生活)}.{item.Key}";
                    if (propName == id)
                    {
                        ref int ref_value = ref Unsafe.AsRef(in item.Value);
                        ref_value = objectDTO.IntValue;
                    }
                }
                this.Ptr_PlayerDataManager.SAVE_PRO_LIFE_POINTS();

            }
            else if (propName.StartsWith(nameof(EnumPlayerPropType.特性)))
            {
                //  var characterHad = playerData.CHARACTER_HAD.AsRefArray();
                foreach (var item in this.GameCache.CharacterDataSets)
                {

                    var id = $"{nameof(EnumPlayerPropType.特性)}.{item.DisplayName}";
                    if (propName == id)
                    {
                        // var had = characterHad.Where(p => p.Key.AsReadOnlySpan().SequenceEqual(item.ObjectId.AsSpan())).Any();
                        //if (objectDTO.BoolValue != had)
                        //{
                        CharacterDataSet.Ptr_CharacterDataSet ptr_characterset = item.Ptr;

                        playerData.TALENT_ADD += (ptr_characterset.COST_POINT + playerData.USE_TALENT);
                        if (!this.Ptr_PlayerDataManager.BUY_TE_XING(ptr_characterset))
                        {
                            //playerData.TALENT_ADD -= add;
                        }
                        //   this.Ptr_PlayerDataManager.char
                        //}
                    }

                }
            }
            else if (propName.StartsWith(nameof(EnumPlayerPropType.好感度)))
            {
                foreach (var item in this.GameCache.Characters.Where(p => p.DisplayCategory == nameof(FriendData)))
                {
                    var id = $"{nameof(EnumPlayerPropType.好感度)}.{item.DisplayName}";
                    if (propName == id)
                    {
                        FriendLoveTableItem.Ptr_FriendLoveTableItem tableitem = item.Ptr;
                        this.Ptr_PlayerDataManager.CHANGE_FRIEND_LOVE(tableitem.NAME, objectDTO.IntValue, 0);
                    }
                }
            }

        }
        //



        private IEnumerable<GameSkillInfoDTO> GetPlayerSkill()
        {
            var playerData = this.Ptr_PlayerData;

            yield return new GameSkillInfoDTO() { ObjectId = string.Empty, DisplayName = string.Empty, DisplayCategory = nameof(InKangFuDataSet), DisplayDesc = string.Empty, CanWrite = true };
            yield return new GameSkillInfoDTO() { ObjectId = string.Empty, DisplayName = string.Empty, DisplayCategory = nameof(KangFuDataSet), DisplayDesc = string.Empty, CanWrite = true };
            yield return new GameSkillInfoDTO() { ObjectId = string.Empty, DisplayName = string.Empty, DisplayCategory = nameof(UniqueSkillDataSet), DisplayDesc = string.Empty, CanWrite = true };
            yield return new GameSkillInfoDTO() { ObjectId = string.Empty, DisplayName = string.Empty, DisplayCategory = nameof(ShanHaiLuDataSet), DisplayDesc = string.Empty, CanWrite = true };




            var in_kf_dress = playerData.DRESS_IN_KANG_FU;
            if (in_kf_dress)
            {
                var skillInfo = in_kf_dress._IN_KANG_FU_DATA;
                if (skillInfo)
                {
                    var skillName = skillInfo.NAME.ToString()!;
                    yield return new GameSkillInfoDTO() { ObjectId = skillName, DisplayName = skillName, DisplayCategory = nameof(InKangFuDataSet), DisplayDesc = skillInfo.DESCRIBE.ToString(), CanWrite = false };

                }
            }

            foreach (var skill in playerData.IN_KANG_FU_HAD.AsRefArray())
            {
                var skillObj = skill.Value;
                if (skillObj)
                {
                    var skillInfo = skillObj._IN_KANG_FU_DATA;
                    if (skillInfo)
                    {
                        var skillName = skillInfo.NAME.ToString()!;
                        yield return new GameSkillInfoDTO() { ObjectId = skillName, DisplayName = skillName, DisplayCategory = nameof(InKangFuDataSet), DisplayDesc = skillInfo.DESCRIBE.ToString(), CanWrite = false };
                    }
                }
            }


            foreach (var skill in playerData.DRESS_KANG_FU.AsRefArray())
            {
                var skillObj = skill.Value;
                if (skillObj)
                {
                    var skillInfo = skillObj._KANG_FU_DATA;
                    if (skillInfo)
                    {
                        var skillName = skillInfo.NAME.ToString()!;
                        yield return new GameSkillInfoDTO() { ObjectId = skillName, DisplayName = skillName, DisplayCategory = nameof(KangFuDataSet), DisplayDesc = skillInfo.DESCRIBE.ToString(), CanWrite = false };
                        foreach (var shan in skillObj.HAVE_SHAN_HAI_LU)
                        {
                            foreach (var shanhailu in this.GameCache.ShanHaiLuDataSets)
                            {
                                if (shan.AsReadOnlySpan().SequenceEqual(shanhailu.ObjectId))
                                {
                                    yield return new GameSkillInfoDTO() { ObjectId = shanhailu.ObjectId, DisplayName = shanhailu.DisplayName, DisplayCategory = nameof(ShanHaiLuDataSet), DisplayDesc = shanhailu.DisplayDesc, CanWrite = false };
                                }
                            }

                        }
                    }

                }

            }


            foreach (var skill in playerData.KANG_FU_HAD.AsRefArray())
            {
                var skillObj = skill.Value;
                if (skillObj)
                {
                    var skillInfo = skillObj._KANG_FU_DATA;
                    if (skillInfo)
                    {
                        var skillName = skillInfo.NAME.ToString()!;
                        yield return new GameSkillInfoDTO() { ObjectId = skillName, DisplayName = skillName, DisplayCategory = nameof(KangFuDataSet), DisplayDesc = skillInfo.DESCRIBE.ToString(), CanWrite = false };
                        foreach (var shan in skillObj.HAVE_SHAN_HAI_LU)
                        {
                            foreach (var shanhailu in this.GameCache.ShanHaiLuDataSets)
                            {
                                if (shan.AsReadOnlySpan().SequenceEqual(shanhailu.ObjectId))
                                {
                                    yield return new GameSkillInfoDTO() { ObjectId = shanhailu.ObjectId, DisplayName = shanhailu.DisplayName, DisplayCategory = nameof(ShanHaiLuDataSet), DisplayDesc = shanhailu.DisplayDesc, CanWrite = false };
                                }
                            }
                        }
                    }

                }

            }


            foreach (var skill in playerData.KANG_FU_SKILL_HAD.AsRefArray())
            {
                var skillObj = skill.Value;
                if (skillObj)
                {
                    var skillInfo = skillObj._UNIQUE_SKILL_DATA;
                    if (skillInfo)
                    {

                        var skillName = skillObj._NAME.ToString()!;
                        yield return new GameSkillInfoDTO() { ObjectId = skillName, DisplayName = skillName, DisplayCategory = nameof(UniqueSkillDataSet), DisplayDesc = skillInfo.DESCRIBE.ToString(), CanWrite = false };
                    }
                }

            }


            foreach (var skill in playerData.KANG_FU_QING_HAD.AsRefArray())
            {
                var skillObj = skill.Value;
                if (skillObj)
                {
                    var skillInfo = skillObj._UNIQUE_SKILL_DATA;
                    if (skillInfo)
                    {
                        var skillName = skillObj._NAME.ToString()!;
                        yield return new GameSkillInfoDTO() { ObjectId = skillName, DisplayName = skillName, DisplayCategory = nameof(UniqueSkillDataSet), DisplayDesc = skillInfo.DESCRIBE.ToString(), CanWrite = false };
                    }
                }
            }





            foreach (var skill in playerData.DRESS_SMALL_LOOP.AsRefArray())
            {
                var skillObj = skill.Value;
                if (skillObj)
                {
                    var skillInfo = skillObj._UNIQUE_SKILL_DATA;
                    if (skillInfo)
                    {
                        var skillName = skillObj._NAME.ToString()!;
                        yield return new GameSkillInfoDTO() { ObjectId = skillName, DisplayName = skillName, DisplayCategory = nameof(UniqueSkillDataSet), DisplayDesc = skillInfo.DESCRIBE.ToString(), CanWrite = false };
                    }
                }
            }


            foreach (var skill in playerData.DRESS_BIG_LOOP.AsRefArray())
            {
                var skillObj = skill.Value;
                if (skillObj)
                {
                    var skillInfo = skillObj._UNIQUE_SKILL_DATA;
                    if (skillInfo)
                    {
                        var skillName = skillObj._NAME.ToString()!;
                        yield return new GameSkillInfoDTO() { ObjectId = skillName, DisplayName = skillName, DisplayCategory = nameof(UniqueSkillDataSet), DisplayDesc = skillInfo.DESCRIBE.ToString(), CanWrite = false };
                    }
                }
            }


        }
        private void SetPlayerSkill(GameCharacterModifyDTO objectDTO)
        {
            PlayerData.Ptr_PlayerData playerData = this.Ptr_PlayerData;
            var oldSkill = objectDTO.ModifyObject;
            var newSkill = objectDTO.NewValue;

            if (string.IsNullOrEmpty(oldSkill) == false)
            {
                //remove..

            }

            if (string.IsNullOrEmpty(newSkill) == false)
            {

                if (objectDTO.ModifyCategory == nameof(InKangFuDataSet))
                {
                    var skill = this.GameCache.InKangFuDataSets.Where(p => p.ObjectId == newSkill).FirstOrDefault();
                    if (skill is not null)
                    {
                        this.Ptr_PlayerDataManager.AWARD_IN_KONG_FU(skill.Ptr);
                    }
                }
                else if (objectDTO.ModifyCategory == nameof(KangFuDataSet))
                {
                    var skill = this.GameCache.KangFuDataSets.Where(p => p.ObjectId == newSkill).FirstOrDefault();
                    if (skill is not null)
                    {
                        this.Ptr_PlayerDataManager.AWARD_KONG_FU(skill.Ptr);
                    }
                }
                else if (objectDTO.ModifyCategory == nameof(UniqueSkillDataSet))
                {
                    var skill = this.GameCache.UniqueSkillDataSets.Where(p => p.ObjectId == newSkill).FirstOrDefault();
                    if (skill is not null)
                    {
                        UniqueSkillDataSet.Ptr_UniqueSkillDataSet skillDataSet = skill.Ptr;
                        if (skillDataSet.KF_TYPE == KFType.轻)
                        {
                            this.Ptr_PlayerDataManager.AWARD_KANG_FU_QING(skill.Ptr);
                        }
                        this.Ptr_PlayerDataManager.AWARD_KONG_FU_SKILL(skill.Ptr);
                    }
                }
                else if (objectDTO.ModifyCategory == nameof(ShanHaiLuDataSet))
                {
                    var skill = this.GameCache.ShanHaiLuDataSets.Where(p => p.ObjectId == newSkill).FirstOrDefault();
                    if (skill is not null)
                    {
                        this.Ptr_PlayerDataManager.AWARD_SHAN_HAI_LU(skill.Ptr);
                    }
                }
            }


        }



        #endregion

        public GameInventoryInfoDTO GetInventoryInfoDTO(GameInventoryObjectDTO objectDTO)
        {
            var count = 0;

            if (objectDTO.InventoryCategory == nameof(EquipDataSet))
            {
                //if (this.TryGetEquipByDress(objectDTO.InventoryObject, out var _))
                //{
                //    count += 1;
                //}
                if (this.TryGetEquipByHad(objectDTO.InventoryObject, out var playerEquipDatas))
                {
                    count += playerEquipDatas.Length;
                }

            }
            else if (objectDTO.InventoryCategory == nameof(ChongDataSet))
            {
                if (this.TryGetChongByHad(objectDTO.InventoryObject, out var _))
                {
                    count += 1;
                }
                //if (this.TryGetChongByDress(objectDTO.InventoryObject, out var _))
                //{
                //    count += 1;
                //}

            }
            else if (objectDTO.InventoryCategory == nameof(ChongPotDataSet))
            {
                if (this.TryGetChongPotByHad(objectDTO.InventoryObject, out var _))
                {
                    count += 1;
                }
                //if (this.TryGetChongPotByDress(objectDTO.InventoryObject, out var _))
                //{
                //    count += 1;
                //}

            }
            return new GameInventoryInfoDTO() { ObjectId = objectDTO.InventoryObject, InventoryCount = count };

        }

        public GameInventoryInfoDTO UpdateInventoryInfoDTO(GameInventoryModifyDTO objectDTO)
        {
            var item = this.GameCache.Items.Where(p => p.DisplayCategory == objectDTO.InventoryCategory && p.ObjectId == objectDTO.InventoryObject).FirstOrDefault();
            if (item is null)
            {
                return GameException.Throw<GameInventoryInfoDTO>($"NOT FOUND:{objectDTO.InventoryCategory}-{objectDTO.InventoryObject}");
            }
            var count = objectDTO.InventoryCount;
            if (objectDTO.InventoryCategory == nameof(EquipDataSet))
            {
                this.Ptr_PlayerDataManager.AWARD_EQUIP(item.Ptr, count, true);

            }
            else if (objectDTO.InventoryCategory == nameof(ChongDataSet))
            {
                this.Ptr_PlayerDataManager.AWARD_CHONG(item.Ptr);

            }
            else if (objectDTO.InventoryCategory == nameof(ChongPotDataSet))
            {
                this.Ptr_PlayerDataManager.AWARD_CHONG_POT(item.Ptr);

            }
            return new GameInventoryInfoDTO() { ObjectId = objectDTO.InventoryObject, InventoryCount = count };

        }



        public GameCharacterStatusDTO GetCharacterStatusDTO(GameCharacterObjectDTO objectDTO)
        {
            if (objectDTO.CharacterCategory == nameof(PlayerData))
            {
                return new GameCharacterStatusDTO() { ObjectId = objectDTO.CharacterId, CharacterAttributes = [.. GetPlayerData()] };
            }
            else if (objectDTO.CharacterCategory == nameof(FriendData))
            {
                return new GameCharacterStatusDTO() { ObjectId = objectDTO.CharacterId, CharacterAttributes = [] };

            }
            return GameException.Throw<GameCharacterStatusDTO>($"NOUT FOUND:{objectDTO.CharacterCategory}");
        }

        public GameCharacterStatusDTO UpdateCharacterStatusDTO(GameCharacterModifyDTO objectDTO)
        {
            if (objectDTO.CharacterCategory == nameof(PlayerData))
            {
                SetPlayerData(objectDTO);
                return new GameCharacterStatusDTO() { ObjectId = objectDTO.CharacterId, CharacterAttributes = [.. GetPlayerData()] };
            }
            else if (objectDTO.CharacterCategory == nameof(FriendData))
            {
                return new GameCharacterStatusDTO() { ObjectId = objectDTO.CharacterId, CharacterAttributes = [] };

            }
            return GameException.Throw<GameCharacterStatusDTO>($"NOUT FOUND:{objectDTO.CharacterCategory}");

        }



        public GameCharacterSkillDTO GetCharacterSkillDTO(GameCharacterObjectDTO objectDTO)
        {
            if (objectDTO.CharacterCategory == nameof(PlayerData))
            {

                return new GameCharacterSkillDTO() { ObjectId = objectDTO.CharacterId, SkillInfos = [.. GetPlayerSkill()] };
            }
            else if (objectDTO.CharacterCategory == nameof(FriendData))
            {
                return new GameCharacterSkillDTO() { ObjectId = objectDTO.CharacterId, SkillInfos = [] };

            }
            return GameException.Throw<GameCharacterSkillDTO>($"NOUT FOUND:{objectDTO.CharacterCategory}");
        }
        public GameCharacterSkillDTO UpdateCharacterSkillDTO(GameCharacterModifyDTO objectDTO)
        {
            if (objectDTO.CharacterCategory == nameof(PlayerData))
            {
                SetPlayerSkill(objectDTO);
                return new GameCharacterSkillDTO() { ObjectId = objectDTO.CharacterId, SkillInfos = [.. GetPlayerSkill()] };
            }
            else if (objectDTO.CharacterCategory == nameof(FriendData))
            {
                return new GameCharacterSkillDTO() { ObjectId = objectDTO.CharacterId, SkillInfos = [] };

            }
            return GameException.Throw<GameCharacterSkillDTO>($"NOUT FOUND:{objectDTO.CharacterCategory}");


        }
    }


    public enum EnumPlayerPropType
    {
        属性 = 0,
        武学,
        生活,
        当前生活,
        六维,
        赌博,
        特性,
        好感度,

    }

    public enum EnumPlayerSkillType
    {
        内功,
        武艺,
        绝技
    }
}
