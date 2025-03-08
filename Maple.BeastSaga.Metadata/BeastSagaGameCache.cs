using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Microsoft.Extensions.Logging;

namespace Maple.BeastSaga.Metadata
{
    public partial class BeastSagaGameCache
    {


        public BeastSagaGameContext Context { get; }
        private ILogger Logger => Context.Logger;
        private LoadDataSet.Ptr_LoadDataSet Ptr_LoadDataSet { get; }
        public GameInventoryDisplayDTO[] Items { get; }
        public BeastSagaGameCache(BeastSagaGameContext gameContext)
        {
            this.Context = gameContext;
            this.Ptr_LoadDataSet = LoadDataSet.Ptr_LoadDataSet._INSTANCE;
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
        private IEnumerable<GameInventoryDisplayDTO> GetEquipDataSet()
        {
            foreach (var item in this.Ptr_LoadDataSet._EQUIPS_DATA_MANAGER)
            {
                yield return new GameInventoryDisplayDTO()
                {
                    ObjectId = item.Ptr.ToString(),
                    DisplayName = item._NAME.ToString(),
                    DisplayDesc = item._DES.ToString(),
                    DisplayCategory = nameof(EquipDataSet)
                };
            }
        }

        private IEnumerable<GameInventoryDisplayDTO> GetItemDataSet()
        {
            foreach (var item in this.Ptr_LoadDataSet._ITEM_DATA_MANAGER)
            {
                yield return new GameInventoryDisplayDTO()
                {
                    ObjectId = item.Ptr.ToString(),
                    DisplayName = $"{item._EQUIP_TYPE}:{item._NAME}",
                    DisplayDesc = item._ITEM_DES.ToString(),
                    DisplayCategory = nameof(ItemDataSet)
                };
            }
        }


        private IEnumerable<GameInventoryDisplayDTO> GetKangFuDataSet()
        {
            foreach (var item in this.Ptr_LoadDataSet._KANG_FU_DATA_MANAGER)
            {
                yield return new GameInventoryDisplayDTO()
                {
                    ObjectId = item.Ptr.ToString(),
                    DisplayName = item.NAME.ToString(),
                    DisplayDesc = item.DESCRIBE.ToString(),
                    DisplayCategory = nameof(KangFuDataSet)
                };
            }
        }


        private IEnumerable<GameInventoryDisplayDTO> GetInKangFuDataSet()
        {
            foreach (var item in this.Ptr_LoadDataSet._IN_KANG_FU_DATA_MANAGER)
            {
                yield return new GameInventoryDisplayDTO()
                {
                    ObjectId = item.Ptr.ToString(),
                    DisplayName = item.NAME.ToString(),
                    DisplayDesc = item.DESCRIBE.ToString(),
                    DisplayCategory = nameof(InKangFuDataSet)
                };
            }
        }

        private IEnumerable<GameInventoryDisplayDTO> GetUniqueSkillDataSet()
        {
            foreach (var item in this.Ptr_LoadDataSet._UNIQUE_SKILL_DATA_MANAGER)
            {
                yield return new GameInventoryDisplayDTO()
                {
                    ObjectId = item.Ptr.ToString(),
                    DisplayName = item.NAME.ToString(),
                    DisplayDesc = item.DESCRIBE.ToString(),
                    DisplayCategory = nameof(UniqueSkillDataSet)
                };
            }
        }

        private IEnumerable<GameInventoryDisplayDTO> GetMakeDataSet()
        {
            foreach (var item in this.Ptr_LoadDataSet._MAKE_DATA_MANAGER)
            {
                yield return new GameInventoryDisplayDTO()
                {
                    ObjectId = item.Ptr.ToString(),
                    DisplayName = item._NAME.ToString(),
                    DisplayDesc = string.Empty ,//item.DESCRIBE.ToString(),
                    DisplayCategory = nameof(MakeDataSet)
                };
            }
        }

        private IEnumerable<GameInventoryDisplayDTO> GetSkillDataSet()
        {
            foreach (var item in this.Ptr_LoadDataSet._SKILL_DATA_MANAGER)
            {
                yield return new GameInventoryDisplayDTO()
                {
                    ObjectId = item.Ptr.ToString(),
                    DisplayName = item.NAME.ToString(),
                    DisplayDesc =  item.DES_UI.ToString(),
                    DisplayCategory = nameof(SkillDataSet)
                };
            }
        }

        private IEnumerable<GameInventoryDisplayDTO> GetChongDataSet()
        {
            foreach (var item in this.Ptr_LoadDataSet._CHONG_DATA_MANAGER)
            {
                yield return new GameInventoryDisplayDTO()
                {
                    ObjectId = item.Ptr.ToString(),
                    DisplayName = item._NAME.ToString(),
                    DisplayDesc = $"{item._TYPE}.{item._RANK}",
                    DisplayCategory = nameof(ChongDataSet)
                };
            }
        }

        private IEnumerable<GameInventoryDisplayDTO> GetChongPotDataSet()
        {
            foreach (var item in this.Ptr_LoadDataSet._CHONG_POT_DATA_MANAGER)
            {
                yield return new GameInventoryDisplayDTO()
                {
                    ObjectId = item.Ptr.ToString(),
                    DisplayName = item._NAME.ToString(),
                    DisplayDesc = item._EXPLAN.ToString(),
                    DisplayCategory = nameof(ChongPotDataSet)
                };
            }
        }

        private IEnumerable<GameInventoryDisplayDTO> GetShanHaiLuDataSet()
        {
            foreach (var item in this.Ptr_LoadDataSet._SHAN_HAI_LU_DATA_MANAGER)
            {
                yield return new GameInventoryDisplayDTO()
                {
                    ObjectId = item.Ptr.ToString(),
                    DisplayName = item.NAME.ToString(),
                    DisplayDesc = item.EXPLAIN.ToString(),
                    DisplayCategory = nameof(ShanHaiLuDataSet)
                };
            }
        }

        private IEnumerable<GameInventoryDisplayDTO> GetCharacterDataSet()
        {
            foreach (var item in this.Ptr_LoadDataSet._CHARACTER_DATA_MANAGER)
            {
                yield return new GameInventoryDisplayDTO()
                {
                    ObjectId = item.Ptr.ToString(),
                    DisplayName = item.NAME.ToString(),
                    DisplayDesc =string.Empty,//; item.EXPLAIN.ToString(),
                    DisplayCategory = nameof(CharacterDataSet)
                };
            }
        }

        private IEnumerable<GameInventoryDisplayDTO> GetRandomBoxDataSet()
        {
            foreach (var item in this.Ptr_LoadDataSet._BOX_DATA_MANAGER)
            {
                yield return new GameInventoryDisplayDTO()
                {
                    ObjectId = item.Ptr.ToString(),
                    DisplayName = item.NAME.ToString(),
                    DisplayDesc = string.Empty,//; item.EXPLAIN.ToString(),
                    DisplayCategory = nameof(RandomBoxDataSet)
                };
            }
        }

    }


}
