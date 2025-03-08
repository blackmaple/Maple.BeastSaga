using Maple.BeastSaga.Metadata;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.Model;
using Maple.MonoGameAssistant.Windows.HotKey.HookWindowMessage;
using Maple.MonoGameAssistant.Windows.Service;
using Maple.MonoGameAssistant.Windows.UITask;
using Microsoft.Extensions.Logging;

namespace Maple.DinoTopia.Win
{
    internal sealed class BeastSagaGameService
        (ILogger<BeastSagaGameService> logger, MonoRuntimeContext runtimeContext, MonoTaskScheduler monoTaskScheduler, MonoGameSettings gameSettings, HookWinMsgFactory hookWinMsgFactory)
                : GameContextService<BeastSagaGameContext>(logger, runtimeContext, monoTaskScheduler, gameSettings, hookWinMsgFactory)
    {
        protected sealed override BeastSagaGameContext LoadGameContext()
        {
            var searchService = new MonoGameAssistant.MetadataExtensions.MetadataService.MetadataCollectorSearchService();
            searchService.UpdateMetadata(new MonoDescriptionCollectionDTO()
            {
                Classes = BeastSagaGameContext.MonoJsonClassDTO,
                Methods = BeastSagaGameContext.MonoJsonMethodDTO,
                Fields = BeastSagaGameContext.MonoJsonFieldDTO,
            });
            return new BeastSagaGameContext(Logger, searchService, RuntimeContext);
        }

        public required BeastSagaGameCache GameCache { set; get; }

        protected sealed override async ValueTask LoadGameDataAsync()
        {
            GameCache = await this.MonoTaskAsync(p => new BeastSagaGameCache(p)).ConfigureAwait(false);
        }

        Task<BeastSagaGameEnv> GetBeastSagaGameEnvAsync()
        {
            return this.MonoTaskAsync((p, arg) => new BeastSagaGameEnv(arg), this.GameCache);
        }
        async Task<BeastSagaGameEnv> GetBeastSagaGameEnvThrowIfNotInGameAsync()
        {
            var gameEnv = await GetBeastSagaGameEnvAsync().ConfigureAwait(false);
            gameEnv.ThrowIfNotInGame();
            return gameEnv;
        }


        //public sealed override ValueTask<GameCurrencyDisplayDTO[]> GetListCurrencyDisplayAsync()
        //{
        //    return new ValueTask<GameCurrencyDisplayDTO[]>(GameConfig.CurrencyDisplayDTOs);
        //}
        //public sealed override async ValueTask<GameCurrencyInfoDTO> GetCurrencyInfoAsync(GameCurrencyObjectDTO currencyObjectDTO)
        //{
        //    var gameEnv = await this.GetDinoTopiaGameEnvThrowIfNotInGame().ConfigureAwait(false);
        //    return await this.MonoTaskAsync((p, args) => args.gameEnv.GetGameCurrencyInfoDTO(args.currencyObjectDTO), (gameEnv, currencyObjectDTO)).ConfigureAwait(false);
        //}
        //public sealed override async ValueTask<GameCurrencyInfoDTO> UpdateCurrencyInfoAsync(GameCurrencyModifyDTO currencyModifyDTO)
        //{
        //    var gameEnv = await this.GetDinoTopiaGameEnvThrowIfNotInGame().ConfigureAwait(false);
        //    return await this.MonoTaskAsync((p, args) => args.gameEnv.UpdateGameCurrencyInfoDTO(args.currencyModifyDTO), (gameEnv, currencyModifyDTO)).ConfigureAwait(false);
        //}

        public sealed override ValueTask<GameInventoryDisplayDTO[]> GetListInventoryDisplayAsync()
        {
            return new ValueTask<GameInventoryDisplayDTO[]>(GameCache.Items);
        }
        public sealed override async ValueTask<GameInventoryInfoDTO> GetInventoryInfoAsync(GameInventoryObjectDTO inventoryObjectDTO)
        {
            var gameEnv = await this.GetBeastSagaGameEnvThrowIfNotInGameAsync().ConfigureAwait(false);
            return await this.MonoTaskAsync((p, args) => args.gameEnv.GetInventoryInfoDTO(args.inventoryObjectDTO), (gameEnv, inventoryObjectDTO)).ConfigureAwait(false);
        }
        public sealed override async ValueTask<GameInventoryInfoDTO> UpdateInventoryInfoAsync(GameInventoryModifyDTO inventoryObjectDTO)
        {
            var gameEnv = await this.GetBeastSagaGameEnvThrowIfNotInGameAsync().ConfigureAwait(false);
            return await this.MonoTaskAsync((p, args) => args.gameEnv.UpdateInventoryInfoDTO(args.inventoryObjectDTO), (gameEnv, inventoryObjectDTO)).ConfigureAwait(false);
        }


        //public sealed override ValueTask<GameSwitchDisplayDTO[]> GetListSwitchDisplayAsync()
        //{
        //    return new ValueTask<GameSwitchDisplayDTO[]>(GameConfig.SwitchDisplayDTOs);
        //}
        //public sealed override async ValueTask<GameSwitchDisplayDTO> UpdateSwitchDisplayAsync(GameSwitchModifyDTO gameSwitchModify)
        //{
        //    var gameEnv = await this.GetDinoTopiaGameEnvThrowIfNotInGame().ConfigureAwait(false);
        //    return await this.MonoTaskAsync((p, args) => args.gameEnv.UpdateGameSwitchDisplayDTO(args.gameSwitchModify), (gameEnv, gameSwitchModify)).ConfigureAwait(false);
        //}

    }


}
