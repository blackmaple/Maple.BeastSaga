using Maple.BeastSaga.Metadata.Metadata;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector;
using Microsoft.Extensions.Logging;
using System.Xml.Linq;

namespace Maple.BeastSaga.Metadata
{
    public partial class BeastSagaGameCache
    {


        public BeastSagaGameContext Context { get; }
        private ILogger Logger => Context.Logger;
        private LoadDataSet.Ptr_LoadDataSet Ptr_LoadDataSet { get; }
        private OpenUIManager.Ptr_OpenUIManager Ptr_OpenUIManager { get; }
        public ExcelDataManager.Ptr_ExcelDataManager Ptr_ExcelDataManager { get; }
        public LogicHelper.Ptr_LogicHelper Ptr_LogicHelper { get; }
        public GameCurrencyDisplayDTOEX[] Currencies { get; }
        public GameInventoryDisplayDTOEX[] Items { get; }
        public GameCharacterDisplayDTOEX[] Characters { get; }
        public GameInventoryDisplayDTOEX[] CharacterDataSets { get; }

        public GameSkillDisplayDTOEX[] Skills { get; }

        public KFSchool[] KFSchools { get; } = [KFSchool.五子, KFSchool.昆仑, KFSchool.必报, KFSchool.破道, KFSchool.穹空, KFSchool.百灵, KFSchool.皇羽, KFSchool.江湖];
        public KFType[] KFTypes  { get; } = [ 
         KFType.内            ,
         KFType.轻            ,
         KFType.绝            ,
         KFType.刀            ,
         KFType.剑            ,
         KFType.拳            ,
         KFType.棍            ,
         KFType.腿            ,
         KFType.鞭            ,
         KFType.掌            ,
         KFType.指            ,
         KFType.音            ,
         KFType.破            ,
        ];

        public BeastSagaGameCache(BeastSagaGameContext gameContext)
        {
            this.Context = gameContext;
            this.Ptr_LoadDataSet = LoadDataSet.Ptr_LoadDataSet._INSTANCE;
            this.Ptr_OpenUIManager = OpenUIManager.Ptr_OpenUIManager._INST;
            this.Ptr_ExcelDataManager = ExcelDataManager.Ptr_ExcelDataManager.INSTANCE;
            this.Ptr_LogicHelper = LogicHelper.Ptr_LogicHelper._INSTANCE;
            this.Currencies = [
                .. GetItemDataSet(),
            ];



            this.Skills = [
                .. GetKangFuDataSet(),
                .. GetInKangFuDataSet(),
                .. GetUniqueSkillDataSet(),
                .. GetShanHaiLuDataSet(),
                ];

            this.CharacterDataSets = [.. GetCharacterDataSet(),];
            this.Characters = [.. GetCharacter()];

            this.Items = [
                .. GetEquipDataSet(),
                ..GetChongDataSet(),
                ..GetChongPotDataSet(),

                ];
        }


        #region GameCharacterDisplayDTOEX
        public IEnumerable<GameCharacterDisplayDTOEX> GetCharacter()
        {

            yield return new GameCharacterDisplayDTOEX()
            {
                ObjectId = "九思",
                DisplayCategory = nameof(PlayerData),
                DisplayName = "九思",
                DisplayDesc = "九思",

            };


            foreach (var table in this.Ptr_ExcelDataManager.P_FRIEND_LOVE_TABLE.DICT.AsRefArray())
            {
                var tableItem = table.Value;
                //   this.Logger.LogInformation("name:{name},name2:{name2},id:{id}", tableItem.NAME.ToString(), tableItem.NAME2.ToString(), tableItem.ID);
                var name = tableItem.NAME.ToString();
                var name2 = tableItem.NAME2;
                yield return new GameCharacterDisplayDTOEX()
                {
                    Ptr = tableItem,
                    ObjectId = name2.ToString()!,
                    DisplayCategory = nameof(FriendData),
                    DisplayName = name,
                    DisplayDesc = name
                };
            }
        }
        #endregion

        #region GameInventoryDisplayDTOEX

        private IEnumerable<GameInventoryDisplayDTOEX> GetEquipDataSet()
        {
            foreach (var item in this.Ptr_LoadDataSet._EQUIPS_DATA_MANAGER)
            {
                yield return new GameInventoryDisplayDTOEX()
                {
                    Ptr = item.Ptr,
                    ObjectId = item._NAME.ToString()!,
                    DisplayName = item._NAME.ToString(),
                    DisplayDesc = item._DES.ToString(),
                    DisplayCategory = nameof(EquipDataSet)
                };
            }
        }

        private IEnumerable<GameCurrencyDisplayDTOEX> GetItemDataSet()
        {
            foreach (var item in this.Ptr_LoadDataSet._ITEM_DATA_MANAGER)
            {
                var name = item._NAME.ToString()!;
                yield return new GameCurrencyDisplayDTOEX()
                {
                    Ptr = item.Ptr,
                    ObjectId = name,
                    DisplayName = $"{item._EQUIP_TYPE}.{name}",
                    DisplayDesc = item._ITEM_DES.ToString(),
                    DisplayCategory = item._EQUIP_TYPE.ToString(),
                };
            }
        }


        private IEnumerable<GameSkillDisplayDTOEX> GetKangFuDataSet()
        {
            foreach (var item in this.Ptr_LoadDataSet._KANG_FU_DATA_MANAGER)
            {
                yield return new GameSkillDisplayDTOEX()
                {
                    Ptr = item.Ptr,
                    ObjectId = item.NAME.ToString()!,
                    DisplayName = item.NAME.ToString(),
                    DisplayDesc = item.DESCRIBE.ToString(),
                    DisplayCategory = nameof(KangFuDataSet)
                };
            }
        }


        private IEnumerable<GameSkillDisplayDTOEX> GetInKangFuDataSet()
        {
            foreach (var item in this.Ptr_LoadDataSet._IN_KANG_FU_DATA_MANAGER)
            {
                yield return new GameSkillDisplayDTOEX()
                {
                    Ptr = item.Ptr,
                    ObjectId = item.NAME.ToString()!,
                    DisplayName = item.NAME.ToString(),
                    DisplayDesc = item.DESCRIBE.ToString(),
                    DisplayCategory = nameof(InKangFuDataSet)
                };
            }
        }

        private IEnumerable<GameSkillDisplayDTOEX> GetUniqueSkillDataSet()
        {
            foreach (var item in this.Ptr_LoadDataSet._UNIQUE_SKILL_DATA_MANAGER)
            {
                yield return new GameSkillDisplayDTOEX()
                {
                    Ptr = item.Ptr,
                    ObjectId = item.NAME.ToString()!,
                    DisplayName = item.NAME.ToString(),
                    DisplayDesc = item.DESCRIBE.ToString(),
                    DisplayCategory = nameof(UniqueSkillDataSet)
                };
            }
        }

        private IEnumerable<GameInventoryDisplayDTOEX> GetMakeDataSet()
        {
            foreach (var item in this.Ptr_LoadDataSet._MAKE_DATA_MANAGER)
            {
                yield return new GameInventoryDisplayDTOEX()
                {
                    Ptr = item.Ptr,
                    ObjectId = item._NAME.ToString()!,
                    DisplayName = item._NAME.ToString(),
                    DisplayDesc = string.Empty,//item.DESCRIBE.ToString(),
                    DisplayCategory = nameof(MakeDataSet)
                };
            }
        }

        private IEnumerable<GameInventoryDisplayDTOEX> GetSkillDataSet()
        {
            foreach (var item in this.Ptr_LoadDataSet._SKILL_DATA_MANAGER)
            {
                yield return new GameInventoryDisplayDTOEX()
                {
                    Ptr = item.Ptr,
                    ObjectId = item.NAME.ToString()!,
                    DisplayName = item.NAME.ToString(),
                    DisplayDesc = item.DES_UI.ToString(),
                    DisplayCategory = nameof(SkillDataSet)
                };
            }
        }

        private IEnumerable<GameInventoryDisplayDTOEX> GetChongDataSet()
        {
            foreach (var item in this.Ptr_LoadDataSet._CHONG_DATA_MANAGER)
            {
                yield return new GameInventoryDisplayDTOEX()
                {
                    Ptr = item.Ptr,
                    ObjectId = item._NAME.ToString()!,
                    DisplayName = item._NAME.ToString(),
                    DisplayDesc = $"{item._TYPE}.{item._RANK}",
                    DisplayCategory = nameof(ChongDataSet)
                };
            }
        }

        private IEnumerable<GameInventoryDisplayDTOEX> GetChongPotDataSet()
        {
            foreach (var item in this.Ptr_LoadDataSet._CHONG_POT_DATA_MANAGER)
            {
                yield return new GameInventoryDisplayDTOEX()
                {
                    Ptr = item.Ptr,
                    ObjectId = item._NAME.ToString()!,
                    DisplayName = item._NAME.ToString(),
                    DisplayDesc = item._EXPLAN.ToString(),
                    DisplayCategory = nameof(ChongPotDataSet)
                };
            }
        }

        private IEnumerable<GameSkillDisplayDTOEX> GetShanHaiLuDataSet()
        {
            foreach (var item in this.Ptr_LoadDataSet._SHAN_HAI_LU_DATA_MANAGER)
            {
                yield return new GameSkillDisplayDTOEX()
                {
                    Ptr = item.Ptr,
                    ObjectId = item.NAME.ToString()!,
                    DisplayName = item.NAME.ToString(),
                    DisplayDesc = item.EXPLAIN.ToString(),
                    DisplayCategory = nameof(ShanHaiLuDataSet)
                };
            }
        }

        private IEnumerable<GameInventoryDisplayDTOEX> GetCharacterDataSet()
        {
            foreach (var item in this.Ptr_LoadDataSet._CHARACTER_DATA_MANAGER)
            {
                yield return new GameInventoryDisplayDTOEX()
                {
                    Ptr = item.Ptr,
                    ObjectId = item.NAME.ToString()!,
                    DisplayName = item.NAME.ToString(),
                    DisplayDesc = string.Empty,//; item.EXPLAIN.ToString(),
                    DisplayCategory = nameof(CharacterDataSet),


                };
            }
        }

        private IEnumerable<GameInventoryDisplayDTOEX> GetRandomBoxDataSet()
        {
            foreach (var item in this.Ptr_LoadDataSet._BOX_DATA_MANAGER)
            {
                yield return new GameInventoryDisplayDTOEX()
                {
                    Ptr = item.Ptr,
                    ObjectId = item.NAME.ToString()!,
                    DisplayName = item.NAME.ToString(),
                    DisplayDesc = string.Empty,//; item.EXPLAIN.ToString(),
                    DisplayCategory = nameof(RandomBoxDataSet)
                };
            }
        }
        #endregion

        #region UI

        public void ShowMsg(string msg)
        {
            var pStr = this.Context.T(msg);
            this.Ptr_OpenUIManager.SHOW_TIP(TipType.i1, pStr);
        }
        #endregion

        //public IEnumerable<GameSkillInfoDTO> GetGameSkillInfoDTO(GameSkillInfoDTO[] gameSkillInfoDTOs)
        //{
        //    var count = KangFuDataSets.Length;
        //    gameSkillInfoDTOs.Select(p => p.DisplayCategory == nameof(KangFuDataSet)).ToArray();

        //}
    }

    public sealed class GameInventoryDisplayDTOEX : GameInventoryDisplayDTO
    {
        public required nint Ptr { set; get; }


    }

    public sealed class GameCharacterDisplayDTOEX : GameCharacterDisplayDTO
    {
        public nint Ptr { set; get; }
    }


    public sealed class GameCurrencyDisplayDTOEX : GameCurrencyDisplayDTO
    {
        public required nint Ptr { set; get; }

    }

    public sealed class GameSkillDisplayDTOEX : GameSkillDisplayDTO
    {
        public required nint Ptr { set; get; }

    }
}
