using Maple.MonoGameAssistant.Core;

namespace Maple.BeastSaga.Metadata
{
    public class GameSpriteData
    {
        public required string ObjectId { get; set; }
        public required string DisplayCategory { set; get; }
        public required PMonoArray<byte> SpriteData { get; set; }
        public required Memory<byte> SpriteData2 { get; set; }


    }
}
