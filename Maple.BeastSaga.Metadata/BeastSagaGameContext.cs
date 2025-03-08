using Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator;

namespace Maple.BeastSaga.Metadata
{
    [ContextParentMetadata<ContextMetadataCollector>(true)]

    [ContextMemberMetadata<BookContentDataSet>]
    [ContextMemberMetadata<CharacterDataSet>]
    [ContextMemberMetadata<ChongDataSet>]
    [ContextMemberMetadata<ChongPotDataSet>]
 //   [ContextMemberMetadata<ChongType>]
    [ContextMemberMetadata<EquipDataSet>]
  //  [ContextMemberMetadata<EquipDressName>]
 //   [ContextMemberMetadata<EquipPosition>]
  //  [ContextMemberMetadata<EquipType>]
  //  [ContextMemberMetadata<FiveType>]
    [ContextMemberMetadata<GameSetDataManager>]
  //  [ContextMemberMetadata<HurtType>]
    [ContextMemberMetadata<InKangFuDataSet>]
    [ContextMemberMetadata<ItemDataSet>]
  //  [ContextMemberMetadata<ItemPortBattle>]
  //  [ContextMemberMetadata<ItemType>]
  //  [ContextMemberMetadata<ItemUseTagget>]
  //  [ContextMemberMetadata<ItemUseType>]
    [ContextMemberMetadata<KangFuDataSet>]
 //   [ContextMemberMetadata<KFSchool>]
 //   [ContextMemberMetadata<KFType>]
    [ContextMemberMetadata<LoadDataSet>]
    [ContextMemberMetadata<MakeDataSet>]
    [ContextMemberMetadata<PlayerCharacter>]
    [ContextMemberMetadata<PlayerData>]
    [ContextMemberMetadata<PlayerDataManager>]
    [ContextMemberMetadata<PlayerFriendDataManager>]
    [ContextMemberMetadata<RandomBoxDataSet>]
    [ContextMemberMetadata<SaveFriendData>]
    [ContextMemberMetadata<ShanHaiLuDataSet>]
    [ContextMemberMetadata<SkillDataSet>]
    [ContextMemberMetadata<UniqueSkillDataSet>]
    public partial class BeastSagaGameContext
    { }
}
