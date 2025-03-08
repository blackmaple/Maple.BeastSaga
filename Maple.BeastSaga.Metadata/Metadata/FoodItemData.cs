namespace Maple.BeastSaga.Metadata
{
    /// <summary>
    /// class ["Model.Runtime".""."FoodItemData"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_FoodItemData>, Ptr_FoodItemData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Model.Runtime", "", "FoodItemData", "FoodItemData")]
    public partial class FoodItemData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_FoodItemData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_FoodItemData(System.IntPtr ptr) => new Ptr_FoodItemData(ptr);
            public static implicit operator System.IntPtr(Ptr_FoodItemData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_FoodItemData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Model.Runtime".""."FoodItemData"]
        /// </summary>
        partial struct Ptr_FoodItemData
        {
            /// <summary>
            /// 0x10 System.String ItemName
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ItemName", "System.String")]
            public partial nint ITEM_NAME { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Collections.Generic.Dictionary<System.String , System.Single> SkillStartTime
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Single></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("SkillStartTime", "System.Collections.Generic.Dictionary<System.String,System.Single>")]
            public partial nint SKILL_START_TIME { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Collections.Generic.Dictionary<System.String , System.Single> SkillTime
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Single></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("SkillTime", "System.Collections.Generic.Dictionary<System.String,System.Single>")]
            public partial nint SKILL_TIME { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Collections.Generic.List<System.String> removeSkillNum
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("removeSkillNum", "System.Collections.Generic.List<System.String>")]
            public partial nint REMOVE_SKILL_NUM { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Int32 seconds
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("seconds", "System.Int32")]
            public partial System.Int32 SECONDS { get; set; } 
*/

            /// <summary>
            /// 0x34 System.Int32 minutes
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("minutes", "System.Int32")]
            public partial System.Int32 MINUTES { get; set; } 
*/

            /// <summary>
            /// 0x38 System.Int32 dayTime
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("dayTime", "System.Int32")]
            public partial System.Int32 DAY_TIME { get; set; } 
*/

            /// <summary>
            /// 0x3C System.Int32 monthTime
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("monthTime", "System.Int32")]
            public partial System.Int32 MONTH_TIME { get; set; } 
*/

            /// <summary>
            /// 0x40 System.Int32 yearTime
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("yearTime", "System.Int32")]
            public partial System.Int32 YEAR_TIME { get; set; } 
*/
        }

        /// <summary>
        /// class ["Model.Runtime".""."FoodItemData"]
        /// </summary>
        partial struct Ptr_FoodItemData
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
            ///   System.Int32 CalculateMinutesDifference(System.Int32 currentYear, System.Int32 currentMonth, System.Int32 currentDay, System.Int32 currentHour, System.Int32 currentMinutes)
            /// </summary>
            /// <param name = "currentYear">struct System.Int32</param>
            /// <param name = "currentMonth">struct System.Int32</param>
            /// <param name = "currentDay">struct System.Int32</param>
            /// <param name = "currentHour">struct System.Int32</param>
            /// <param name = "currentMinutes">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CalculateMinutesDifference", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
            public partial System.Int32 CALCULATE_MINUTES_DIFFERENCE(System.Int32 currentYear, System.Int32 currentMonth, System.Int32 currentDay, System.Int32 currentHour, System.Int32 currentMinutes); 
*/
            /// <summary>
            ///   System.Void DestoryData()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DestoryData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void DESTORY_DATA(); 
*/
            /// <summary>
            ///   ItemDataSet GetItemDataSet()
            /// </summary>
            /// <returns>class ItemDataSet</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetItemDataSet", "ItemDataSet", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_ITEM_DATA_SET(); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<SkillDataSet , System.Single> GetSkillCalculate()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<SkillDataSet , System.Single></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSkillCalculate", "System.Collections.Generic.Dictionary<SkillDataSet,System.Single>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_SKILL_CALCULATE(); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<System.String , System.Single> GetSkillCalculateLayer()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Single></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSkillCalculateLayer", "System.Collections.Generic.Dictionary<System.String,System.Single>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_SKILL_CALCULATE_LAYER(); 
*/
            /// <summary>
            ///   System.Void InitFoodItemData(ItemDataSet itemDataSet, System.Int32 yTime, System.Int32 mTime, System.Int32 dTime, System.Int32 minTime, System.Int32 secTime)
            /// </summary>
            /// <param name = "itemDataSet">class ItemDataSet</param>
            /// <param name = "yTime">struct System.Int32</param>
            /// <param name = "mTime">struct System.Int32</param>
            /// <param name = "dTime">struct System.Int32</param>
            /// <param name = "minTime">struct System.Int32</param>
            /// <param name = "secTime">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InitFoodItemData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ItemDataSet", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
            public partial void INIT_FOOD_ITEM_DATA(nint itemDataSet, System.Int32 yTime, System.Int32 mTime, System.Int32 dTime, System.Int32 minTime, System.Int32 secTime); 
*/
            /// <summary>
            ///   System.Boolean IsRmoveFoodItem()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsRmoveFoodItem", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean IS_RMOVE_FOOD_ITEM(); 
*/
            /// <summary>
            ///   System.Boolean UpdateCheckTime(System.Int32 currentYear, System.Int32 currentMonth, System.Int32 currentDay, System.Int32 currentHour, System.Int32 currentMinutes)
            /// </summary>
            /// <param name = "currentYear">struct System.Int32</param>
            /// <param name = "currentMonth">struct System.Int32</param>
            /// <param name = "currentDay">struct System.Int32</param>
            /// <param name = "currentHour">struct System.Int32</param>
            /// <param name = "currentMinutes">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateCheckTime", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
            public partial System.Boolean UPDATE_CHECK_TIME(System.Int32 currentYear, System.Int32 currentMonth, System.Int32 currentDay, System.Int32 currentHour, System.Int32 currentMinutes); 
*/
        }
    }
}