namespace Maple.BeastSaga.Metadata.Metadata
{
    /// <summary>
    /// ["Model.Runtime".""."HurtType"]
    /// </summary>
    public enum HurtType : int
    {
        群体外伤 = 0x00000001,
        群体内伤 = 0x00000002,
        群体真伤 = 0x00000003,
        群体治疗 = 0x00000004,
        单体治疗 = 0x00000005,
        单体外伤 = 0x00000006,
        单体内伤 = 0x00000007,
        单体真伤 = 0x00000008,
        召唤物体 = 0x00000009,
        放置范围 = 0x0000000A
    }
}