using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MetadataCollections;

namespace Maple.BeastSaga.Metadata
{
    /// <summary>
    /// class ["Model.Runtime".""."PlayerEquipData"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_PlayerEquipData>, Ptr_PlayerEquipData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Model.Runtime", "", "PlayerEquipData", "PlayerEquipData")]
    public partial class PlayerEquipData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_PlayerEquipData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_PlayerEquipData(System.IntPtr ptr) => new Ptr_PlayerEquipData(ptr);
            public static implicit operator System.IntPtr(Ptr_PlayerEquipData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_PlayerEquipData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Model.Runtime".""."PlayerEquipData"]
        /// </summary>
        partial struct Ptr_PlayerEquipData
        {
            /// <summary>
            /// 0x10 EquipDataSet _EquipData
            /// class ["Model.Runtime".""."EquipDataSet"]
            /// </summary>
            /// <returns>class EquipDataSet</returns>
              
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_EquipData", "EquipDataSet")]
            public partial EquipDataSet.Ptr_EquipDataSet _EQUIP_DATA { get; set; } 
 

            /// <summary>
            /// 0x18 System.Collections.Generic.List<ItemDataSet> _QiItemDatas
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<ItemDataSet></returns>
          
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_QiItemDatas", "System.Collections.Generic.List<ItemDataSet>")]
            public partial SysPtrList<ItemDataSet.Ptr_ItemDataSet> _QI_ITEM_DATAS { get; set; } 
 

            /// <summary>
            /// 0x20 System.Collections.Generic.List<System.String> _QiItemNames
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
       
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_QiItemNames", "System.Collections.Generic.List<System.String>")]
            public partial SysPtrList<PMonoString> _QI_ITEM_NAMES { get; set; } 
 

            /// <summary>
            /// 0x28 System.String _Name
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_Name", "System.String")]
            public partial nint _NAME { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<System.Int32>> _SkillLv
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<System.Int32>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_SkillLv", "System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<System.Int32>>")]
            public partial nint _SKILL_LV { get; set; } 
*/

            /// <summary>
            /// 0x38 System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<System.Single>> _ItemSkillLv
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<System.Single>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_ItemSkillLv", "System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<System.Single>>")]
            public partial nint _ITEM_SKILL_LV { get; set; } 
*/

            /// <summary>
            /// 0x40 System.Int32 _Lv
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_Lv", "System.Int32")]
            public partial System.Int32 _LV { get; set; } 
*/

            /// <summary>
            /// 0x44 System.Int32 _Durable
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_Durable", "System.Int32")]
            public partial System.Int32 _DURABLE { get; set; } 
*/

            /// <summary>
            /// 0x48 DressType _DressType
            /// enum ["Model.Runtime".""."DressType"]
            /// </summary>
            /// <returns>enum DressType</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_DressType", "DressType")]
            public partial DressType _DRESS_TYPE { get; set; } 
*/

            /// <summary>
            /// 0x50 System.Double _GetTimeNew
            /// struct ["mscorlib"."System"."Double"]
            /// </summary>
            /// <returns>struct System.Double</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_GetTimeNew", "System.Double")]
            public partial System.Double _GET_TIME_NEW { get; set; } 
*/

            /// <summary>
            /// 0x58 System.Boolean _IsCanLingHua
            /// struct ["mscorlib"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_IsCanLingHua", "System.Boolean")]
            public partial System.Boolean _IS_CAN_LING_HUA { get; set; } 
*/

            /// <summary>
            /// 0x5C System.Int32 _IsFirstGet
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_IsFirstGet", "System.Int32")]
            public partial System.Int32 _IS_FIRST_GET { get; set; } 
*/
        }

        /// <summary>
        /// class ["Model.Runtime".""."PlayerEquipData"]
        /// </summary>
        partial struct Ptr_PlayerEquipData
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
            ///   System.Void AddItemSkill(System.String name, System.Single num)
            /// </summary>
            /// <param name = "name">class System.String</param>
            /// <param name = "num">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddItemSkill", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            public partial void ADD_ITEM_SKILL(nint name, System.Single num); 
*/
            /// <summary>
            ///   System.Boolean AddQiItem(ItemDataSet itemData)
            /// </summary>
            /// <param name = "itemData">class ItemDataSet</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddQiItem", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ItemDataSet", 0)]
            public partial System.Boolean ADD_QI_ITEM(nint itemData); 
*/
            /// <summary>
            ///   System.Void CanLingHuaSet(System.Boolean isCanLingHua)
            /// </summary>
            /// <param name = "isCanLingHua">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CanLingHuaSet", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void CAN_LING_HUA_SET(System.Boolean isCanLingHua); 
*/
            /// <summary>
            ///   System.Void CheckDataSet()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CheckDataSet", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CHECK_DATA_SET(); 
*/
            /// <summary>
            ///   System.Void SetData(EquipDataSet equipDataSet)
            /// </summary>
            /// <param name = "equipDataSet">class EquipDataSet</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("EquipDataSet", 0)]
            public partial void SET_DATA(nint equipDataSet); 
*/
            /// <summary>
            ///   System.Void ShopData(EquipDataSet equipDataSet)
            /// </summary>
            /// <param name = "equipDataSet">class EquipDataSet</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ShopData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("EquipDataSet", 0)]
            public partial void SHOP_DATA(nint equipDataSet); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<SkillDataSet , System.Single> SkillCalculate()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<SkillDataSet , System.Single></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SkillCalculate", "System.Collections.Generic.Dictionary<SkillDataSet,System.Single>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint SKILL_CALCULATE(); 
*/
            /// <summary>
            ///   System.Single SumSkillByLv(System.Int32 lv, SkillDataSet skillData)
            /// </summary>
            /// <param name = "lv">struct System.Int32</param>
            /// <param name = "skillData">class SkillDataSet</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SumSkillByLv", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("SkillDataSet", 1)]
            public partial System.Single SUM_SKILL_BY_LV(System.Int32 lv, nint skillData); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<System.Collections.Generic.Dictionary<SkillDataSet , System.Single>> UISkillCalculate()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Collections.Generic.Dictionary<SkillDataSet , System.Single>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UISkillCalculate", "System.Collections.Generic.List<System.Collections.Generic.Dictionary<SkillDataSet,System.Single>>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint UI_SKILL_CALCULATE(); 
*/
            /// <summary>
            ///   System.Void UpdateTime()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateTime", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void UPDATE_TIME(); 
*/
        }
    }
}