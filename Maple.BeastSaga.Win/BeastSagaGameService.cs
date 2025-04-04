using Maple.BeastSaga.Metadata;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.MetadataCollections;
using Maple.MonoGameAssistant.Model;
using Maple.MonoGameAssistant.Windows.HotKey.HookWindowMessage;
using Maple.MonoGameAssistant.Windows.Service;
using Maple.MonoGameAssistant.Windows.UITask;
using Microsoft.Extensions.Logging;
using System.Runtime.Intrinsics.X86;

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

        protected sealed override IUnityPlayerNativeMethods? LoadUnityEngineContext()
        {
            //UnityEngine.Graphics:Blit2+7f - 48 B8 D0FA4423FC7F0000 - mov rax,UnityPlayer.dll+9FAD0 { (610044232) }
            //UnityEngine.Graphics:Blit2+4b - E8 D0B2922B           - call UnityPlayer.dll+75F20


            //      UnityEngineContext_MONO.Func_BLIT2 = 0x9FAD0;
            // UnityEngineContext_MONO.Func_BLIT2 = 0x75F20;

            //UnityEngine.ImageConversion:EncodeToPNG+77 - 48 B8 B0385723FC7F0000 - mov rax,UnityPlayer.dll+1C38B0 { ("@USWH??H??") }
            //UnityEngine.ImageConversion:EncodeToPNG+43 - E8 28B4A02B           - call UnityPlayer.dll+156110

            //        UnityEngineContext_MONO.Func_ENCODE_TO_PNG = 0x1C38B0;
            //    UnityEngineContext_MONO.Func_ENCODE_TO_PNG = 0x156110;

            //UnityEngine.Sprite:GetTextureRect_Injected+86 - 48 B8 700B4D23FC7F0000 - mov rax,UnityPlayer.dll+120B70 { (610044232) }
            //UnityEngine.Sprite:GetTextureRect_Injected+57 - E8 6444992B           - call UnityPlayer.dll+DCD70

            //        UnityEngineContext_MONO.Func_GET_TEXTURE_RECT_INJECTED = 0x120B70;
            //     UnityEngineContext_MONO.Func_GET_TEXTURE_RECT_INJECTED = 0xDCD70;

            //UnityEngine.Texture2D:ReadPixelsImpl_Injected+8e - 48 B8 30584723FC7F0000 - mov rax,UnityPlayer.dll+C5830 { (610044232) }
            //UnityEngine.Texture2D:ReadPixelsImpl_Injected+6b - E8 00B6942B           - call UnityPlayer.dll+93FE0

            //         UnityEngineContext_MONO.Func_READ_PIXELS_IMPL_INJECTED = 0xC5830;
            //       UnityEngineContext_MONO.Func_READ_PIXELS_IMPL_INJECTED = 0x93FE0;

            var cache = Maple.MonoGameAssistant.MetadataUnity.UnityMetadataContext_MONO.MethodOffsetCache;
            cache[Maple.MonoGameAssistant.MetadataUnity.Graphics.Code_FunctionPointerType_BLIT2_E9370053514A1DE4] = 0x9FAD0;
            cache[Maple.MonoGameAssistant.MetadataUnity.ImageConversion.Code_FunctionPointerType_ENCODE_TO_PNG_B997C8D2C1188DD2] = 0x1C38B0;
            cache[Maple.MonoGameAssistant.MetadataUnity.Sprite.Code_FunctionPointerType_GET_TEXTURE_RECT_INJECTED_991A7878D43EDC7F] = 0x120B70;
            cache[Maple.MonoGameAssistant.MetadataUnity.Texture2D.Code_FunctionPointerType_READ_PIXELS_IMPL_INJECTED_3D6557C7BC276B18] = 0xC5830;

            return Maple.MonoGameAssistant.MetadataUnity.UnityMetadataContext.CreateUnityMetadataContext(this.RuntimeContext, this.Logger);
        }

        //protected override async ValueTask F9_KeyDown()
        //{
        //    var gameEnv = await GetBeastSagaGameEnvAsync().ConfigureAwait(false);
        //    await this.UITaskAsync((p, args) => args.Test(), gameEnv).ConfigureAwait(false);
        //}

        public required BeastSagaGameCache GameCache { set; get; }



        protected sealed override async ValueTask LoadGameDataAsync()
        {
            GameCache = await this.MonoTaskAsync(p => new BeastSagaGameCache(p)).ConfigureAwait(false);
            LoadGameSpriteData();
            void LoadGameSpriteData()
            {

                foreach (var item in this.GameCache.Currencies)
                {
                    if (this.GameSettings.TryGetGameResourceUrl(item.DisplayCategory!, $"{item.ImageName}.png", out var url))
                    {
                        item.DisplayImage = url;
                    }
                }
                foreach (var item in this.GameCache.Items)
                {
                    if (this.GameSettings.TryGetGameResourceUrl(item.DisplayCategory!, $"{item.ImageName}.png", out var url))
                    {
                        item.DisplayImage = url;
                    }
                }
                foreach (var item in this.GameCache.Skills)
                {
                    if (this.GameSettings.TryGetGameResourceUrl(item.DisplayCategory!, $"{item.ImageName}.png", out var url))
                    {
                        item.DisplayImage = url;
                    }
                }
                foreach (var item in this.GameCache.Characters)
                {
                    if (this.GameSettings.TryGetGameResourceUrl(item.DisplayCategory!, $"{item.ImageName}.png", out var url))
                    {
                        item.DisplayImage = url;
                    }
                }
            }

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


        public override async ValueTask<GameSessionInfoDTO> LoadResourceAsync()
        {
            var datas = await this.UITaskAsync(p => LoadGameSpriteData().ToArray()).ConfigureAwait(false);
            foreach (var data in datas)
            {
                this.GameSettings.WriteImageFile(data.SpriteData2.Span, data.DisplayCategory, $"{data.ObjectId}.png", false);
            }

            var gameEnv = await this.GetBeastSagaGameEnvAsync().ConfigureAwait(false);
            if (gameEnv.InGame())
            {
                await this.UITaskAsync((p, args) => args.CreateAllFriend(), gameEnv).ConfigureAwait(false);
                var datas2 = await this.UITaskAsync((p, args) => LoadPlayerImage(args).ToArray(), gameEnv).ConfigureAwait(false);
                foreach (var data in datas2)
                {
                    this.GameSettings.WriteImageFile(data.SpriteData2.Span, data.DisplayCategory, $"{data.ObjectId}.png", false);
                }
            }
            return await base.LoadResourceAsync().ConfigureAwait(false);

            IEnumerable<GameSpriteData> LoadGameSpriteData()
            {
                if (this.UnityEngineContext is null)
                {
                    yield break;
                }
                foreach (var item in this.GameCache.Currencies)
                {
                    var spriteData = item.SpriteData;
                    if (spriteData != nint.Zero)
                    {
                        var arrayData = this.UnityEngineContext.ReadSprite2Png(spriteData, IUnityPlayerNativeMethods.ReadSpriteType.TYPE2);
                        if (arrayData != nint.Zero)
                        {
                            yield return new GameSpriteData() { ObjectId = item.ImageName, DisplayCategory = item.DisplayCategory!, SpriteData = nint.Zero, SpriteData2 = arrayData.AsReadOnlySpan().ToArray() };
                        }
                    }
                }
                foreach (var item in this.GameCache.Items)
                {
                    var spriteData = item.SpriteData;
                    if (spriteData != nint.Zero)
                    {
                        var arrayData = this.UnityEngineContext.ReadSprite2Png(spriteData, IUnityPlayerNativeMethods.ReadSpriteType.TYPE2);
                        if (arrayData != nint.Zero)
                        {
                            yield return new GameSpriteData() { ObjectId = item.ImageName, DisplayCategory = item.DisplayCategory!, SpriteData = nint.Zero, SpriteData2 = arrayData.AsReadOnlySpan().ToArray() };
                        }
                    }
                }
                foreach (var item in this.GameCache.Skills)
                {
                    var spriteData = item.SpriteData;
                    if (spriteData != nint.Zero)
                    {
                        var arrayData = this.UnityEngineContext.ReadSprite2Png(spriteData, IUnityPlayerNativeMethods.ReadSpriteType.TYPE2);
                        if (arrayData != nint.Zero)
                        {
                            yield return new GameSpriteData() { ObjectId = item.ImageName, DisplayCategory = item.DisplayCategory!, SpriteData = nint.Zero, SpriteData2 = arrayData.AsReadOnlySpan().ToArray() };
                        }
                    }
                }
            }
            IEnumerable<GameSpriteData> LoadPlayerImage(BeastSagaGameEnv @this)
            {
                if (this.UnityEngineContext is null)
                {
                    yield break;
                }
                var frienddata = @this.Ptr_PlayerFriendDataManager._FRIEND_DATA;

                foreach (var friend in frienddata.ADD_FRIENDS.AsRefEnumerable())
                {

                    var friendObj = friend.Value;
                    var spriteData = friendObj._HEAD;
                    if (spriteData != nint.Zero)
                    {

                        var arrayData = this.UnityEngineContext.ReadSprite2Png(spriteData, IUnityPlayerNativeMethods.ReadSpriteType.TYPE2);
                        if (arrayData != nint.Zero)
                        {
                            yield return new GameSpriteData() { ObjectId = friendObj._AB_NAME.ToString()!, DisplayCategory = nameof(FriendData), SpriteData = nint.Zero, SpriteData2 = arrayData.AsReadOnlySpan().ToArray() };
                        }
                    }

                }

                foreach (var friend in frienddata.LEAVE_FRIENDS.AsRefEnumerable())
                {
                    var friendObj = friend.Value;
                    var spriteData = friendObj._HEAD;
                    if (spriteData != nint.Zero)
                    {

                        var arrayData = this.UnityEngineContext.ReadSprite2Png(spriteData, IUnityPlayerNativeMethods.ReadSpriteType.TYPE2);
                        if (arrayData != nint.Zero)
                        {
                            yield return new GameSpriteData() { ObjectId = friendObj._AB_NAME.ToString()!, DisplayCategory = nameof(FriendData), SpriteData = nint.Zero, SpriteData2 = arrayData.AsReadOnlySpan().ToArray() };
                        }
                    }

                }
            }

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

            var skills = await this.MonoTaskAsync((p, args) => args.gameEnv.GetCharacterSkillDTO(args.characterObjectDTO), (gameEnv, characterObjectDTO)).ConfigureAwait(false);
            foreach (var skill in skills.SkillInfos ?? [])
            {
                if (skill is GameSkillInfoDTOEX ex)
                {
                    if (this.GameSettings.TryGetGameResourceUrl(skill.DisplayCategory!, $"{ex.ImageName}.png", out var url))
                    {
                        skill.DisplayImage = url;
                    }
                }
                else
                {
                    if (this.GameSettings.TryGetGameResourceUrl(skill.DisplayCategory!, $"{skill.ObjectId}.png", out var url))
                    {
                        skill.DisplayImage = url;
                    }
                }
            }
            return skills;
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
