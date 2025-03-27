using Maple.BeastSaga.Metadata.Metadata;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.MetadataCollections;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataObject;
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


        //    public ListGeneric<ItemDataSet.Ptr_ItemDataSet>? List_Ptr_ItemDataSet { get; set; }


        public KFSchool[] KFSchools { get; } = Enum.GetValues<KFSchool>();// [KFSchool.五子, KFSchool.昆仑, KFSchool.必报, KFSchool.破道, KFSchool.穹空, KFSchool.百灵, KFSchool.皇羽, KFSchool.江湖];
        public KFType[] KFTypes { get; } = Enum.GetValues<KFType>();

        public BeastSagaGameCache(BeastSagaGameContext gameContext)
        {
            this.Context = gameContext;

            SpinWait.SpinUntil(() => LoadDataSet.Ptr_LoadDataSet._INSTANCE);
            this.Ptr_LoadDataSet = LoadDataSet.Ptr_LoadDataSet._INSTANCE;

            SpinWait.SpinUntil(() => OpenUIManager.Ptr_OpenUIManager._INST);
            this.Ptr_OpenUIManager = OpenUIManager.Ptr_OpenUIManager._INST;

            SpinWait.SpinUntil(() => ExcelDataManager.Ptr_ExcelDataManager.INSTANCE);
            this.Ptr_ExcelDataManager = ExcelDataManager.Ptr_ExcelDataManager.INSTANCE;

            SpinWait.SpinUntil(() => LogicHelper.Ptr_LogicHelper._INSTANCE);
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
        static string[] Friends { get; } =
            [
//"langying",
//"pachong",
//"tuqianqian",
//"maochunye",
//"langqitian",
//"langyuan",
//"shexing",
//"friendunit",
//"fulushou/friendfulushoufu",
//"fulushou/friendfulushoulu",
//"shixiao",
//"debutou",
//"luxi",
//"houqianchong",
//"maohualai",
//"fulushou/friendfulushoushou",
//"tanglang",
//"ashou",
//"shusanniang",
//"shou",
//"zanglinglong",
"huerjing",
//"feichong",


            ];
        public IEnumerable<GameCharacterDisplayDTOEX> GetCharacter()
        {
            foreach (var s in Friends)
            {
                yield return new GameCharacterDisplayDTOEX()
                {
                    ImageName = s,
                    ObjectId = s,
                    DisplayCategory = nameof(FriendData),
                    DisplayName = s,
                    DisplayDesc = s,
                };
            }

            yield return new GameCharacterDisplayDTOEX()
            {
                ImageName = "huerjing",
                Ptr = nint.Zero,
                ObjectId = "huerjing",
                DisplayCategory = nameof(FriendData),
                DisplayName = "虎二靖",
                DisplayDesc = "huerjing",

            };




            yield return new GameCharacterDisplayDTOEX()
            {
                ImageName = "九思",
                ObjectId = "九思",
                DisplayCategory = nameof(PlayerData),
                DisplayName = "九思",
                DisplayDesc = "九思",

            };


            foreach (var table in this.Ptr_ExcelDataManager.P_FRIEND_LOVE_TABLE.DICT.AsRefEnumerable())
            {
                var tableItem = table.Value;
                //   this.Logger.LogInformation("name:{name},name2:{name2},id:{id}", tableItem.NAME.ToString(), tableItem.NAME2.ToString(), tableItem.ID);
                var name = tableItem.NAME.ToString();
                var name2 = tableItem.NAME2;
                var fullname = name2.ToString()!;
                yield return new GameCharacterDisplayDTOEX()
                {
                    ImageName= fullname,
                    Ptr = tableItem,
                    ObjectId = fullname,
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
            foreach (var item in this.Ptr_LoadDataSet._EQUIPS_DATA_MANAGER.AsEnumerable())
            {
                var name = item._NAME.ToString()!;
                yield return new GameInventoryDisplayDTOEX()
                {
                    ImageName = name,
                    Ptr = item.Ptr,
                    SpriteData = item._ICON,
                    ObjectId = item.Ptr.ToString(),
                    DisplayName = $"{item._EQUIP_POSITION}.{item._NAME}",
                    DisplayDesc = item._DES.ToString(),
                    DisplayCategory = nameof(EquipDataSet),
                    ItemAttributes = [
                         new GameValueInfoDTO(){ObjectId = name, DisplayName = item._EQUIP_POSITION.ToString() },
                        new GameValueInfoDTO(){ObjectId = name, DisplayName = $"Lv.{item._LV}" },
                        new GameValueInfoDTO(){ObjectId = name, DisplayName =  $"Rank.{item._RANK}" },
                        new GameValueInfoDTO(){ObjectId = name, DisplayName =  $"Skill.{item._SKILL_NUM}" },

                        ]
                };
            }
        }

        private IEnumerable<GameCurrencyDisplayDTOEX> GetItemDataSet()
        {
            SpinWait.SpinUntil(() => this.Ptr_LoadDataSet._ITEM_DATA_MANAGER.IsNotNull());
 
            foreach (var item in this.Ptr_LoadDataSet._ITEM_DATA_MANAGER.AsEnumerable())
            {
              
                var name = item._NAME.ToString()!;
                this.Logger.LogInformation("name:{name}", name);
                yield return new GameCurrencyDisplayDTOEX()
                {
                    ImageName = name,
                    Ptr = item.Ptr,
                    SpriteData = item._ICON,
                    ObjectId = item.Ptr.ToString(),
                    DisplayName = $"{item._EQUIP_TYPE}.{name}",
                    DisplayDesc = item._ITEM_DES.ToString(),
                    DisplayCategory = item._EQUIP_TYPE.ToString(),

                };

            }
        }


        private IEnumerable<GameSkillDisplayDTOEX> GetKangFuDataSet()
        {
            SpinWait.SpinUntil(() => this.Ptr_LoadDataSet._KANG_FU_DATA_MANAGER.IsNotNull());
            foreach (var item in this.Ptr_LoadDataSet._KANG_FU_DATA_MANAGER.AsEnumerable())
            {
                var fullname = item.NAME.ToString()!;
                yield return new GameSkillDisplayDTOEX()
                {
                    ImageName = fullname,
                    Ptr = item.Ptr,
                    SpriteData = item.ICON,
                    ObjectId = item.Ptr.ToString(),
                    DisplayName = $"{item.KF_TYPE}.{fullname}",
                    DisplayDesc = item.DESCRIBE.ToString(),
                    DisplayCategory = nameof(KangFuDataSet)
                };
            }
        }


        private IEnumerable<GameSkillDisplayDTOEX> GetInKangFuDataSet()
        {
            SpinWait.SpinUntil(() => this.Ptr_LoadDataSet._IN_KANG_FU_DATA_MANAGER.IsNotNull());

            foreach (var item in this.Ptr_LoadDataSet._IN_KANG_FU_DATA_MANAGER.AsEnumerable())
            {
                var fullname = item.NAME.ToString()!;
                yield return new GameSkillDisplayDTOEX()
                {
                    ImageName = fullname,
                    Ptr = item.Ptr,
                    SpriteData = item.ICON,
                    ObjectId = item.Ptr.ToString(),
                    DisplayName = fullname,
                    DisplayDesc = item.DESCRIBE.ToString(),
                    DisplayCategory = nameof(InKangFuDataSet)
                };
            }
        }

        private IEnumerable<GameSkillDisplayDTOEX> GetUniqueSkillDataSet()
        {
            SpinWait.SpinUntil(() => this.Ptr_LoadDataSet._UNIQUE_SKILL_DATA_MANAGER.IsNotNull());
            foreach (var item in this.Ptr_LoadDataSet._UNIQUE_SKILL_DATA_MANAGER.AsEnumerable())
            {
                var fullname = item.NAME.ToString()!;
                yield return new GameSkillDisplayDTOEX()
                {
                    ImageName = fullname,
                    Ptr = item.Ptr,
                    SpriteData = item.ICON,
                    ObjectId = item.Ptr.ToString(),
                    DisplayName = $"{item.KF_TYPE}.{fullname}",
                    DisplayDesc = item.DESCRIBE.ToString(),
                    DisplayCategory = nameof(UniqueSkillDataSet)
                };
            }
        }

        private IEnumerable<GameInventoryDisplayDTOEX> GetMakeDataSet()
        {
            SpinWait.SpinUntil(() => this.Ptr_LoadDataSet._MAKE_DATA_MANAGER.IsNotNull());
            foreach (var item in this.Ptr_LoadDataSet._MAKE_DATA_MANAGER.AsEnumerable())
            {
                var fullname = item._NAME.ToString()!;
                yield return new GameInventoryDisplayDTOEX()
                {
                    ImageName = fullname,
                    Ptr = item.Ptr,
                    SpriteData = nint.Zero,
                    ObjectId = item.Ptr.ToString(),
                    DisplayName = fullname,
                    DisplayDesc = string.Empty,//item.DESCRIBE.ToString(),
                    DisplayCategory = nameof(MakeDataSet)
                };
            }
        }

        private IEnumerable<GameInventoryDisplayDTOEX> GetSkillDataSet()
        {
            SpinWait.SpinUntil(() => this.Ptr_LoadDataSet._SKILL_DATA_MANAGER.IsNotNull());
            foreach (var item in this.Ptr_LoadDataSet._SKILL_DATA_MANAGER.AsEnumerable())
            {
                var fullname = item.NAME.ToString()!;
                yield return new GameInventoryDisplayDTOEX()
                {
                    ImageName = fullname,
                    Ptr = item.Ptr,
                    SpriteData = item.ICON,
                    ObjectId = item.Ptr.ToString(),
                    DisplayName = fullname,
                    DisplayDesc = item.DES_UI.ToString(),
                    DisplayCategory = nameof(SkillDataSet)
                };
            }
        }

        private IEnumerable<GameInventoryDisplayDTOEX> GetChongDataSet()
        {
            SpinWait.SpinUntil(() => this.Ptr_LoadDataSet._CHONG_DATA_MANAGER.IsNotNull());
            foreach (var item in this.Ptr_LoadDataSet._CHONG_DATA_MANAGER.AsEnumerable())
            {
                var fullname = item._NAME.ToString()!;
                yield return new GameInventoryDisplayDTOEX()
                {
                    ImageName = fullname,
                    Ptr = item.Ptr,
                    SpriteData = item._ICON,
                    ObjectId = item.Ptr.ToString(),
                    DisplayName = $"Lv{item._RANK}.{fullname}",
                    DisplayDesc = item._TYPE.ToString(),
                    DisplayCategory = nameof(ChongDataSet)
                };
            }
        }

        private IEnumerable<GameInventoryDisplayDTOEX> GetChongPotDataSet()
        {
            SpinWait.SpinUntil(() => this.Ptr_LoadDataSet._CHONG_POT_DATA_MANAGER.IsNotNull());
            foreach (var item in this.Ptr_LoadDataSet._CHONG_POT_DATA_MANAGER.AsEnumerable())
            {
                var fullname = item._NAME.ToString()!;
                yield return new GameInventoryDisplayDTOEX()
                {
                    ImageName = fullname,
                    Ptr = item.Ptr,
                    SpriteData = item._ICON,
                    ObjectId = item.Ptr.ToString(),
                    DisplayName = $"Lv{item._RANK}.{fullname}",
                    DisplayDesc = item._EXPLAN.ToString(),
                    DisplayCategory = nameof(ChongPotDataSet)
                };
            }
        }

        private IEnumerable<GameSkillDisplayDTOEX> GetShanHaiLuDataSet()
        {
            SpinWait.SpinUntil(() => this.Ptr_LoadDataSet._SHAN_HAI_LU_DATA_MANAGER.IsNotNull());
            foreach (var item in this.Ptr_LoadDataSet._SHAN_HAI_LU_DATA_MANAGER.AsEnumerable())
            {
                var fullname = item. NAME.ToString()!;
                yield return new GameSkillDisplayDTOEX()
                {
                    ImageName = fullname,
                    Ptr = item.Ptr,
                    SpriteData = nint.Zero,

                    ObjectId = item.Ptr.ToString(),
                    DisplayName = fullname,
                    DisplayDesc = item.EXPLAIN.ToString(),
                    DisplayCategory = nameof(ShanHaiLuDataSet)
                };
            }
        }

        private IEnumerable<GameInventoryDisplayDTOEX> GetCharacterDataSet()
        {
            SpinWait.SpinUntil(() => this.Ptr_LoadDataSet._CHARACTER_DATA_MANAGER.IsNotNull());
            foreach (var item in this.Ptr_LoadDataSet._CHARACTER_DATA_MANAGER.AsEnumerable())
            {
                var fullname = item.NAME.ToString()!;
                yield return new GameInventoryDisplayDTOEX()
                {
                    ImageName = fullname,
                    Ptr = item.Ptr,
                    SpriteData = nint.Zero,
                    ObjectId = item.Ptr.ToString(),
                    DisplayName = fullname,
                    DisplayDesc = string.Empty,//; item.EXPLAIN.ToString(),
                    DisplayCategory = nameof(CharacterDataSet),


                };
            }
        }

        private IEnumerable<GameInventoryDisplayDTOEX> GetRandomBoxDataSet()
        {
            SpinWait.SpinUntil(() => this.Ptr_LoadDataSet._BOX_DATA_MANAGER.IsNotNull());
            foreach (var item in this.Ptr_LoadDataSet._BOX_DATA_MANAGER.AsEnumerable())
            {
                var fullname = item.NAME.ToString()!;
                yield return new GameInventoryDisplayDTOEX()
                {
                    ImageName = fullname,
                    Ptr = item.Ptr,
                    SpriteData = nint.Zero,
                    ObjectId = item.Ptr.ToString(),
                    DisplayName = fullname,
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


    }

    public sealed class GameInventoryDisplayDTOEX : GameInventoryDisplayDTO
    {
        public required string ImageName { set; get; }
        public required nint Ptr { set; get; }
        public nint SpriteData { set; get; }

    }

    public sealed class GameCharacterDisplayDTOEX : GameCharacterDisplayDTO
    {
        public required string ImageName { set; get; }
        public nint Ptr { set; get; }
        //    public nint SpriteData { set; get; }
    }


    public sealed class GameCurrencyDisplayDTOEX : GameCurrencyDisplayDTO
    {
        public required string ImageName { set; get; }
        public required nint Ptr { set; get; }
        public nint SpriteData { set; get; }

    }

    public sealed class GameSkillDisplayDTOEX : GameSkillDisplayDTO
    {
        public required string ImageName { set; get; }
        public required nint Ptr { set; get; }
        public nint SpriteData { set; get; }

    }
}
