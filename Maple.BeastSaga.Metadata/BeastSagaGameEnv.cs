using Maple.MonoGameAssistant.GameDTO;
using Microsoft.Extensions.Logging;
using System.Runtime.CompilerServices;

namespace Maple.BeastSaga.Metadata
{
    public partial class BeastSagaGameEnv(BeastSagaGameCache gameCache)
    {
        public BeastSagaGameCache GameCache { get; } = gameCache;
        public BeastSagaGameContext Context => GameCache.Context;
        private ILogger Logger => Context.Logger;

        private PlayerDataManager.Ptr_PlayerDataManager Ptr_PlayerDataManager { get; } = PlayerDataManager.Ptr_PlayerDataManager._INSTANCE;
        private PlayerData.Ptr_PlayerData Ptr_PlayerData => Ptr_PlayerDataManager._PLAYER_DATA;


        public bool ThrowNotInGame()
        {
            var mgr = this.Ptr_PlayerDataManager;
            if (mgr.M_CACHED_PTR != nint.Zero && mgr._PLAYER_DATA != nint.Zero)
            {
                return true;
            }
            return GameException.ThrowIfNotLoaded<bool>();
        }

        private bool TryGetItemByDress(nint ptr, out PlayerItemData.Ptr_PlayerItemData ptr_PlayerItemData)
        {
            Unsafe.SkipInit(out ptr_PlayerItemData);
            foreach (var item in this.Ptr_PlayerData.DRESS_ITEM.AsRefArray())
            {
                ptr_PlayerItemData = item.Value;
                if (ptr_PlayerItemData._ITEM_DATA == ptr)
                {
                    return true;
                }
            }
            return false;

        }

        private bool TryGetItemByHad(nint ptr, out PlayerItemData.Ptr_PlayerItemData ptr_PlayerItemData)
        {
            Unsafe.SkipInit(out ptr_PlayerItemData);
            foreach (var item in this.Ptr_PlayerData.ITEM_HAD.AsRefArray())
            {
                ptr_PlayerItemData = item.Value;
                if (ptr_PlayerItemData._ITEM_DATA == ptr)
                {
                    return true;
                }
            }
            return false;
        }

        private bool TryGetEquipByDress(nint ptr, out PlayerEquipData.Ptr_PlayerEquipData ptr_PlayerEquipData)
        {
            Unsafe.SkipInit(out ptr_PlayerEquipData);
            foreach (var item in this.Ptr_PlayerData.PLAYER_DRESS_EQUIP.AsRefArray())
            {
                ptr_PlayerEquipData = item.Value;
                if (ptr_PlayerEquipData._EQUIP_DATA == ptr)
                {
                    return true;
                }
            }
            return false;
        }

        private bool TryGetEquipByHad(nint ptr, out PlayerEquipData.Ptr_PlayerEquipData ptr_PlayerEquipData)
        {
            Unsafe.SkipInit(out ptr_PlayerEquipData);
            foreach (var item in this.Ptr_PlayerData.EQUIP_HAD.AsRefArray())
            {
                ptr_PlayerEquipData = item.Value;
                if (ptr_PlayerEquipData._EQUIP_DATA == ptr)
                {
                    return true;
                }
            }
            return false;
        }

        public GameInventoryInfoDTO GetInventoryInfoDTO(GameInventoryObjectDTO objectDTO)
        {

        }


    }
}
