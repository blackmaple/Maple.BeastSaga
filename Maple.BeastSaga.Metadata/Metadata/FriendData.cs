using Maple.BeastSaga.Metadata.Metadata;
using Maple.MonoGameAssistant.Core;

namespace Maple.BeastSaga.Metadata
{
    /// <summary>
    /// class ["Model.Runtime".""."FriendData"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_FriendData>, Ptr_FriendData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Model.Runtime", "", "FriendData", "FriendData")]
    public partial class FriendData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_FriendData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_FriendData(System.IntPtr ptr) => new Ptr_FriendData(ptr);
            public static implicit operator System.IntPtr(Ptr_FriendData ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_FriendData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Model.Runtime".""."FriendData"]
        /// </summary>
        partial struct Ptr_FriendData
        {
            /// <summary>
            /// 0x10 System.String _AbName
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_AbName", "System.String")]
            public partial PMonoString _AB_NAME { get; set; }


            /// <summary>
            /// 0x18 System.String _Name
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_Name", "System.String")]
           public partial nint _NAME { get; set; } 
*/

            /// <summary>
            /// 0x20 UnityEngine.Sprite _Head
            /// class ["UnityEngine.CoreModule"."UnityEngine"."Sprite"]
            /// </summary>
            /// <returns>class UnityEngine.Sprite</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_Head", "UnityEngine.Sprite")]
           public partial nint _HEAD { get; set; } 
*/

            /// <summary>
            /// 0x28 UnityEngine.Sprite _BigHead
            /// class ["UnityEngine.CoreModule"."UnityEngine"."Sprite"]
            /// </summary>
            /// <returns>class UnityEngine.Sprite</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_BigHead", "UnityEngine.Sprite")]
           public partial nint _BIG_HEAD { get; set; } 
*/

            /// <summary>
            /// 0x30 Spine.Unity.SkeletonDataAsset _Spine
            /// class ["spine-unity"."Spine.Unity"."SkeletonDataAsset"]
            /// </summary>
            /// <returns>class Spine.Unity.SkeletonDataAsset</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_Spine", "Spine.Unity.SkeletonDataAsset")]
           public partial nint _SPINE { get; set; } 
*/

            /// <summary>
            /// 0x38 System.String _Skin
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_Skin", "System.String")]
           public partial nint _SKIN { get; set; } 
*/

            /// <summary>
            /// 0x40 System.Collections.Generic.Dictionary<PlayerProType , System.Int32> SixProCurrent
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<PlayerProType , System.Int32></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("SixProCurrent", "System.Collections.Generic.Dictionary<PlayerProType,System.Int32>")]
           public partial nint SIX_PRO_CURRENT { get; set; } 
*/

            /// <summary>
            /// 0x48 System.Collections.Generic.Dictionary<System.Int32 , PlayerItemData> _DressItem
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Int32 , PlayerItemData></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_DressItem", "System.Collections.Generic.Dictionary<System.Int32,PlayerItemData>")]
           public partial nint _DRESS_ITEM { get; set; } 
*/

            /// <summary>
            /// 0x50 System.Collections.Generic.Dictionary<System.Int32 , PlayerItemData> _LeaveDressItem
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Int32 , PlayerItemData></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_LeaveDressItem", "System.Collections.Generic.Dictionary<System.Int32,PlayerItemData>")]
           public partial nint _LEAVE_DRESS_ITEM { get; set; } 
*/

            /// <summary>
            /// 0x58 System.Collections.Generic.Dictionary<WeaponEquipUIIndex , PlayerEquipData> _PlayerDressEquip
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<WeaponEquipUIIndex , PlayerEquipData></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_PlayerDressEquip", "System.Collections.Generic.Dictionary<WeaponEquipUIIndex,PlayerEquipData>")]
           public partial nint _PLAYER_DRESS_EQUIP { get; set; } 
*/

            /// <summary>
            /// 0x60 System.Collections.Generic.Dictionary<WeaponEquipUIIndex , PlayerEquipData> _LeavePlayerDressEquip
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<WeaponEquipUIIndex , PlayerEquipData></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_LeavePlayerDressEquip", "System.Collections.Generic.Dictionary<WeaponEquipUIIndex,PlayerEquipData>")]
           public partial nint _LEAVE_PLAYER_DRESS_EQUIP { get; set; } 
*/

            /// <summary>
            /// 0x68 PlayerInKangFu _DressInKangFu
            /// class ["Model.Runtime".""."PlayerInKangFu"]
            /// </summary>
            /// <returns>class PlayerInKangFu</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_DressInKangFu", "PlayerInKangFu")]
            public partial PlayerInKangFu.Ptr_PlayerInKangFu _DRESS_IN_KANG_FU { get; set; }


            /// <summary>
            /// 0x70 System.String _DressInKangFuName
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_DressInKangFuName", "System.String")]
           public partial nint _DRESS_IN_KANG_FU_NAME { get; set; } 
*/

            /// <summary>
            /// 0x78 System.Collections.Generic.Dictionary<System.String , PlayerInKangFu> _InKangFuHad
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , PlayerInKangFu></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_InKangFuHad", "System.Collections.Generic.Dictionary<System.String,PlayerInKangFu>")]
            public partial PMonoDictionary_BeastSaga<PMonoString, PlayerInKangFu.Ptr_PlayerInKangFu> _IN_KANG_FU_HAD { get; set; }


            /// <summary>
            /// 0x80 System.Collections.Generic.Dictionary<System.String , PlayerKangFu> _KangFuHad
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , PlayerKangFu></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_KangFuHad", "System.Collections.Generic.Dictionary<System.String,PlayerKangFu>")]
            public partial PMonoDictionary_BeastSaga<PMonoString, PlayerKangFu.Ptr_PlayerKangFu> _KANG_FU_HAD { get; set; }


            /// <summary>
            /// 0x88 System.Collections.Generic.Dictionary<System.String , PlayerKangFu> _DressKangFu
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , PlayerKangFu></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_DressKangFu", "System.Collections.Generic.Dictionary<System.String,PlayerKangFu>")]
            public partial PMonoDictionary_BeastSaga<PMonoString, PlayerKangFu.Ptr_PlayerKangFu> _DRESS_KANG_FU { get; set; }


            /// <summary>
            /// 0x90 System.Collections.Generic.Dictionary<System.Int32 , System.String> _DressQuickKangFu
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Int32 , System.String></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_DressQuickKangFu", "System.Collections.Generic.Dictionary<System.Int32,System.String>")]
           public partial nint _DRESS_QUICK_KANG_FU { get; set; } 
*/

            /// <summary>
            /// 0x98 System.Collections.Generic.Dictionary<System.String , PlayerKangFuSkill> _KangFuSkillHad
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , PlayerKangFuSkill></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_KangFuSkillHad", "System.Collections.Generic.Dictionary<System.String,PlayerKangFuSkill>")]
            public partial PMonoDictionary_BeastSaga<PMonoString, PlayerKangFuSkill.Ptr_PlayerKangFuSkill> _KANG_FU_SKILL_HAD { get; set; }


            /// <summary>
            /// 0xA0 System.Collections.Generic.Dictionary<System.String , PlayerKangFuSkill> _KangFuQingHad
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , PlayerKangFuSkill></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_KangFuQingHad", "System.Collections.Generic.Dictionary<System.String,PlayerKangFuSkill>")]
            public partial PMonoDictionary_BeastSaga<PMonoString, PlayerKangFuSkill.Ptr_PlayerKangFuSkill> _KANG_FU_QING_HAD { get; set; }


            /// <summary>
            /// 0xA8 System.Collections.Generic.Dictionary<System.String , PlayerKangFuSkill> _DressBigLoop
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , PlayerKangFuSkill></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_DressBigLoop", "System.Collections.Generic.Dictionary<System.String,PlayerKangFuSkill>")]
            public partial PMonoDictionary_BeastSaga<PMonoString, PlayerKangFuSkill.Ptr_PlayerKangFuSkill> _DRESS_BIG_LOOP { get; set; }


            /// <summary>
            /// 0xB0 System.Collections.Generic.Dictionary<System.String , PlayerKangFuSkill> _DressSmallLoop
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , PlayerKangFuSkill></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_DressSmallLoop", "System.Collections.Generic.Dictionary<System.String,PlayerKangFuSkill>")]
            public partial PMonoDictionary_BeastSaga<PMonoString, PlayerKangFuSkill.Ptr_PlayerKangFuSkill> _DRESS_SMALL_LOOP { get; set; }


            /// <summary>
            /// 0xB8 System.Collections.Generic.Dictionary<KFType , System.Int32> _KongFuTypeLv
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<KFType , System.Int32></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_KongFuTypeLv", "System.Collections.Generic.Dictionary<KFType,System.Int32>")]
            public partial PMonoDictionary_BeastSaga<KFType, int> _KONG_FU_TYPE_LV { get; set; }


            /// <summary>
            /// 0xC0 System.Collections.Generic.Dictionary<System.String , FoodItemData> FoodItem
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , FoodItemData></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("FoodItem", "System.Collections.Generic.Dictionary<System.String,FoodItemData>")]
           public partial nint FOOD_ITEM { get; set; } 
*/

            /// <summary>
            /// 0xC8 System.Collections.Generic.Dictionary<System.String , PlayerCharacter> CharacterHad
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , PlayerCharacter></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("CharacterHad", "System.Collections.Generic.Dictionary<System.String,PlayerCharacter>")]
            public partial PMonoDictionary_BeastSaga<PMonoString, PlayerCharacter.Ptr_PlayerCharacter> CHARACTER_HAD { get; set; }


            /// <summary>
            /// 0xD0 System.Collections.Generic.List<KFSchool> AddSchool
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<KFSchool></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("AddSchool", "System.Collections.Generic.List<KFSchool>")]
            public partial PMonoList_D<KFSchool> ADD_SCHOOL { get; set; }


            /// <summary>
            /// 0xD8 System.Collections.Generic.List<KFType> EquipTypeCan
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<KFType></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("EquipTypeCan", "System.Collections.Generic.List<KFType>")]
            public partial PMonoList_D<KFType> EQUIP_TYPE_CAN { get; set; }


            /// <summary>
            /// 0xE0 PlayerChong DressChong
            /// class ["Model.Runtime".""."PlayerChong"]
            /// </summary>
            /// <returns>class PlayerChong</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("DressChong", "PlayerChong")]
           public partial nint DRESS_CHONG { get; set; } 
*/

            /// <summary>
            /// 0xE8 System.Int32 _Lv
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_Lv", "System.Int32")]
            public partial System.Int32 _LV { get; set; }


            /// <summary>
            /// 0xEC System.Int32 _AddProSpot
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_AddProSpot", "System.Int32")]
            public partial System.Int32 _ADD_PRO_SPOT { get; set; }


            /// <summary>
            /// 0xF0 System.Int32 _UseProSpot
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_UseProSpot", "System.Int32")]
            public partial System.Int32 _USE_PRO_SPOT { get; set; }


            /// <summary>
            /// 0xF4 System.Single _BaseHp
            /// struct ["mscorlib"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_BaseHp", "System.Single")]
            public partial System.Single _BASE_HP { get; set; }


            /// <summary>
            /// 0xF8 System.Single _Hp
            /// struct ["mscorlib"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_Hp", "System.Single")]
            public partial System.Single _HP { get; set; }


            /// <summary>
            /// 0xFC System.Single _MaxHp
            /// struct ["mscorlib"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_MaxHp", "System.Single")]
            public partial System.Single _MAX_HP { get; set; }


            /// <summary>
            /// 0x100 System.Single _Power
            /// struct ["mscorlib"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_Power", "System.Single")]
            public partial System.Single _POWER { get; set; }


            /// <summary>
            /// 0x104 System.Single _Perception
            /// struct ["mscorlib"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_Perception", "System.Single")]
            public partial System.Single _PERCEPTION { get; set; }


            /// <summary>
            /// 0x108 System.Single _Agility
            /// struct ["mscorlib"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_Agility", "System.Single")]
            public partial System.Single _AGILITY { get; set; }


            /// <summary>
            /// 0x10C System.Single _PhysicalPower
            /// struct ["mscorlib"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_PhysicalPower", "System.Single")]
            public partial System.Single _PHYSICAL_POWER { get; set; }


            /// <summary>
            /// 0x110 System.Single _Channel
            /// struct ["mscorlib"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_Channel", "System.Single")]
            public partial System.Single _CHANNEL { get; set; }


            /// <summary>
            /// 0x114 System.Single _BerathSkill
            /// struct ["mscorlib"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_BerathSkill", "System.Single")]
            public partial System.Single _BERATH_SKILL { get; set; }


            /// <summary>
            /// 0x118 System.Single _Speed
            /// struct ["mscorlib"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_Speed", "System.Single")]
            public partial System.Single _SPEED { get; set; }


            /// <summary>
            /// 0x11C System.Int32 _TalentAdd
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_TalentAdd", "System.Int32")]
            public partial System.Int32 _TALENT_ADD { get; set; }


            /// <summary>
            /// 0x120 System.Int32 _WuXing
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_WuXing", "System.Int32")]
            public partial System.Int32 _WU_XING { get; set; }


            /// <summary>
            /// 0x124 System.Int32 FoodItemLimit
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("FoodItemLimit", "System.Int32")]
           public partial System.Int32 FOOD_ITEM_LIMIT { get; set; } 
*/

            /// <summary>
            /// 0x128 System.Int32 _MinLvOriginal
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_MinLvOriginal", "System.Int32")]
           public partial System.Int32 _MIN_LV_ORIGINAL { get; set; } 
*/

            /// <summary>
            /// 0x12C System.Int32 _MaxLvOriginal
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_MaxLvOriginal", "System.Int32")]
           public partial System.Int32 _MAX_LV_ORIGINAL { get; set; } 
*/

            /// <summary>
            /// 0x130 System.Single _PowerOriginal
            /// struct ["mscorlib"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_PowerOriginal", "System.Single")]
           public partial System.Single _POWER_ORIGINAL { get; set; } 
*/

            /// <summary>
            /// 0x134 System.Single _PerceptionOriginal
            /// struct ["mscorlib"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_PerceptionOriginal", "System.Single")]
           public partial System.Single _PERCEPTION_ORIGINAL { get; set; } 
*/

            /// <summary>
            /// 0x138 System.Single _AgilityOriginal
            /// struct ["mscorlib"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_AgilityOriginal", "System.Single")]
           public partial System.Single _AGILITY_ORIGINAL { get; set; } 
*/

            /// <summary>
            /// 0x13C System.Single _PhysicalPowerOriginal
            /// struct ["mscorlib"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_PhysicalPowerOriginal", "System.Single")]
           public partial System.Single _PHYSICAL_POWER_ORIGINAL { get; set; } 
*/

            /// <summary>
            /// 0x140 System.Single _ChannelOriginal
            /// struct ["mscorlib"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_ChannelOriginal", "System.Single")]
           public partial System.Single _CHANNEL_ORIGINAL { get; set; } 
*/

            /// <summary>
            /// 0x144 System.Single _BerathSkillOriginal
            /// struct ["mscorlib"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_BerathSkillOriginal", "System.Single")]
           public partial System.Single _BERATH_SKILL_ORIGINAL { get; set; } 
*/

            /// <summary>
            /// 0x148 System.Int32 _TalentAddOriginal
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_TalentAddOriginal", "System.Int32")]
           public partial System.Int32 _TALENT_ADD_ORIGINAL { get; set; } 
*/

            /// <summary>
            /// 0x14C System.Int32 _UseTalent
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_UseTalent", "System.Int32")]
            public partial System.Int32 _USE_TALENT { get; set; }

        }

        /// <summary>
        /// class ["Model.Runtime".""."FriendData"]
        /// </summary>
        partial struct Ptr_FriendData
        {
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void CTOR(); 
*/
            /// <summary>
            ///   System.Void <CheckData>b__59_0(UnityEngine.GameObject friend)
            /// </summary>
            /// <param name = "friend">class UnityEngine.GameObject</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("<CheckData>b__59_0", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GameObject", 0)]
           public partial void CHECK_DATAB__59_0(nint friend); 
*/
            /// <summary>
            ///   System.Boolean AddKongFuTypeExp(KFType kFType, System.Int32 addExp)
            /// </summary>
            /// <param name = "kFType">enum KFType</param>
            /// <param name = "addExp">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddKongFuTypeExp", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("KFType", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial System.Boolean ADD_KONG_FU_TYPE_EXP(KFType kFType, System.Int32 addExp);

            /// <summary>
            ///   System.Void AddProPoint(System.Int32 addPower, System.Int32 addPerception, System.Int32 addAgility, System.Int32 addPhysicalPower, System.Int32 addChanel, System.Int32 addBerathSkill)
            /// </summary>
            /// <param name = "addPower">struct System.Int32</param>
            /// <param name = "addPerception">struct System.Int32</param>
            /// <param name = "addAgility">struct System.Int32</param>
            /// <param name = "addPhysicalPower">struct System.Int32</param>
            /// <param name = "addChanel">struct System.Int32</param>
            /// <param name = "addBerathSkill">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddProPoint", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           public partial void ADD_PRO_POINT(System.Int32 addPower, System.Int32 addPerception, System.Int32 addAgility, System.Int32 addPhysicalPower, System.Int32 addChanel, System.Int32 addBerathSkill); 
*/
            /// <summary>
            ///   System.Boolean AddShopKongFuType(KFType kFType)
            /// </summary>
            /// <param name = "kFType">enum KFType</param>
            /// <returns>struct System.Boolean</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddShopKongFuType", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("KFType", 0)]
            public partial System.Boolean ADD_SHOP_KONG_FU_TYPE(KFType kFType);

            /// <summary>
            ///   System.Boolean AwardInKongFu(InKangFuDataSet InKangFu)
            /// </summary>
            /// <param name = "InKangFu">class InKangFuDataSet</param>
            /// <returns>struct System.Boolean</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AwardInKongFu", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("InKangFuDataSet", 0)]
            public partial System.Boolean AWARD_IN_KONG_FU(InKangFuDataSet.Ptr_InKangFuDataSet InKangFu);

            /// <summary>
            ///   System.Boolean AwardKangFuQing(UniqueSkillDataSet KangFuQing)
            /// </summary>
            /// <param name = "KangFuQing">class UniqueSkillDataSet</param>
            /// <returns>struct System.Boolean</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AwardKangFuQing", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UniqueSkillDataSet", 0)]
            public partial System.Boolean AWARD_KANG_FU_QING(UniqueSkillDataSet.Ptr_UniqueSkillDataSet KangFuQing);

            /// <summary>
            ///   System.Boolean AwardKongFu(KangFuDataSet KangFu)
            /// </summary>
            /// <param name = "KangFu">class KangFuDataSet</param>
            /// <returns>struct System.Boolean</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AwardKongFu", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("KangFuDataSet", 0)]
            public partial System.Boolean AWARD_KONG_FU(KangFuDataSet.Ptr_KangFuDataSet KangFu);

            /// <summary>
            ///   System.Boolean AwardKongFuSkill(UniqueSkillDataSet KangFuSkill)
            /// </summary>
            /// <param name = "KangFuSkill">class UniqueSkillDataSet</param>
            /// <returns>struct System.Boolean</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AwardKongFuSkill", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UniqueSkillDataSet", 0)]
            public partial System.Boolean AWARD_KONG_FU_SKILL(UniqueSkillDataSet.Ptr_UniqueSkillDataSet KangFuSkill);

            /// <summary>
            ///   System.Boolean AwardShanHaiLu(ShanHaiLuDataSet shanhailu)
            /// </summary>
            /// <param name = "shanhailu">class ShanHaiLuDataSet</param>
            /// <returns>struct System.Boolean</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AwardShanHaiLu", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ShanHaiLuDataSet", 0)]
            public partial System.Boolean AWARD_SHAN_HAI_LU(ShanHaiLuDataSet.Ptr_ShanHaiLuDataSet shanhailu);

            /// <summary>
            ///   System.Single BaojiBeiLv()
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("BaojiBeiLv", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Single BAOJI_BEI_LV(); 
*/
            /// <summary>
            ///   System.Boolean BuyTeXing(CharacterDataSet data)
            /// </summary>
            /// <param name = "data">class CharacterDataSet</param>
            /// <returns>struct System.Boolean</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("BuyTeXing", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("CharacterDataSet", 0)]
            public partial System.Boolean BUY_TE_XING(CharacterDataSet.Ptr_CharacterDataSet data);

            /// <summary>
            ///   System.Single ChaiZhao()
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChaiZhao", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Single CHAI_ZHAO(); 
*/
            /// <summary>
            ///   System.Boolean ChangeInKangFu(System.String inKangFuName)
            /// </summary>
            /// <param name = "inKangFuName">class System.String</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeInKangFu", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
           public partial System.Boolean CHANGE_IN_KANG_FU(nint inKangFuName); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<CharacterDataSet> CharacterDataList()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<CharacterDataSet></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CharacterDataList", "System.Collections.Generic.List<CharacterDataSet>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint CHARACTER_DATA_LIST(); 
*/
            /// <summary>
            ///   System.Void CheckData(System.Boolean isAdd)
            /// </summary>
            /// <param name = "isAdd">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CheckData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
           public partial void CHECK_DATA(System.Boolean isAdd); 
*/
            /// <summary>
            ///   System.Void DeBufHuiFuSkill(System.Single& result, System.String skillName)
            /// </summary>
            /// <param name = "result">struct System.Single&</param>
            /// <param name = "skillName">class System.String</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DeBufHuiFuSkill", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single&", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
           public partial void DE_BUF_HUI_FU_SKILL(System.Single &result, nint skillName); 
*/
            /// <summary>
            ///   System.Boolean DressEquip(WeaponEquipUIIndex uiType, PlayerEquipData playerEquip)
            /// </summary>
            /// <param name = "uiType">enum WeaponEquipUIIndex</param>
            /// <param name = "playerEquip">class PlayerEquipData</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DressEquip", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("WeaponEquipUIIndex", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("PlayerEquipData", 1)]
           public partial System.Boolean DRESS_EQUIP(WeaponEquipUIIndex uiType, nint playerEquip); 
*/
            /// <summary>
            ///   System.Boolean DressItem(PlayerItemData playerItemData, System.Int32 dressNum)
            /// </summary>
            /// <param name = "playerItemData">class PlayerItemData</param>
            /// <param name = "dressNum">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DressItem", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("PlayerItemData", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           public partial System.Boolean DRESS_ITEM(nint playerItemData, System.Int32 dressNum); 
*/
            /// <summary>
            ///   System.Boolean DressKangFu(System.String kangfuName)
            /// </summary>
            /// <param name = "kangfuName">class System.String</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DressKangFu", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
           public partial System.Boolean DRESS_KANG_FU(nint kangfuName); 
*/
            /// <summary>
            ///   System.Boolean DressKangFuQing(System.String kfqing)
            /// </summary>
            /// <param name = "kfqing">class System.String</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DressKangFuQing", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
           public partial System.Boolean DRESS_KANG_FU_QING(nint kfqing); 
*/
            /// <summary>
            ///   System.Boolean DressKangFuSkill(System.String kangfuSkillName)
            /// </summary>
            /// <param name = "kangfuSkillName">class System.String</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DressKangFuSkill", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
           public partial System.Boolean DRESS_KANG_FU_SKILL(nint kangfuSkillName); 
*/
            /// <summary>
            ///   System.Void DressSkillKangFuSlot(System.Single& kangfuSloat, System.Single& bigSloat, System.Single& smallSloat)
            /// </summary>
            /// <param name = "kangfuSloat">struct System.Single&</param>
            /// <param name = "bigSloat">struct System.Single&</param>
            /// <param name = "smallSloat">struct System.Single&</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DressSkillKangFuSlot", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single&", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single&", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single&", 2)]
           public partial void DRESS_SKILL_KANG_FU_SLOT(System.Single &kangfuSloat, System.Single &bigSloat, System.Single &smallSloat); 
*/
            /// <summary>
            ///   System.Boolean DropBigLoop(System.String kangfuSkillName)
            /// </summary>
            /// <param name = "kangfuSkillName">class System.String</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DropBigLoop", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
           public partial System.Boolean DROP_BIG_LOOP(nint kangfuSkillName); 
*/
            /// <summary>
            ///   System.Boolean DropEquip(WeaponEquipUIIndex uiType)
            /// </summary>
            /// <param name = "uiType">enum WeaponEquipUIIndex</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DropEquip", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("WeaponEquipUIIndex", 0)]
           public partial System.Boolean DROP_EQUIP(WeaponEquipUIIndex uiType); 
*/
            /// <summary>
            ///   System.Boolean DropEquip(PlayerEquipData playerEquipData)
            /// </summary>
            /// <param name = "playerEquipData">class PlayerEquipData</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DropEquip", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("PlayerEquipData", 0)]
           public partial System.Boolean DROP_EQUIP(nint playerEquipData); 
*/
            /// <summary>
            ///   System.Boolean DropItem(PlayerItemData itemInfo, System.Int32 dropNum)
            /// </summary>
            /// <param name = "itemInfo">class PlayerItemData</param>
            /// <param name = "dropNum">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DropItem", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("PlayerItemData", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           public partial System.Boolean DROP_ITEM(nint itemInfo, System.Int32 dropNum); 
*/
            /// <summary>
            ///   System.Boolean DropKangfu(System.String kangfuName)
            /// </summary>
            /// <param name = "kangfuName">class System.String</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DropKangfu", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
           public partial System.Boolean DROP_KANGFU(nint kangfuName); 
*/
            /// <summary>
            ///   System.Boolean DropSmallLoop(System.String kfqing)
            /// </summary>
            /// <param name = "kfqing">class System.String</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DropSmallLoop", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
           public partial System.Boolean DROP_SMALL_LOOP(nint kfqing); 
*/
            /// <summary>
            ///   System.Boolean ExchangeDressKangFu(System.Int32 index1, System.Int32 index2)
            /// </summary>
            /// <param name = "index1">struct System.Int32</param>
            /// <param name = "index2">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ExchangeDressKangFu", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           public partial System.Boolean EXCHANGE_DRESS_KANG_FU(System.Int32 index1, System.Int32 index2); 
*/
            /// <summary>
            ///   System.Boolean ExchangeItem(System.Int32 index1, System.Int32 index2)
            /// </summary>
            /// <param name = "index1">struct System.Int32</param>
            /// <param name = "index2">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ExchangeItem", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           public partial System.Boolean EXCHANGE_ITEM(System.Int32 index1, System.Int32 index2); 
*/
            /// <summary>
            ///   System.Void GasArmorChange(System.Single& _Armor, System.Single& _Gas)
            /// </summary>
            /// <param name = "_Armor">struct System.Single&</param>
            /// <param name = "_Gas">struct System.Single&</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GasArmorChange", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single&", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single&", 1)]
           public partial void GAS_ARMOR_CHANGE(System.Single &_Armor, System.Single &_Gas); 
*/
            /// <summary>
            ///   System.Int32 GetAllProSpot()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAllProSpot", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Int32 GET_ALL_PRO_SPOT(); 
*/
            /// <summary>
            ///   System.Single GetEquipSkillBySkillName(System.String skillName)
            /// </summary>
            /// <param name = "skillName">class System.String</param>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetEquipSkillBySkillName", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
           public partial System.Single GET_EQUIP_SKILL_BY_SKILL_NAME(nint skillName); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<SkillDataSet , System.Single> GetEquipSkills()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<SkillDataSet , System.Single></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetEquipSkills", "System.Collections.Generic.Dictionary<SkillDataSet,System.Single>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint GET_EQUIP_SKILLS(); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<System.String , System.Single> GetEquipSkillsLayer()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Single></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetEquipSkillsLayer", "System.Collections.Generic.Dictionary<System.String,System.Single>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint GET_EQUIP_SKILLS_LAYER(); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<KFType , System.Int32> GetFongFuTypeLvInfo()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<KFType , System.Int32></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetFongFuTypeLvInfo", "System.Collections.Generic.Dictionary<KFType,System.Int32>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint GET_FONG_FU_TYPE_LV_INFO(); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<System.String , FoodItemData> GetFoodItemData()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , FoodItemData></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetFoodItemData", "System.Collections.Generic.Dictionary<System.String,FoodItemData>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint GET_FOOD_ITEM_DATA(); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<CharacterDataSet , System.Int32> GetHaveCharacter()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<CharacterDataSet , System.Int32></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetHaveCharacter", "System.Collections.Generic.Dictionary<CharacterDataSet,System.Int32>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint GET_HAVE_CHARACTER(); 
*/
            /// <summary>
            ///   System.Single GetKangFuAttack(PlayerKangFu _CurrentPlayerKangFu)
            /// </summary>
            /// <param name = "_CurrentPlayerKangFu">class PlayerKangFu</param>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetKangFuAttack", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("PlayerKangFu", 0)]
           public partial System.Single GET_KANG_FU_ATTACK(nint _CurrentPlayerKangFu); 
*/
            /// <summary>
            ///   System.Int32 GetKangFuTypeCurrent(KFType kFType)
            /// </summary>
            /// <param name = "kFType">enum KFType</param>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetKangFuTypeCurrent", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("KFType", 0)]
           public partial System.Int32 GET_KANG_FU_TYPE_CURRENT(KFType kFType); 
*/
            /// <summary>
            ///   System.Int32 GetKangFuTypeMax(KFType kFType)
            /// </summary>
            /// <param name = "kFType">enum KFType</param>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetKangFuTypeMax", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("KFType", 0)]
           public partial System.Int32 GET_KANG_FU_TYPE_MAX(KFType kFType); 
*/
            /// <summary>
            ///   System.Int32 GetKongFuTypeBaseLv(KFType kFType)
            /// </summary>
            /// <param name = "kFType">enum KFType</param>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetKongFuTypeBaseLv", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("KFType", 0)]
           public partial System.Int32 GET_KONG_FU_TYPE_BASE_LV(KFType kFType); 
*/
            /// <summary>
            ///   System.Int32 GetKongFuTypeLv(KFType kFType)
            /// </summary>
            /// <param name = "kFType">enum KFType</param>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetKongFuTypeLv", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("KFType", 0)]
            public partial System.Int32 GET_KONG_FU_TYPE_LV(KFType kFType);

            /// <summary>
            ///   System.Int32 GetPro(PlayerProType proType, System.Collections.Generic.Dictionary<SkillDataSet , System.Single> equipsSkill)
            /// </summary>
            /// <param name = "proType">enum PlayerProType</param>
            /// <param name = "equipsSkill">class System.Collections.Generic.Dictionary<SkillDataSet , System.Single></param>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPro", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("PlayerProType", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.Dictionary<SkillDataSet,System.Single>", 1)]
           public partial System.Int32 GET_PRO(PlayerProType proType, nint equipsSkill); 
*/
            /// <summary>
            ///   System.Int32 GetPro(PlayerProType proType)
            /// </summary>
            /// <param name = "proType">enum PlayerProType</param>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPro", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("PlayerProType", 0)]
           public partial System.Int32 GET_PRO(PlayerProType proType); 
*/
            /// <summary>
            ///   System.Single GetProAttack(PlayerKangFu _CurrentPlayerKangFu, System.Collections.Generic.Dictionary<SkillDataSet , System.Single> equipsSkills)
            /// </summary>
            /// <param name = "_CurrentPlayerKangFu">class PlayerKangFu</param>
            /// <param name = "equipsSkills">class System.Collections.Generic.Dictionary<SkillDataSet , System.Single></param>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetProAttack", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("PlayerKangFu", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.Dictionary<SkillDataSet,System.Single>", 1)]
           public partial System.Single GET_PRO_ATTACK(nint _CurrentPlayerKangFu, nint equipsSkills); 
*/
            /// <summary>
            ///   System.Int32 GetSkillAddPoint()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSkillAddPoint", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Int32 GET_SKILL_ADD_POINT(); 
*/
            /// <summary>
            ///   System.Int32 GetTeXingPoint()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTeXingPoint", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Int32 GET_TE_XING_POINT(); 
*/
            /// <summary>
            ///   System.Single HuiHeJianGe()
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("HuiHeJianGe", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Single HUI_HE_JIAN_GE(); 
*/
            /// <summary>
            ///   System.Single Huo()
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Huo", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Single HUO(); 
*/
            /// <summary>
            ///   System.Void InitData(FriendDefaultData defaultData, System.String abName)
            /// </summary>
            /// <param name = "defaultData">class FriendDefaultData</param>
            /// <param name = "abName">class System.String</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InitData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("FriendDefaultData", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
           public partial void INIT_DATA(nint defaultData, nint abName); 
*/
            /// <summary>
            ///   System.Void InitKongFuTypeBaseLv(KFType kFType, System.Int32 lv)
            /// </summary>
            /// <param name = "kFType">enum KFType</param>
            /// <param name = "lv">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InitKongFuTypeBaseLv", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("KFType", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           public partial void INIT_KONG_FU_TYPE_BASE_LV(KFType kFType, System.Int32 lv); 
*/
            /// <summary>
            ///   System.Boolean InKangFuPD(System.String& message, System.Collections.Generic.List<InKangFuDataSet> preconditionOne)
            /// </summary>
            /// <param name = "message">class System.String&</param>
            /// <param name = "preconditionOne">class System.Collections.Generic.List<InKangFuDataSet></param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InKangFuPD", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String&", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<InKangFuDataSet>", 1)]
           public partial System.Boolean IN_KANG_FU_PD(nint message, nint preconditionOne); 
*/
            /// <summary>
            ///   System.Void InKangFuSlotInfo(System.Int32& wuyiCurrent, System.Int32& wuyiCount, System.Int32& bigLoopCurrent, System.Int32& bigLoopCount, System.Int32& smallCurrent, System.Int32& smallCount)
            /// </summary>
            /// <param name = "wuyiCurrent">struct System.Int32&</param>
            /// <param name = "wuyiCount">struct System.Int32&</param>
            /// <param name = "bigLoopCurrent">struct System.Int32&</param>
            /// <param name = "bigLoopCount">struct System.Int32&</param>
            /// <param name = "smallCurrent">struct System.Int32&</param>
            /// <param name = "smallCount">struct System.Int32&</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InKangFuSlotInfo", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32&", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32&", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32&", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32&", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32&", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32&", 5)]
           public partial void IN_KANG_FU_SLOT_INFO(System.Int32 &wuyiCurrent, System.Int32 &wuyiCount, System.Int32 &bigLoopCurrent, System.Int32 &bigLoopCount, System.Int32 &smallCurrent, System.Int32 &smallCount); 
*/
            /// <summary>
            ///   System.Void InKangFuUpdateBigLoop()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InKangFuUpdateBigLoop", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void IN_KANG_FU_UPDATE_BIG_LOOP(); 
*/
            /// <summary>
            ///   System.Void InKangFuUpdateKangFu()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InKangFuUpdateKangFu", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void IN_KANG_FU_UPDATE_KANG_FU(); 
*/
            /// <summary>
            ///   System.Void InKangFuUpdateSmallLoop()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InKangFuUpdateSmallLoop", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void IN_KANG_FU_UPDATE_SMALL_LOOP(); 
*/
            /// <summary>
            ///   System.Boolean IsCanKangFuEquip(System.Collections.Generic.List<KFType> kFTypes, WeaponEquipUIIndex uiType, EquipDressName dressName)
            /// </summary>
            /// <param name = "kFTypes">class System.Collections.Generic.List<KFType></param>
            /// <param name = "uiType">enum WeaponEquipUIIndex</param>
            /// <param name = "dressName">enum EquipDressName</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsCanKangFuEquip", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<KFType>", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("WeaponEquipUIIndex", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("EquipDressName", 2)]
           public partial System.Boolean IS_CAN_KANG_FU_EQUIP(nint kFTypes, WeaponEquipUIIndex uiType, EquipDressName dressName); 
*/
            /// <summary>
            ///   System.Boolean IsCanKangFuStudent(KFType type)
            /// </summary>
            /// <param name = "type">enum KFType</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsCanKangFuStudent", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("KFType", 0)]
           public partial System.Boolean IS_CAN_KANG_FU_STUDENT(KFType type); 
*/
            /// <summary>
            ///   System.Boolean IsCanStudentKongFu(KFSchool kFSchool)
            /// </summary>
            /// <param name = "kFSchool">enum KFSchool</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsCanStudentKongFu", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("KFSchool", 0)]
           public partial System.Boolean IS_CAN_STUDENT_KONG_FU(KFSchool kFSchool); 
*/
            /// <summary>
            ///   System.Boolean IsDressKangFuQing(System.String name)
            /// </summary>
            /// <param name = "name">class System.String</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsDressKangFuQing", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
           public partial System.Boolean IS_DRESS_KANG_FU_QING(nint name); 
*/
            /// <summary>
            ///   System.Boolean IsDressKangu(System.String name, System.Int32 type)
            /// </summary>
            /// <param name = "name">class System.String</param>
            /// <param name = "type">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsDressKangu", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           public partial System.Boolean IS_DRESS_KANGU(nint name, System.Int32 type); 
*/
            /// <summary>
            ///   System.Int32 IsUIAddPoint()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsUIAddPoint", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Int32 IS_UI_ADD_POINT(); 
*/
            /// <summary>
            ///   System.Single JiaoCheng()
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("JiaoCheng", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Single JIAO_CHENG(); 
*/
            /// <summary>
            ///   System.Single Jin()
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Jin", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Single JIN(); 
*/
            /// <summary>
            ///   System.Single KangDianXue()
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("KangDianXue", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Single KANG_DIAN_XUE(); 
*/
            /// <summary>
            ///   System.Single KangDianXueRecover()
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("KangDianXueRecover", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Single KANG_DIAN_XUE_RECOVER(); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<PlayerKangFu , System.Boolean> KangFuAttack()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<PlayerKangFu , System.Boolean></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("KangFuAttack", "System.Collections.Generic.Dictionary<PlayerKangFu,System.Boolean>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint KANG_FU_ATTACK(); 
*/
            /// <summary>
            ///   System.Boolean KangFuPD(System.String& message, System.Collections.Generic.List<KangFuDataSet> preconditionOne)
            /// </summary>
            /// <param name = "message">class System.String&</param>
            /// <param name = "preconditionOne">class System.Collections.Generic.List<KangFuDataSet></param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("KangFuPD", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String&", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<KangFuDataSet>", 1)]
           public partial System.Boolean KANG_FU_PD(nint message, nint preconditionOne); 
*/
            /// <summary>
            ///   System.Boolean KangFuWX(System.String& message, KFLvDictionary one)
            /// </summary>
            /// <param name = "message">class System.String&</param>
            /// <param name = "one">class KFLvDictionary</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("KangFuWX", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String&", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("KFLvDictionary", 1)]
           public partial System.Boolean KANG_FU_WX(nint message, nint one); 
*/
            /// <summary>
            ///   System.Single KangHp()
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("KangHp", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Single KANG_HP(); 
*/
            /// <summary>
            ///   System.Single KangHpRecover()
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("KangHpRecover", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Single KANG_HP_RECOVER(); 
*/
            /// <summary>
            ///   System.Single KangZhaoHuo()
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("KangZhaoHuo", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Single KANG_ZHAO_HUO(); 
*/
            /// <summary>
            ///   System.Single KangZhaoHuoRecover()
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("KangZhaoHuoRecover", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Single KANG_ZHAO_HUO_RECOVER(); 
*/
            /// <summary>
            ///   System.Single KangZhongDu()
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("KangZhongDu", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Single KANG_ZHONG_DU(); 
*/
            /// <summary>
            ///   System.Single KangZhongDuRecover()
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("KangZhongDuRecover", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Single KANG_ZHONG_DU_RECOVER(); 
*/
            /// <summary>
            ///   System.Int32 KongFuTypeLv(KFType kFType)
            /// </summary>
            /// <param name = "kFType">enum KFType</param>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("KongFuTypeLv", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("KFType", 0)]
            public partial System.Int32 KONG_FU_TYPE_LV(KFType kFType);

            /// <summary>
            ///   System.Boolean KongFuTypeSameWeapon(KFType KongFuType)
            /// </summary>
            /// <param name = "KongFuType">enum KFType</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("KongFuTypeSameWeapon", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("KFType", 0)]
           public partial System.Boolean KONG_FU_TYPE_SAME_WEAPON(KFType KongFuType); 
*/
            /// <summary>
            ///   System.Void LoadSprie(UnityEngine.Sprite head, Spine.Unity.SkeletonDataAsset skeleton)
            /// </summary>
            /// <param name = "head">class UnityEngine.Sprite</param>
            /// <param name = "skeleton">class Spine.Unity.SkeletonDataAsset</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadSprie", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Sprite", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Spine.Unity.SkeletonDataAsset", 1)]
           public partial void LOAD_SPRIE(nint head, nint skeleton); 
*/
            /// <summary>
            ///   System.Single MingZhong()
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("MingZhong", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Single MING_ZHONG(); 
*/
            /// <summary>
            ///   System.Single Mu()
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Mu", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Single MU(); 
*/
            /// <summary>
            ///   System.Void PlayerArmorGasCalculate(System.Single& _Armor, System.Single& _Gas)
            /// </summary>
            /// <param name = "_Armor">struct System.Single&</param>
            /// <param name = "_Gas">struct System.Single&</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("PlayerArmorGasCalculate", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single&", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single&", 1)]
           public partial void PLAYER_ARMOR_GAS_CALCULATE(System.Single &_Armor, System.Single &_Gas); 
*/
            /// <summary>
            ///   System.Void PlayerProInfo(System.Int32& _lv, System.Int32& _addPoint, System.Collections.Generic.Dictionary<PlayerProType , System.Single>& _proBasePoints, System.Collections.Generic.Dictionary<PlayerProType , System.Single>& _proSkillPoints, System.Single& _wuXing, System.Single& _hp, System.Single& _Armor, System.Single& _Gas, System.Single& _maxHp, System.Single& _exp)
            /// </summary>
            /// <param name = "_lv">struct System.Int32&</param>
            /// <param name = "_addPoint">struct System.Int32&</param>
            /// <param name = "_proBasePoints">class System.Collections.Generic.Dictionary<PlayerProType , System.Single>&</param>
            /// <param name = "_proSkillPoints">class System.Collections.Generic.Dictionary<PlayerProType , System.Single>&</param>
            /// <param name = "_wuXing">struct System.Single&</param>
            /// <param name = "_hp">struct System.Single&</param>
            /// <param name = "_Armor">struct System.Single&</param>
            /// <param name = "_Gas">struct System.Single&</param>
            /// <param name = "_maxHp">struct System.Single&</param>
            /// <param name = "_exp">struct System.Single&</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("PlayerProInfo", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32&", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32&", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.Dictionary<PlayerProType,System.Single>&", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.Dictionary<PlayerProType,System.Single>&", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single&", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single&", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single&", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single&", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single&", 8)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single&", 9)]
           public partial void PLAYER_PRO_INFO(System.Int32 &_lv, System.Int32 &_addPoint, nint _proBasePoints, nint _proSkillPoints, System.Single &_wuXing, System.Single &_hp, System.Single &_Armor, System.Single &_Gas, System.Single &_maxHp, System.Single &_exp); 
*/
            /// <summary>
            ///   System.Boolean PlayerUseFoodItem(PlayerItemData playerItemData, System.Int32 num)
            /// </summary>
            /// <param name = "playerItemData">class PlayerItemData</param>
            /// <param name = "num">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("PlayerUseFoodItem", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("PlayerItemData", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           public partial System.Boolean PLAYER_USE_FOOD_ITEM(nint playerItemData, System.Int32 num); 
*/
            /// <summary>
            ///   System.Single ProAttack(System.String proName, System.Single proco, System.Collections.Generic.Dictionary<SkillDataSet , System.Single> equipsSkills)
            /// </summary>
            /// <param name = "proName">class System.String</param>
            /// <param name = "proco">struct System.Single</param>
            /// <param name = "equipsSkills">class System.Collections.Generic.Dictionary<SkillDataSet , System.Single></param>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ProAttack", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.Dictionary<SkillDataSet,System.Single>", 2)]
           public partial System.Single PRO_ATTACK(nint proName, System.Single proco, nint equipsSkills); 
*/
            /// <summary>
            ///   System.Void PutBag()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("PutBag", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void PUT_BAG(); 
*/
            /// <summary>
            ///   System.Void ReplaceFoodItem(PlayerItemData itemData, FoodItemData foodItem)
            /// </summary>
            /// <param name = "itemData">class PlayerItemData</param>
            /// <param name = "foodItem">class FoodItemData</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ReplaceFoodItem", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("PlayerItemData", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("FoodItemData", 1)]
           public partial void REPLACE_FOOD_ITEM(nint itemData, nint foodItem); 
*/
            /// <summary>
            ///   System.Void ResetPoint()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ResetPoint", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void RESET_POINT(); 
*/
            /// <summary>
            ///   System.Void ResetPointLast()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ResetPointLast", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void RESET_POINT_LAST(); 
*/
            /// <summary>
            ///   System.Void ResetTeXingPoint()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ResetTeXingPoint", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void RESET_TE_XING_POINT(); 
*/
            /// <summary>
            ///   System.Void SaveProLifePoints()
            /// </summary>
            /// <returns>struct System.Void</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SaveProLifePoints", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void SAVE_PRO_LIFE_POINTS();

            /// <summary>
            ///   System.Single ShanBi()
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ShanBi", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Single SHAN_BI(); 
*/
            /// <summary>
            ///   System.Single Shui()
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Shui", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Single SHUI(); 
*/
            /// <summary>
            ///   System.Boolean ShuXingPD(System.String& message, ProNumDictionary proNum)
            /// </summary>
            /// <param name = "message">class System.String&</param>
            /// <param name = "proNum">class ProNumDictionary</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ShuXingPD", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String&", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ProNumDictionary", 1)]
           public partial System.Boolean SHU_XING_PD(nint message, nint proNum); 
*/
            /// <summary>
            ///   System.Boolean StudentKongFu(PlayerItemData playerItemData)
            /// </summary>
            /// <param name = "playerItemData">class PlayerItemData</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("StudentKongFu", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("PlayerItemData", 0)]
           public partial System.Boolean STUDENT_KONG_FU(nint playerItemData); 
*/
            /// <summary>
            ///   System.Boolean StudentShanHaiLu(PlayerItemData playerItemData)
            /// </summary>
            /// <param name = "playerItemData">class PlayerItemData</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("StudentShanHaiLu", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("PlayerItemData", 0)]
           public partial System.Boolean STUDENT_SHAN_HAI_LU(nint playerItemData); 
*/
            /// <summary>
            ///   System.Single Tu()
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Tu", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Single TU(); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<System.String , PlayerInKangFu> UIBagInKongFu()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , PlayerInKangFu></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UIBagInKongFu", "System.Collections.Generic.Dictionary<System.String,PlayerInKangFu>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint UI_BAG_IN_KONG_FU(); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<System.String , PlayerKangFuSkill> UIBagKangFuSkill()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , PlayerKangFuSkill></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UIBagKangFuSkill", "System.Collections.Generic.Dictionary<System.String,PlayerKangFuSkill>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint UI_BAG_KANG_FU_SKILL(); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<System.String , PlayerKangFu> UIBagKongFu()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , PlayerKangFu></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UIBagKongFu", "System.Collections.Generic.Dictionary<System.String,PlayerKangFu>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint UI_BAG_KONG_FU(); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<System.String , PlayerKangFuSkill> UIBagKongFuQing()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , PlayerKangFuSkill></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UIBagKongFuQing", "System.Collections.Generic.Dictionary<System.String,PlayerKangFuSkill>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint UI_BAG_KONG_FU_QING(); 
*/
            /// <summary>
            ///   System.Void UIDressChong(PlayerChong data)
            /// </summary>
            /// <param name = "data">class PlayerChong</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UIDressChong", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("PlayerChong", 0)]
           public partial void UI_DRESS_CHONG(nint data); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<WeaponEquipUIIndex , PlayerEquipData> UIDressEquipInfo()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<WeaponEquipUIIndex , PlayerEquipData></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UIDressEquipInfo", "System.Collections.Generic.Dictionary<WeaponEquipUIIndex,PlayerEquipData>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint UI_DRESS_EQUIP_INFO(); 
*/
            /// <summary>
            ///   PlayerInKangFu UIDressInKangFuInfo()
            /// </summary>
            /// <returns>class PlayerInKangFu</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UIDressInKangFuInfo", "PlayerInKangFu", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint UI_DRESS_IN_KANG_FU_INFO(); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<System.Int32 , PlayerItemData> UIDressItem()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Int32 , PlayerItemData></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UIDressItem", "System.Collections.Generic.Dictionary<System.Int32,PlayerItemData>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint UI_DRESS_ITEM(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<PlayerKangFu> UIDressKangFu()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<PlayerKangFu></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UIDressKangFu", "System.Collections.Generic.List<PlayerKangFu>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint UI_DRESS_KANG_FU(); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<System.Int32 , PlayerKangFu> UIDressKangfuInfo()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Int32 , PlayerKangFu></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UIDressKangfuInfo", "System.Collections.Generic.Dictionary<System.Int32,PlayerKangFu>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint UI_DRESS_KANGFU_INFO(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<PlayerKangFuSkill> UIDressKangfuQingInfo()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<PlayerKangFuSkill></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UIDressKangfuQingInfo", "System.Collections.Generic.List<PlayerKangFuSkill>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint UI_DRESS_KANGFU_QING_INFO(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<PlayerKangFuSkill> UIDressKangFuSkillInfo()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<PlayerKangFuSkill></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UIDressKangFuSkillInfo", "System.Collections.Generic.List<PlayerKangFuSkill>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint UI_DRESS_KANG_FU_SKILL_INFO(); 
*/
            /// <summary>
            ///   System.Boolean UIDressKongFu(System.String name)
            /// </summary>
            /// <param name = "name">class System.String</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UIDressKongFu", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
           public partial System.Boolean UI_DRESS_KONG_FU(nint name); 
*/
            /// <summary>
            ///   System.Boolean UIDropKongFu(System.String name)
            /// </summary>
            /// <param name = "name">class System.String</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UIDropKongFu", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
           public partial System.Boolean UI_DROP_KONG_FU(nint name); 
*/
            /// <summary>
            ///   System.Boolean UnKangFu(System.String& message, System.Collections.Generic.List<UniqueSkillDataSet> PreconditionOne)
            /// </summary>
            /// <param name = "message">class System.String&</param>
            /// <param name = "PreconditionOne">class System.Collections.Generic.List<UniqueSkillDataSet></param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UnKangFu", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String&", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<UniqueSkillDataSet>", 1)]
           public partial System.Boolean UN_KANG_FU(nint message, nint PreconditionOne); 
*/
            /// <summary>
            ///   System.Void UpDataHp(System.Collections.Generic.Dictionary<SkillDataSet , System.Single> resultSkill)
            /// </summary>
            /// <param name = "resultSkill">class System.Collections.Generic.Dictionary<SkillDataSet , System.Single></param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpDataHp", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.Dictionary<SkillDataSet,System.Single>", 0)]
           public partial void UP_DATA_HP(nint resultSkill); 
*/
            /// <summary>
            ///   System.Single UpdateAddHp(System.Single addHp)
            /// </summary>
            /// <param name = "addHp">struct System.Single</param>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateAddHp", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
           public partial System.Single UPDATE_ADD_HP(System.Single addHp); 
*/
            /// <summary>
            ///   System.Void UpdateCurrentHp(System.Single hp)
            /// </summary>
            /// <param name = "hp">struct System.Single</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateCurrentHp", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
           public partial void UPDATE_CURRENT_HP(System.Single hp); 
*/
            /// <summary>
            ///   System.Void UpdateData(FriendDefaultData defaultData)
            /// </summary>
            /// <param name = "defaultData">class FriendDefaultData</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("FriendDefaultData", 0)]
           public partial void UPDATE_DATA(nint defaultData); 
*/
            /// <summary>
            ///   System.Single UpdateReduceHp(System.Single delHp)
            /// </summary>
            /// <param name = "delHp">struct System.Single</param>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateReduceHp", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
           public partial System.Single UPDATE_REDUCE_HP(System.Single delHp); 
*/
            /// <summary>
            ///   System.Void UpLv()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpLv", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void UP_LV(); 
*/
            /// <summary>
            ///   System.Boolean UseItem(PlayerItemData playerItemData, System.Int32 num)
            /// </summary>
            /// <param name = "playerItemData">class PlayerItemData</param>
            /// <param name = "num">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UseItem", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("PlayerItemData", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           public partial System.Boolean USE_ITEM(nint playerItemData, System.Int32 num); 
*/
            /// <summary>
            ///   System.Single YvQi()
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("YvQi", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Single YV_QI(); 
*/
        }
    }
}