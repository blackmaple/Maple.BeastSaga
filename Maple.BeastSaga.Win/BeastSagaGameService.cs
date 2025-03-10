﻿using Maple.BeastSaga.Metadata;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.Model;
using Maple.MonoGameAssistant.Windows.HotKey.HookWindowMessage;
using Maple.MonoGameAssistant.Windows.Service;
using Maple.MonoGameAssistant.Windows.UITask;
using Microsoft.Extensions.Logging;

namespace Maple.BeastSaga.Win
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


        protected override async ValueTask F9_KeyDown()
        {
            var gameEnv = await GetBeastSagaGameEnvAsync().ConfigureAwait(false);
            await this.UITaskAsync((p, args) => args.Test(), gameEnv).ConfigureAwait(false);
        }

        public required BeastSagaGameCache GameCache { set; get; }



        protected sealed override async ValueTask LoadGameDataAsync()
        {
            GameCache = await this.MonoTaskAsync(p => new BeastSagaGameCache(p)).ConfigureAwait(false);
        }

        Task<BeastSagaGameEnv> GetBeastSagaGameEnvAsync()
        {
            return this.MonoTaskAsync((p, arg) => new BeastSagaGameEnv(arg), GameCache);
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
            var gameEnv = await GetBeastSagaGameEnvThrowIfNotInGameAsync().ConfigureAwait(false);
            return await this.MonoTaskAsync((p, args) => args.gameEnv.GetInventoryInfoDTO(args.inventoryObjectDTO), (gameEnv, inventoryObjectDTO)).ConfigureAwait(false);
        }
        public sealed override async ValueTask<GameInventoryInfoDTO> UpdateInventoryInfoAsync(GameInventoryModifyDTO inventoryObjectDTO)
        {
            var gameEnv = await GetBeastSagaGameEnvThrowIfNotInGameAsync().ConfigureAwait(false);
            return await this.UITaskAsync((p, args) => args.gameEnv.UpdateInventoryInfoDTO(args.inventoryObjectDTO), (gameEnv, inventoryObjectDTO)).ConfigureAwait(false);
        }
        public sealed override ValueTask<GameCurrencyDisplayDTO[]> GetListCurrencyDisplayAsync()
        {
            return new ValueTask<GameCurrencyDisplayDTO[]>(GameCache.Currencies);
        }

        public sealed override async ValueTask<GameCurrencyInfoDTO> GetCurrencyInfoAsync(GameCurrencyObjectDTO currencyObjectDTO)
        {
            var gameEnv = await GetBeastSagaGameEnvThrowIfNotInGameAsync().ConfigureAwait(false);
            return await this.MonoTaskAsync((p, args) => args.gameEnv.GetCurrencyInfoDTO(args.currencyObjectDTO), (gameEnv, currencyObjectDTO)).ConfigureAwait(false);
        }

        public sealed override async ValueTask<GameCurrencyInfoDTO> UpdateCurrencyInfoAsync(GameCurrencyModifyDTO currencyModifyDTO)
        {
            var gameEnv = await GetBeastSagaGameEnvThrowIfNotInGameAsync().ConfigureAwait(false);
            return await this.MonoTaskAsync((p, args) => args.gameEnv.UpdateCurrencyInfoDTO(args.currencyModifyDTO), (gameEnv, currencyModifyDTO)).ConfigureAwait(false);
        }


        public sealed override ValueTask<GameCharacterDisplayDTO[]> GetListCharacterDisplayAsync()
        {
            return new ValueTask<GameCharacterDisplayDTO[]>(GameCache.Characters);
        }

        private async ValueTask TryGetOrCreateFriendThrowIfCreateTimeout(BeastSagaGameEnv gameEnv, string characterId, string? characterCategory)
        {
            if (characterCategory != nameof(FriendData))
            {
                return;
            }
            if (false == await this.MonoTaskAsync((p, args) => args.gameEnv.ExistsFriendObject(characterId), (gameEnv, characterId)).ConfigureAwait(false))
            {
                if (false == await this.UITaskAsync((p, args) => args.gameEnv.TryCreateFriend(args.characterId), (gameEnv, characterId)).ConfigureAwait(false)
                    || false == await this.MonoTaskAsync((p, args) => args.gameEnv.WaitExistsFriendObject(characterId), (gameEnv, characterId)).ConfigureAwait(false))
                {
                    GameException.Throw<bool>($"NOT FOUND:{characterId}");
                }
            }
        }

        public sealed override async ValueTask<GameCharacterStatusDTO> GetCharacterStatusAsync(GameCharacterObjectDTO characterObjectDTO)
        {
            var gameEnv = await GetBeastSagaGameEnvThrowIfNotInGameAsync().ConfigureAwait(false);
            await TryGetOrCreateFriendThrowIfCreateTimeout(gameEnv, characterObjectDTO.CharacterId, characterObjectDTO.CharacterCategory).ConfigureAwait(false);
            return await this.MonoTaskAsync((p, args) => args.gameEnv.GetCharacterStatusDTO(args.characterObjectDTO), (gameEnv, characterObjectDTO)).ConfigureAwait(false);
        }

        public sealed override async ValueTask<GameCharacterStatusDTO> UpdateCharacterStatusAsync(GameCharacterModifyDTO characterModifyDTO)
        {
            var gameEnv = await GetBeastSagaGameEnvThrowIfNotInGameAsync().ConfigureAwait(false);
            //   await TryGetOrCreateFriendThrowIfCreateTimeout(gameEnv, characterModifyDTO.CharacterId, characterModifyDTO.CharacterCategory).ConfigureAwait(false);
            return await this.MonoTaskAsync((p, args) => args.gameEnv.UpdateCharacterStatusDTO(args.characterModifyDTO), (gameEnv, characterModifyDTO)).ConfigureAwait(false);

        }


        public sealed override async ValueTask<GameCharacterSkillDTO> GetCharacterSkillAsync(GameCharacterObjectDTO characterObjectDTO)
        {
            var gameEnv = await GetBeastSagaGameEnvThrowIfNotInGameAsync().ConfigureAwait(false);
            await TryGetOrCreateFriendThrowIfCreateTimeout(gameEnv, characterObjectDTO.CharacterId, characterObjectDTO.CharacterCategory).ConfigureAwait(false);

            return await this.MonoTaskAsync((p, args) => args.gameEnv.GetCharacterSkillDTO(args.characterObjectDTO), (gameEnv, characterObjectDTO)).ConfigureAwait(false);
        }

        public sealed override async ValueTask<GameCharacterSkillDTO> UpdateCharacterSkillAsync(GameCharacterModifyDTO characterModifyDTO)
        {
            var gameEnv = await GetBeastSagaGameEnvThrowIfNotInGameAsync().ConfigureAwait(false);
            return await this.MonoTaskAsync((p, args) => args.gameEnv.UpdateCharacterSkillDTO(args.characterModifyDTO), (gameEnv, characterModifyDTO)).ConfigureAwait(false);
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


        public sealed override ValueTask<GameSkillDisplayDTO[]> GetListSkillDisplayAsync()
        {
            return new ValueTask<GameSkillDisplayDTO[]>(GameCache.Skills);
        }
    }


}
