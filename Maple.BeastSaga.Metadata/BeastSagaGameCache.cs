using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector;
using Microsoft.Extensions.Logging;

namespace Maple.BeastSaga.Metadata
{
    public partial class BeastSagaGameCache
    {


        public BeastSagaGameContext Context { get; }
        private ILogger Logger => Context.Logger;
        private LoadDataSet.Ptr_LoadDataSet Ptr_LoadDataSet { get; }
        public GameInventoryDisplayDTOEX[] Items { get; }
        public OpenUIManager.Ptr_OpenUIManager Ptr_OpenUIManager { get; }
        public BeastSagaGameCache(BeastSagaGameContext gameContext)
        {
            this.Context = gameContext;
            this.Ptr_LoadDataSet = LoadDataSet.Ptr_LoadDataSet._INSTANCE;
            this.Ptr_OpenUIManager = OpenUIManager.Ptr_OpenUIManager._INST;
            this.Items = [
                .. GetEquipDataSet(),
                .. GetItemDataSet(),
                ..GetKangFuDataSet(),
                ..GetInKangFuDataSet(),
                ..GetUniqueSkillDataSet(),
              //  ..GetMakeDataSet(),
                ..GetSkillDataSet(),
                ..GetChongDataSet(),
                ..GetChongPotDataSet(),
                ..GetShanHaiLuDataSet(),
                ..GetCharacterDataSet(),
              //  ..GetRandomBoxDataSet(),
                ];
        }

        public void ShowMsg(string msg)
        {
            var pStr = this.Context.T(msg);
            this.Ptr_OpenUIManager.SHOW_TIP(TipType.i1, pStr);
        }

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

        private IEnumerable<GameInventoryDisplayDTOEX> GetItemDataSet()
        {
            foreach (var item in this.Ptr_LoadDataSet._ITEM_DATA_MANAGER)
            {
                yield return new GameInventoryDisplayDTOEX()
                {
                    Ptr = item.Ptr,
                    ObjectId = item._NAME.ToString()!,
                    DisplayName = $"{item._EQUIP_TYPE}:{item._NAME}",
                    DisplayDesc = item._ITEM_DES.ToString(),
                    DisplayCategory = nameof(ItemDataSet)
                };
            }
        }


        private IEnumerable<GameInventoryDisplayDTOEX> GetKangFuDataSet()
        {
            foreach (var item in this.Ptr_LoadDataSet._KANG_FU_DATA_MANAGER)
            {
                yield return new GameInventoryDisplayDTOEX()
                {
                    Ptr = item.Ptr,
                    ObjectId = item.NAME.ToString()!,
                    DisplayName = item.NAME.ToString(),
                    DisplayDesc = item.DESCRIBE.ToString(),
                    DisplayCategory = nameof(KangFuDataSet)
                };
            }
        }


        private IEnumerable<GameInventoryDisplayDTOEX> GetInKangFuDataSet()
        {
            foreach (var item in this.Ptr_LoadDataSet._IN_KANG_FU_DATA_MANAGER)
            {
                yield return new GameInventoryDisplayDTOEX()
                {
                    Ptr = item.Ptr,
                    ObjectId = item.NAME.ToString()!,
                    DisplayName = item.NAME.ToString(),
                    DisplayDesc = item.DESCRIBE.ToString(),
                    DisplayCategory = nameof(InKangFuDataSet)
                };
            }
        }

        private IEnumerable<GameInventoryDisplayDTOEX> GetUniqueSkillDataSet()
        {
            foreach (var item in this.Ptr_LoadDataSet._UNIQUE_SKILL_DATA_MANAGER)
            {
                yield return new GameInventoryDisplayDTOEX()
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

        private IEnumerable<GameInventoryDisplayDTOEX> GetShanHaiLuDataSet()
        {
            foreach (var item in this.Ptr_LoadDataSet._SHAN_HAI_LU_DATA_MANAGER)
            {
                yield return new GameInventoryDisplayDTOEX()
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
                    DisplayCategory = nameof(CharacterDataSet)
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

    }

    public sealed class GameInventoryDisplayDTOEX : GameInventoryDisplayDTO
    {
        public required nint Ptr { set; get; }
    }
}
