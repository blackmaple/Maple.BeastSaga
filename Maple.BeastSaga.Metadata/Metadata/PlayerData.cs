using Maple.BeastSaga.Metadata.Metadata;
using Maple.MonoGameAssistant.Core;

namespace Maple.BeastSaga.Metadata
{
    /// <summary>
    /// class ["Model.Runtime".""."PlayerData"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_PlayerData>, Ptr_PlayerData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Model.Runtime", "", "PlayerData", "PlayerData")]
    public partial class PlayerData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_PlayerData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_PlayerData(System.IntPtr ptr) => new Ptr_PlayerData(ptr);
            public static implicit operator System.IntPtr(Ptr_PlayerData ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_PlayerData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Model.Runtime".""."PlayerData"]
        /// </summary>
        partial struct Ptr_PlayerData
        {
            /// <summary>
            /// 0x10 System.String BGM
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("BGM", "System.String")]
           public partial nint BGM { get; set; } 
*/

            /// <summary>
            /// 0x18 System.String CurrentMapBGM
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("CurrentMapBGM", "System.String")]
           public partial nint CURRENT_MAP_BGM { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Collections.Generic.List<System.String> Task
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Task", "System.Collections.Generic.List<System.String>")]
           public partial nint TASK { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Collections.Generic.Dictionary<System.Int32 , PlayerItemData> DressItem
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Int32 , PlayerItemData></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("DressItem", "System.Collections.Generic.Dictionary<System.Int32,PlayerItemData>")]
            public partial PMonoDictionary_BeastSaga<int, PlayerItemData.Ptr_PlayerItemData> DRESS_ITEM { get; set; }


            /// <summary>
            /// 0x30 System.Collections.Generic.Dictionary<System.String , PlayerItemData> ItemHad
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , PlayerItemData></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ItemHad", "System.Collections.Generic.Dictionary<System.String,PlayerItemData>")]
            public partial PMonoDictionary_BeastSaga<int, PlayerItemData.Ptr_PlayerItemData> ITEM_HAD { get; set; }


            /// <summary>
            /// 0x38 System.Collections.Generic.Dictionary<WeaponEquipUIIndex , PlayerEquipData> PlayerDressEquip
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<WeaponEquipUIIndex , PlayerEquipData></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("PlayerDressEquip", "System.Collections.Generic.Dictionary<WeaponEquipUIIndex,PlayerEquipData>")]
            public partial PMonoDictionary_BeastSaga<WeaponEquipUIIndex, PlayerEquipData.Ptr_PlayerEquipData> PLAYER_DRESS_EQUIP { get; set; }


            /// <summary>
            /// 0x40 System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<PlayerEquipData>> EquipHad
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<PlayerEquipData>></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("EquipHad", "System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<PlayerEquipData>>")]
            public partial PMonoDictionary_BeastSaga<PMonoString, PMonoList_BeastSaga<PlayerEquipData.Ptr_PlayerEquipData>> EQUIP_HAD { get; set; }


            /// <summary>
            /// 0x48 System.Collections.Generic.Dictionary<System.String , PlayerItemData> ItemHadTemp
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , PlayerItemData></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ItemHadTemp", "System.Collections.Generic.Dictionary<System.String,PlayerItemData>")]
           public partial nint ITEM_HAD_TEMP { get; set; } 
*/

            /// <summary>
            /// 0x50 System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<PlayerEquipData>> EquipHadTemp
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<PlayerEquipData>></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("EquipHadTemp", "System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<PlayerEquipData>>")]
           public partial nint EQUIP_HAD_TEMP { get; set; } 
*/

            /// <summary>
            /// 0x58 System.String DressInKangFuName
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("DressInKangFuName", "System.String")]
           public partial nint DRESS_IN_KANG_FU_NAME { get; set; } 
*/

            /// <summary>
            /// 0x60 PlayerInKangFu DressInKangFu
            /// class ["Model.Runtime".""."PlayerInKangFu"]
            /// </summary>
            /// <returns>class PlayerInKangFu</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("DressInKangFu", "PlayerInKangFu")]
            public partial PlayerInKangFu.Ptr_PlayerInKangFu DRESS_IN_KANG_FU { get; set; }


            /// <summary>
            /// 0x68 System.Collections.Generic.Dictionary<System.String , PlayerInKangFu> InKangFuHad
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , PlayerInKangFu></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("InKangFuHad", "System.Collections.Generic.Dictionary<System.String,PlayerInKangFu>")]
            public partial PMonoDictionary_BeastSaga<PMonoString, PlayerInKangFu.Ptr_PlayerInKangFu> IN_KANG_FU_HAD { get; set; }


            /// <summary>
            /// 0x70 System.Collections.Generic.Dictionary<System.String , PlayerKangFu> KangFuHad
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , PlayerKangFu></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("KangFuHad", "System.Collections.Generic.Dictionary<System.String,PlayerKangFu>")]
            public partial PMonoDictionary_BeastSaga<PMonoString, PlayerKangFu.Ptr_PlayerKangFu> KANG_FU_HAD { get; set; }


            /// <summary>
            /// 0x78 System.Collections.Generic.Dictionary<System.String , PlayerKangFuSkill> KangFuSkillHad
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , PlayerKangFuSkill></returns>
      
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("KangFuSkillHad", "System.Collections.Generic.Dictionary<System.String,PlayerKangFuSkill>")]
           public partial PMonoDictionary_BeastSaga<PMonoString, PlayerKangFuSkill.Ptr_PlayerKangFuSkill> KANG_FU_SKILL_HAD { get; set; } 
 

            /// <summary>
            /// 0x80 System.Collections.Generic.Dictionary<System.String , PlayerKangFuSkill> KangFuQingHad
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , PlayerKangFuSkill></returns>
      
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("KangFuQingHad", "System.Collections.Generic.Dictionary<System.String,PlayerKangFuSkill>")]
           public partial PMonoDictionary_BeastSaga<PMonoString, PlayerKangFuSkill.Ptr_PlayerKangFuSkill> KANG_FU_QING_HAD { get; set; } 
 

            /// <summary>
            /// 0x88 System.Collections.Generic.List<PlayerChong> ChongHad
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<PlayerChong></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ChongHad", "System.Collections.Generic.List<PlayerChong>")]
            public partial PMonoList_BeastSaga<PlayerChong.Ptr_PlayerChong> CHONG_HAD { get; set; }


            /// <summary>
            /// 0x90 System.Collections.Generic.List<PlayerChongPot> ChongPotHad
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<PlayerChongPot></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ChongPotHad", "System.Collections.Generic.List<PlayerChongPot>")]
            public partial PMonoList_BeastSaga<PlayerChongPot.Ptr_PlayerChongPot> CHONG_POT_HAD { get; set; }


            /// <summary>
            /// 0x98 PlayerChong DressChong
            /// class ["Model.Runtime".""."PlayerChong"]
            /// </summary>
            /// <returns>class PlayerChong</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("DressChong", "PlayerChong")]
            public partial PlayerChong.Ptr_PlayerChong DRESS_CHONG { get; set; }


            /// <summary>
            /// 0xA0 System.Collections.Generic.Dictionary<System.String , PlayerKangFu> DressKangFu
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , PlayerKangFu></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("DressKangFu", "System.Collections.Generic.Dictionary<System.String,PlayerKangFu>")]
            public partial PMonoDictionary_BeastSaga<PMonoString, PlayerKangFu.Ptr_PlayerKangFu> DRESS_KANG_FU { get; set; }


            /// <summary>
            /// 0xA8 System.Collections.Generic.Dictionary<System.Int32 , System.String> DressQuickKangFu
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Int32 , System.String></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("DressQuickKangFu", "System.Collections.Generic.Dictionary<System.Int32,System.String>")]
           public partial nint DRESS_QUICK_KANG_FU { get; set; } 
*/

            /// <summary>
            /// 0xB0 System.Collections.Generic.Dictionary<System.String , PlayerKangFuSkill> DressBigLoop
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , PlayerKangFuSkill></returns>
         
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("DressBigLoop", "System.Collections.Generic.Dictionary<System.String,PlayerKangFuSkill>")]
           public partial PMonoDictionary_BeastSaga<PMonoString, PlayerKangFuSkill.Ptr_PlayerKangFuSkill> DRESS_BIG_LOOP { get; set; } 
 

            /// <summary>
            /// 0xB8 System.Collections.Generic.Dictionary<System.String , PlayerKangFuSkill> DressSmallLoop
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , PlayerKangFuSkill></returns>
      
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("DressSmallLoop", "System.Collections.Generic.Dictionary<System.String,PlayerKangFuSkill>")]
           public partial PMonoDictionary_BeastSaga<PMonoString, PlayerKangFuSkill.Ptr_PlayerKangFuSkill> DRESS_SMALL_LOOP { get; set; } 
 

            /// <summary>
            /// 0xC0 System.Collections.Generic.Dictionary<System.Int32 , System.Int32> SkinHad
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Int32 , System.Int32></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("SkinHad", "System.Collections.Generic.Dictionary<System.Int32,System.Int32>")]
           public partial nint SKIN_HAD { get; set; } 
*/

            /// <summary>
            /// 0xC8 System.Collections.Generic.Dictionary<KFType , System.Int32> KongFuTypeLv
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<KFType , System.Int32></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("KongFuTypeLv", "System.Collections.Generic.Dictionary<KFType,System.Int32>")]
            public partial PMonoDictionary_BeastSaga<KFType, System.Int32> KONG_FU_TYPE_LV { get; set; }


            /// <summary>
            /// 0xD0 System.Collections.Generic.Dictionary<MakeType , System.Collections.Generic.List<System.String>> MakeRecipe
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<MakeType , System.Collections.Generic.List<System.String>></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("MakeRecipe", "System.Collections.Generic.Dictionary<MakeType,System.Collections.Generic.List<System.String>>")]
           public partial nint MAKE_RECIPE { get; set; } 
*/

            /// <summary>
            /// 0xD8 System.Collections.Generic.Dictionary<LifeType , System.Int32> LifePro
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<LifeType , System.Int32></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("LifePro", "System.Collections.Generic.Dictionary<LifeType,System.Int32>")]
            public partial PMonoDictionary_BeastSaga<LifeType, System.Int32> LIFE_PRO { get; set; }


            /// <summary>
            /// 0xE0 System.Collections.Generic.Dictionary<LifeType , System.Int32> LifeProCurrent
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<LifeType , System.Int32></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("LifeProCurrent", "System.Collections.Generic.Dictionary<LifeType,System.Int32>")]
            public partial PMonoDictionary_BeastSaga<LifeType, int> LIFE_PRO_CURRENT { get; set; }


            /// <summary>
            /// 0xE8 System.Collections.Generic.Dictionary<PlayerProType , System.Int32> SixProCurrent
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<PlayerProType , System.Int32></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("SixProCurrent", "System.Collections.Generic.Dictionary<PlayerProType,System.Int32>")]
            public partial PMonoDictionary_BeastSaga<PlayerProType, int> SIX_PRO_CURRENT { get; set; }


            /// <summary>
            /// 0xF0 System.Collections.Generic.Dictionary<System.String , System.Single> Fish
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Single></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Fish", "System.Collections.Generic.Dictionary<System.String,System.Single>")]
           public partial nint FISH { get; set; } 
*/

            /// <summary>
            /// 0xF8 System.Collections.Generic.Dictionary<System.String , System.Int32> Gamble
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Int32></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Gamble", "System.Collections.Generic.Dictionary<System.String,System.Int32>")]
            public partial PMonoDictionary_BeastSaga<PMonoString, int> GAMBLE { get; set; }


            /// <summary>
            /// 0x100 System.Collections.Generic.Dictionary<System.String , FoodItemData> FoodItem
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , FoodItemData></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("FoodItem", "System.Collections.Generic.Dictionary<System.String,FoodItemData>")]
           public partial nint FOOD_ITEM { get; set; } 
*/

            /// <summary>
            /// 0x108 System.Collections.Generic.Dictionary<System.String , PlayerCharacter> CharacterHad
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , PlayerCharacter></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("CharacterHad", "System.Collections.Generic.Dictionary<System.String,PlayerCharacter>")]
            public partial PMonoDictionary_BeastSaga<PMonoString, PlayerCharacter.Ptr_PlayerCharacter> CHARACTER_HAD { get; set; }


            /// <summary>
            /// 0x110 System.Collections.Generic.Dictionary<System.String , System.Single> FriendLoveNum
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Single></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("FriendLoveNum", "System.Collections.Generic.Dictionary<System.String,System.Single>")]
            public partial PMonoDictionary_BeastSaga<PMonoString, Single> FRIEND_LOVE_NUM { get; set; }


            /// <summary>
            /// 0x118 System.String _MapName
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_MapName", "System.String")]
           public partial nint _MAP_NAME { get; set; } 
*/

            /// <summary>
            /// 0x120 System.String _EnterInRoom
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_EnterInRoom", "System.String")]
           public partial nint _ENTER_IN_ROOM { get; set; } 
*/

            /// <summary>
            /// 0x128 System.String _InRoom
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_InRoom", "System.String")]
           public partial nint _IN_ROOM { get; set; } 
*/

            /// <summary>
            /// 0x130 System.String _InRoomGoods
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_InRoomGoods", "System.String")]
           public partial nint _IN_ROOM_GOODS { get; set; } 
*/

            /// <summary>
            /// 0x138 System.String _InRoomObj
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_InRoomObj", "System.String")]
           public partial nint _IN_ROOM_OBJ { get; set; } 
*/

            /// <summary>
            /// 0x140 System.String _RoomOut
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_RoomOut", "System.String")]
           public partial nint _ROOM_OUT { get; set; } 
*/

            /// <summary>
            /// 0x148 System.Collections.Generic.List<System.String> _InRoomsLoadObjs
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_InRoomsLoadObjs", "System.Collections.Generic.List<System.String>")]
           public partial nint _IN_ROOMS_LOAD_OBJS { get; set; } 
*/

            /// <summary>
            /// 0x150 System.Int32 Lv
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Lv", "System.Int32")]
            public partial System.Int32 LV { get; set; }


            /// <summary>
            /// 0x154 System.Single Exp
            /// struct ["mscorlib"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Exp", "System.Single")]
            public partial System.Single EXP { get; set; }


            /// <summary>
            /// 0x158 System.Int32 AddProSpot
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("AddProSpot", "System.Int32")]
            public partial System.Int32 ADD_PRO_SPOT { get; set; }


            /// <summary>
            /// 0x15C System.Int32 UseProSpot
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("UseProSpot", "System.Int32")]
            public partial System.Int32 USE_PRO_SPOT { get; set; }


            /// <summary>
            /// 0x160 System.Int32 AddLifeSpot
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("AddLifeSpot", "System.Int32")]
            public partial System.Int32 ADD_LIFE_SPOT { get; set; }


            /// <summary>
            /// 0x164 System.Int32 UseLifeSpot
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("UseLifeSpot", "System.Int32")]
            public partial System.Int32 USE_LIFE_SPOT { get; set; }


            /// <summary>
            /// 0x168 System.Single _BaseHp
            /// struct ["mscorlib"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_BaseHp", "System.Single")]
            public partial System.Single _BASE_HP { get; set; }


            /// <summary>
            /// 0x16C System.Single _Hp
            /// struct ["mscorlib"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_Hp", "System.Single")]
            public partial System.Single _HP { get; set; }


            /// <summary>
            /// 0x170 System.Single _MaxHp
            /// struct ["mscorlib"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_MaxHp", "System.Single")]
            public partial System.Single _MAX_HP { get; set; }


            /// <summary>
            /// 0x174 System.Single Power
            /// struct ["mscorlib"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Power", "System.Single")]
            public partial System.Single POWER { get; set; }


            /// <summary>
            /// 0x178 System.Single Perception
            /// struct ["mscorlib"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Perception", "System.Single")]
            public partial System.Single PERCEPTION { get; set; }


            /// <summary>
            /// 0x17C System.Single Agility
            /// struct ["mscorlib"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Agility", "System.Single")]
            public partial System.Single AGILITY { get; set; }


            /// <summary>
            /// 0x180 System.Single PhysicalPower
            /// struct ["mscorlib"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("PhysicalPower", "System.Single")]
            public partial System.Single PHYSICAL_POWER { get; set; }


            /// <summary>
            /// 0x184 System.Single Channel
            /// struct ["mscorlib"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Channel", "System.Single")]
            public partial System.Single CHANNEL { get; set; }


            /// <summary>
            /// 0x188 System.Single BerathSkill
            /// struct ["mscorlib"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("BerathSkill", "System.Single")]
            public partial System.Single BERATH_SKILL { get; set; }


            /// <summary>
            /// 0x18C System.Single WuXing
            /// struct ["mscorlib"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("WuXing", "System.Single")]
            public partial System.Single WU_XING { get; set; }


            /// <summary>
            /// 0x190 System.Single Speed
            /// struct ["mscorlib"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Speed", "System.Single")]
            public partial System.Single SPEED { get; set; }


            /// <summary>
            /// 0x194 System.Single Talent
            /// struct ["mscorlib"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Talent", "System.Single")]
            public partial System.Single TALENT { get; set; }


            /// <summary>
            /// 0x198 System.Int32 TalentAdd
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("TalentAdd", "System.Int32")]
            public partial System.Int32 TALENT_ADD { get; set; }


            /// <summary>
            /// 0x19C System.Int32 UseTalent
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("UseTalent", "System.Int32")]
            public partial System.Int32 USE_TALENT { get; set; }


            /// <summary>
            /// 0x1A0 System.Int32 FoodItemLimit
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("FoodItemLimit", "System.Int32")]
            public partial System.Int32 FOOD_ITEM_LIMIT { get; set; }


            /// <summary>
            /// 0x1A4 UnityEngine.Vector3 _Position
            /// struct ["UnityEngine.CoreModule"."UnityEngine"."Vector3"]
            /// </summary>
            /// <returns>struct UnityEngine.Vector3</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_Position", "UnityEngine.Vector3")]
           public partial UnityEngine.Vector3 _POSITION { get; set; } 
*/

            /// <summary>
            /// 0x1B0 System.Int32 _InLayer
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_InLayer", "System.Int32")]
           public partial System.Int32 _IN_LAYER { get; set; } 
*/

            /// <summary>
            /// 0x1B4 System.Int32 _BattleSpeed
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_BattleSpeed", "System.Int32")]
            public partial System.Int32 _BATTLE_SPEED { get; set; }


            /// <summary>
            /// 0x1B8 DifficultyType _DifficultyType
            /// enum ["Model.Runtime".""."DifficultyType"]
            /// </summary>
            /// <returns>enum DifficultyType</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_DifficultyType", "DifficultyType")]
           public partial DifficultyType _DIFFICULTY_TYPE { get; set; } 
*/

            /// <summary>
            /// 0x1BC System.Boolean _CanGoToOtherMap
            /// struct ["mscorlib"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_CanGoToOtherMap", "System.Boolean")]
           public partial System.Boolean _CAN_GO_TO_OTHER_MAP { get; set; } 
*/

            /// <summary>
            /// 0x1C0 System.Single _TiLiNum
            /// struct ["mscorlib"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_TiLiNum", "System.Single")]
            //public partial System.Single _TI_LI_NUM { get; set; }


            /// <summary>
            /// 0x1C4 System.Boolean _TiLiCan
            /// struct ["mscorlib"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_TiLiCan", "System.Boolean")]
            //public partial System.Boolean _TI_LI_CAN { get; set; }

        }

        /// <summary>
        /// class ["Model.Runtime".""."PlayerData"]
        /// </summary>
        partial struct Ptr_PlayerData
        {
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            public partial void CTOR(); 
*/
            /// <summary>
            ///   System.Void CheckData()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CheckData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            public partial void CHECK_DATA(); 
*/
            /// <summary>
            ///   System.Void DefaultData(System.Boolean isCreate)
            /// </summary>
            /// <param name = "isCreate">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DefaultData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void DEFAULT_DATA(System.Boolean isCreate); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<MakeType , System.Collections.Generic.List<MakeDataSet>> GetMakeData()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<MakeType , System.Collections.Generic.List<MakeDataSet>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMakeData", "System.Collections.Generic.Dictionary<MakeType,System.Collections.Generic.List<MakeDataSet>>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            public partial nint GET_MAKE_DATA(); 
*/
            /// <summary>
            ///   System.Single GetPro(PlayerProType proType, System.Collections.Generic.Dictionary<SkillDataSet , System.Single> equipsSkill)
            /// </summary>
            /// <param name = "proType">enum PlayerProType</param>
            /// <param name = "equipsSkill">class System.Collections.Generic.Dictionary<SkillDataSet , System.Single></param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPro", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("PlayerProType", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.Dictionary<SkillDataSet,System.Single>", 1)]
            public partial System.Single GET_PRO(PlayerProType proType, nint equipsSkill); 
*/
            /// <summary>
            ///   System.Single ItemUpdateAddHp(System.Single addHp)
            /// </summary>
            /// <param name = "addHp">struct System.Single</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ItemUpdateAddHp", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public partial System.Single ITEM_UPDATE_ADD_HP(System.Single addHp); 
*/
            /// <summary>
            ///   System.Boolean StudentMake(MakeDataSet makeData)
            /// </summary>
            /// <param name = "makeData">class MakeDataSet</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("StudentMake", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("MakeDataSet", 0)]
            public partial System.Boolean STUDENT_MAKE(nint makeData); 
*/
            /// <summary>
            ///   System.Void UpDataHp(System.Collections.Generic.Dictionary<SkillDataSet , System.Single> resultSkill)
            /// </summary>
            /// <param name = "resultSkill">class System.Collections.Generic.Dictionary<SkillDataSet , System.Single></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpDataHp", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.Dictionary<SkillDataSet,System.Single>", 0)]
            public partial void UP_DATA_HP(nint resultSkill); 
*/
            /// <summary>
            ///   System.Void UpdateCurrenHp(System.Single hp)
            /// </summary>
            /// <param name = "hp">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateCurrenHp", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public partial void UPDATE_CURREN_HP(System.Single hp); 
*/
        }
    }
}