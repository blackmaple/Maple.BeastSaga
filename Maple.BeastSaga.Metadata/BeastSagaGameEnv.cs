using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Microsoft.Extensions.Logging;
using System.Runtime.CompilerServices;
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


        public GameInventoryInfoDTO GetInventoryInfoDTO(GameInventoryObjectDTO objectDTO)
        {
            var count = 0;
            if (objectDTO.InventoryCategory == nameof(ItemDataSet))
            {
                //if (this.TryGetItemByDress(objectDTO.InventoryObject, out var ptr_PlayerItemData))
                //{
                //    count += ptr_PlayerItemData._COUNT;
                //}
                if (this.TryGetItemByHad(objectDTO.InventoryObject, out var ptr_PlayerItemData))
                {
                    count += ptr_PlayerItemData._COUNT;
                }
            }
            else if (objectDTO.InventoryCategory == nameof(EquipDataSet))
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
            else if (objectDTO.InventoryCategory == nameof(InKangFuDataSet))
            {

                if (this.TryGetInKangFuByHad(objectDTO.InventoryObject, out var _))
                {
                    count += 1;
                }
                //if (this.TryGetInKangFuByDress(objectDTO.InventoryObject, out var _))
                //{
                //    count += 1;
                //}

            }
            else if (objectDTO.InventoryCategory == nameof(KangFuDataSet))
            {
                if (this.TryGetKangFuByHad(objectDTO.InventoryObject, out var _))
                {
                    count += 1;
                }
                //if (this.TryGetKangFuByDress(objectDTO.InventoryObject, out var _))
                //{
                //    count += 1;
                //}
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
            if (objectDTO.InventoryCategory == nameof(ItemDataSet))
            {
                if (this.TryGetItemByHad(objectDTO.InventoryObject, out var ptr_PlayerItemData))
                {
                    ptr_PlayerItemData._COUNT = count;
                }
                else
                {
                    this.Ptr_PlayerDataManager.AWARD_ITEM(item.Ptr, count);
                }
            }
            else if (objectDTO.InventoryCategory == nameof(EquipDataSet))
            {
                this.Ptr_PlayerDataManager.AWARD_EQUIP(item.Ptr, count, true);

            }
            else if (objectDTO.InventoryCategory == nameof(InKangFuDataSet))
            {

                this.Ptr_PlayerDataManager.AWARD_IN_KONG_FU(item.Ptr);
            }
            else if (objectDTO.InventoryCategory == nameof(KangFuDataSet))
            {
                this.Ptr_PlayerDataManager.AWARD_KONG_FU(item.Ptr);

            }
            else if (objectDTO.InventoryCategory == nameof(ChongDataSet))
            {
                this.Ptr_PlayerDataManager.AWARD_CHONG(item.Ptr);

            }
            else if (objectDTO.InventoryCategory == nameof(ChongPotDataSet))
            {
                this.Ptr_PlayerDataManager.AWARD_CHONG_POT(item.Ptr);

            }
            else if (objectDTO.InventoryCategory == nameof(UniqueSkillDataSet))
            {
                this.Ptr_PlayerDataManager.AWARD_KONG_FU_SKILL(item.Ptr);
                this.Ptr_PlayerDataManager.AWARD_KANG_FU_QING(item.Ptr);
            }
            else if (objectDTO.InventoryCategory == nameof(CharacterDataSet))
            {
                this.Ptr_PlayerDataManager.BUY_TE_XING(item.Ptr);
            }
            else if (objectDTO.InventoryCategory == nameof(ShanHaiLuDataSet))
            {
                this.Ptr_PlayerDataManager.AWARD_SHAN_HAI_LU(item.Ptr);

            }
            return new GameInventoryInfoDTO() { ObjectId = objectDTO.InventoryObject, InventoryCount = count };

        }


    }
}
