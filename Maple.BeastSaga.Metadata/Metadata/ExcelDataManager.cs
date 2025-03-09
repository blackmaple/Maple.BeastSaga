namespace Maple.BeastSaga.Metadata
{
    /// <summary>
    /// class ["ExcelData".""."ExcelDataManager"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_ExcelDataManager>, Ptr_ExcelDataManager>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("ExcelData", "", "ExcelDataManager", "ExcelDataManager")]
    public partial class ExcelDataManager
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_ExcelDataManager(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_ExcelDataManager(System.IntPtr ptr) => new Ptr_ExcelDataManager(ptr);
            public static implicit operator System.IntPtr(Ptr_ExcelDataManager ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_ExcelDataManager ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["ExcelData".""."ExcelDataManager"]
        /// </summary>
        partial struct Ptr_ExcelDataManager
        {
            /// <summary>
            /// 0x0 ExcelDataManager Instance
            /// class ["ExcelData".""."ExcelDataManager"]
            /// </summary>
            /// <returns>class ExcelDataManager</returns>
       
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Instance", "ExcelDataManager")]
            public static partial ExcelDataManager.Ptr_ExcelDataManager INSTANCE { get; set; } 
 

            /// <summary>
            /// 0x10 ExcelData.KFRankTable p_KFRankTable
            /// class ["ExcelData"."ExcelData"."KFRankTable"]
            /// </summary>
            /// <returns>class ExcelData.KFRankTable</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("p_KFRankTable", "ExcelData.KFRankTable")]
            public partial nint P_KF_RANK_TABLE { get; set; } 
*/

            /// <summary>
            /// 0x18 ExcelData.SchoolTable p_SchoolTable
            /// class ["ExcelData"."ExcelData"."SchoolTable"]
            /// </summary>
            /// <returns>class ExcelData.SchoolTable</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("p_SchoolTable", "ExcelData.SchoolTable")]
            public partial nint P_SCHOOL_TABLE { get; set; } 
*/

            /// <summary>
            /// 0x20 ExcelData.FiveTable p_FiveTable
            /// class ["ExcelData"."ExcelData"."FiveTable"]
            /// </summary>
            /// <returns>class ExcelData.FiveTable</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("p_FiveTable", "ExcelData.FiveTable")]
            public partial nint P_FIVE_TABLE { get; set; } 
*/

            /// <summary>
            /// 0x28 ExcelData.KFTypeTable p_KFTypeTable
            /// class ["ExcelData"."ExcelData"."KFTypeTable"]
            /// </summary>
            /// <returns>class ExcelData.KFTypeTable</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("p_KFTypeTable", "ExcelData.KFTypeTable")]
            public partial nint P_KF_TYPE_TABLE { get; set; } 
*/

            /// <summary>
            /// 0x30 ExcelData.KFTable p_KFTable
            /// class ["ExcelData"."ExcelData"."KFTable"]
            /// </summary>
            /// <returns>class ExcelData.KFTable</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("p_KFTable", "ExcelData.KFTable")]
            public partial nint P_KF_TABLE { get; set; } 
*/

            /// <summary>
            /// 0x38 ExcelData.KFCostTable p_KFCostTable
            /// class ["ExcelData"."ExcelData"."KFCostTable"]
            /// </summary>
            /// <returns>class ExcelData.KFCostTable</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("p_KFCostTable", "ExcelData.KFCostTable")]
            public partial nint P_KF_COST_TABLE { get; set; } 
*/

            /// <summary>
            /// 0x40 ExcelData.ScreenTable p_ScreenTable
            /// class ["ExcelData"."ExcelData"."ScreenTable"]
            /// </summary>
            /// <returns>class ExcelData.ScreenTable</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("p_ScreenTable", "ExcelData.ScreenTable")]
            public partial nint P_SCREEN_TABLE { get; set; } 
*/

            /// <summary>
            /// 0x48 ExcelData.Exp p_Exp
            /// class ["ExcelData"."ExcelData"."Exp"]
            /// </summary>
            /// <returns>class ExcelData.Exp</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("p_Exp", "ExcelData.Exp")]
            public partial nint P_EXP { get; set; } 
*/

            /// <summary>
            /// 0x50 ExcelData.FishExp p_FishExp
            /// class ["ExcelData"."ExcelData"."FishExp"]
            /// </summary>
            /// <returns>class ExcelData.FishExp</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("p_FishExp", "ExcelData.FishExp")]
            public partial nint P_FISH_EXP { get; set; } 
*/

            /// <summary>
            /// 0x58 ExcelData.FriendLoveTable p_FriendLoveTable
            /// class ["ExcelData"."ExcelData"."FriendLoveTable"]
            /// </summary>
            /// <returns>class ExcelData.FriendLoveTable</returns>
   
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("p_FriendLoveTable", "ExcelData.FriendLoveTable")]
            public partial FriendLoveTable.Ptr_FriendLoveTable P_FRIEND_LOVE_TABLE { get; set; } 
 

            /// <summary>
            /// 0x60 ExcelData.JoyButton p_JoyButton
            /// class ["ExcelData"."ExcelData"."JoyButton"]
            /// </summary>
            /// <returns>class ExcelData.JoyButton</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("p_JoyButton", "ExcelData.JoyButton")]
            public partial nint P_JOY_BUTTON { get; set; } 
*/

            /// <summary>
            /// 0x68 ExcelData.KongfuCost p_KongfuCost
            /// class ["ExcelData"."ExcelData"."KongfuCost"]
            /// </summary>
            /// <returns>class ExcelData.KongfuCost</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("p_KongfuCost", "ExcelData.KongfuCost")]
            public partial nint P_KONGFU_COST { get; set; } 
*/

            /// <summary>
            /// 0x70 ExcelData.KongfuExp p_KongfuExp
            /// class ["ExcelData"."ExcelData"."KongfuExp"]
            /// </summary>
            /// <returns>class ExcelData.KongfuExp</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("p_KongfuExp", "ExcelData.KongfuExp")]
            public partial nint P_KONGFU_EXP { get; set; } 
*/

            /// <summary>
            /// 0x78 ExcelData.MapJumpTable p_MapJumpTable
            /// class ["ExcelData"."ExcelData"."MapJumpTable"]
            /// </summary>
            /// <returns>class ExcelData.MapJumpTable</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("p_MapJumpTable", "ExcelData.MapJumpTable")]
            public partial nint P_MAP_JUMP_TABLE { get; set; } 
*/

            /// <summary>
            /// 0x80 ExcelData.Thanks p_Thanks
            /// class ["ExcelData"."ExcelData"."Thanks"]
            /// </summary>
            /// <returns>class ExcelData.Thanks</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("p_Thanks", "ExcelData.Thanks")]
            public partial nint P_THANKS { get; set; } 
*/

            /// <summary>
            /// 0x88 ExcelData.UnlockExp p_UnlockExp
            /// class ["ExcelData"."ExcelData"."UnlockExp"]
            /// </summary>
            /// <returns>class ExcelData.UnlockExp</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("p_UnlockExp", "ExcelData.UnlockExp")]
            public partial nint P_UNLOCK_EXP { get; set; } 
*/

            /// <summary>
            /// 0x90 ExcelData.WeatherArea p_WeatherArea
            /// class ["ExcelData"."ExcelData"."WeatherArea"]
            /// </summary>
            /// <returns>class ExcelData.WeatherArea</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("p_WeatherArea", "ExcelData.WeatherArea")]
            public partial nint P_WEATHER_AREA { get; set; } 
*/

            /// <summary>
            /// 0x98 ExcelData.WeatherTime p_WeatherTime
            /// class ["ExcelData"."ExcelData"."WeatherTime"]
            /// </summary>
            /// <returns>class ExcelData.WeatherTime</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("p_WeatherTime", "ExcelData.WeatherTime")]
            public partial nint P_WEATHER_TIME { get; set; } 
*/

            /// <summary>
            /// 0xA0 ExcelData.WeatherType p_WeatherType
            /// class ["ExcelData"."ExcelData"."WeatherType"]
            /// </summary>
            /// <returns>class ExcelData.WeatherType</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("p_WeatherType", "ExcelData.WeatherType")]
            public partial nint P_WEATHER_TYPE { get; set; } 
*/

            /// <summary>
            /// 0xA8 ExcelData.YiExp p_YiExp
            /// class ["ExcelData"."ExcelData"."YiExp"]
            /// </summary>
            /// <returns>class ExcelData.YiExp</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("p_YiExp", "ExcelData.YiExp")]
            public partial nint P_YI_EXP { get; set; } 
*/
        }

        /// <summary>
        /// class ["ExcelData".""."ExcelDataManager"]
        /// </summary>
        partial struct Ptr_ExcelDataManager
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
            ///   System.Collections.Generic.List<ExcelData.ExpItem> GetExpItemAll()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<ExcelData.ExpItem></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetExpItemAll", "System.Collections.Generic.List<ExcelData.ExpItem>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_EXP_ITEM_ALL(); 
*/
            /// <summary>
            ///   ExcelData.ExpItem GetExpItemByID(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>class ExcelData.ExpItem</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetExpItemByID", "ExcelData.ExpItem", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_EXP_ITEM_BY_ID(System.Int32 id); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<ExcelData.FishExpItem> GetFishExpItemAll()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<ExcelData.FishExpItem></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetFishExpItemAll", "System.Collections.Generic.List<ExcelData.FishExpItem>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_FISH_EXP_ITEM_ALL(); 
*/
            /// <summary>
            ///   ExcelData.FishExpItem GetFishExpItemByID(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>class ExcelData.FishExpItem</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetFishExpItemByID", "ExcelData.FishExpItem", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_FISH_EXP_ITEM_BY_ID(System.Int32 id); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<ExcelData.FiveTableItem> GetFiveTableItemAll()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<ExcelData.FiveTableItem></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetFiveTableItemAll", "System.Collections.Generic.List<ExcelData.FiveTableItem>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_FIVE_TABLE_ITEM_ALL(); 
*/
            /// <summary>
            ///   ExcelData.FiveTableItem GetFiveTableItemByID(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>class ExcelData.FiveTableItem</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetFiveTableItemByID", "ExcelData.FiveTableItem", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_FIVE_TABLE_ITEM_BY_ID(System.Int32 id); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<ExcelData.FriendLoveTableItem> GetFriendLoveTableItemAll()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<ExcelData.FriendLoveTableItem></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetFriendLoveTableItemAll", "System.Collections.Generic.List<ExcelData.FriendLoveTableItem>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_FRIEND_LOVE_TABLE_ITEM_ALL(); 
*/
            /// <summary>
            ///   ExcelData.FriendLoveTableItem GetFriendLoveTableItemByID(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>class ExcelData.FriendLoveTableItem</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetFriendLoveTableItemByID", "ExcelData.FriendLoveTableItem", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_FRIEND_LOVE_TABLE_ITEM_BY_ID(System.Int32 id); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<ExcelData.JoyButtonItem> GetJoyButtonItemAll()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<ExcelData.JoyButtonItem></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetJoyButtonItemAll", "System.Collections.Generic.List<ExcelData.JoyButtonItem>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_JOY_BUTTON_ITEM_ALL(); 
*/
            /// <summary>
            ///   ExcelData.JoyButtonItem GetJoyButtonItemByID(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>class ExcelData.JoyButtonItem</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetJoyButtonItemByID", "ExcelData.JoyButtonItem", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_JOY_BUTTON_ITEM_BY_ID(System.Int32 id); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<ExcelData.KFCostTableItem> GetKFCostTableItemAll()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<ExcelData.KFCostTableItem></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetKFCostTableItemAll", "System.Collections.Generic.List<ExcelData.KFCostTableItem>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_KF_COST_TABLE_ITEM_ALL(); 
*/
            /// <summary>
            ///   ExcelData.KFCostTableItem GetKFCostTableItemByID(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>class ExcelData.KFCostTableItem</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetKFCostTableItemByID", "ExcelData.KFCostTableItem", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_KF_COST_TABLE_ITEM_BY_ID(System.Int32 id); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<ExcelData.KFRankTableItem> GetKFRankTableItemAll()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<ExcelData.KFRankTableItem></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetKFRankTableItemAll", "System.Collections.Generic.List<ExcelData.KFRankTableItem>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_KF_RANK_TABLE_ITEM_ALL(); 
*/
            /// <summary>
            ///   ExcelData.KFRankTableItem GetKFRankTableItemByID(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>class ExcelData.KFRankTableItem</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetKFRankTableItemByID", "ExcelData.KFRankTableItem", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_KF_RANK_TABLE_ITEM_BY_ID(System.Int32 id); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<ExcelData.KFTableItem> GetKFTableItemAll()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<ExcelData.KFTableItem></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetKFTableItemAll", "System.Collections.Generic.List<ExcelData.KFTableItem>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_KF_TABLE_ITEM_ALL(); 
*/
            /// <summary>
            ///   ExcelData.KFTableItem GetKFTableItemByID(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>class ExcelData.KFTableItem</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetKFTableItemByID", "ExcelData.KFTableItem", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_KF_TABLE_ITEM_BY_ID(System.Int32 id); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<ExcelData.KFTypeTableItem> GetKFTypeTableItemAll()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<ExcelData.KFTypeTableItem></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetKFTypeTableItemAll", "System.Collections.Generic.List<ExcelData.KFTypeTableItem>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_KF_TYPE_TABLE_ITEM_ALL(); 
*/
            /// <summary>
            ///   ExcelData.KFTypeTableItem GetKFTypeTableItemByID(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>class ExcelData.KFTypeTableItem</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetKFTypeTableItemByID", "ExcelData.KFTypeTableItem", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_KF_TYPE_TABLE_ITEM_BY_ID(System.Int32 id); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<ExcelData.KongfuCostItem> GetKongfuCostItemAll()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<ExcelData.KongfuCostItem></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetKongfuCostItemAll", "System.Collections.Generic.List<ExcelData.KongfuCostItem>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_KONGFU_COST_ITEM_ALL(); 
*/
            /// <summary>
            ///   ExcelData.KongfuCostItem GetKongfuCostItemByID(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>class ExcelData.KongfuCostItem</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetKongfuCostItemByID", "ExcelData.KongfuCostItem", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_KONGFU_COST_ITEM_BY_ID(System.Int32 id); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<ExcelData.KongfuExpItem> GetKongfuExpItemAll()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<ExcelData.KongfuExpItem></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetKongfuExpItemAll", "System.Collections.Generic.List<ExcelData.KongfuExpItem>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_KONGFU_EXP_ITEM_ALL(); 
*/
            /// <summary>
            ///   ExcelData.KongfuExpItem GetKongfuExpItemByID(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>class ExcelData.KongfuExpItem</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetKongfuExpItemByID", "ExcelData.KongfuExpItem", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_KONGFU_EXP_ITEM_BY_ID(System.Int32 id); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<ExcelData.MapJumpTableItem> GetMapJumpTableItemAll()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<ExcelData.MapJumpTableItem></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMapJumpTableItemAll", "System.Collections.Generic.List<ExcelData.MapJumpTableItem>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_MAP_JUMP_TABLE_ITEM_ALL(); 
*/
            /// <summary>
            ///   ExcelData.MapJumpTableItem GetMapJumpTableItemByID(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>class ExcelData.MapJumpTableItem</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMapJumpTableItemByID", "ExcelData.MapJumpTableItem", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_MAP_JUMP_TABLE_ITEM_BY_ID(System.Int32 id); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<ExcelData.SchoolTableItem> GetSchoolTableItemAll()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<ExcelData.SchoolTableItem></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSchoolTableItemAll", "System.Collections.Generic.List<ExcelData.SchoolTableItem>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_SCHOOL_TABLE_ITEM_ALL(); 
*/
            /// <summary>
            ///   ExcelData.SchoolTableItem GetSchoolTableItemByID(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>class ExcelData.SchoolTableItem</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSchoolTableItemByID", "ExcelData.SchoolTableItem", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_SCHOOL_TABLE_ITEM_BY_ID(System.Int32 id); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<ExcelData.ScreenTableItem> GetScreenTableItemAll()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<ExcelData.ScreenTableItem></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetScreenTableItemAll", "System.Collections.Generic.List<ExcelData.ScreenTableItem>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_SCREEN_TABLE_ITEM_ALL(); 
*/
            /// <summary>
            ///   ExcelData.ScreenTableItem GetScreenTableItemByID(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>class ExcelData.ScreenTableItem</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetScreenTableItemByID", "ExcelData.ScreenTableItem", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_SCREEN_TABLE_ITEM_BY_ID(System.Int32 id); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<ExcelData.ThanksItem> GetThanksItemAll()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<ExcelData.ThanksItem></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetThanksItemAll", "System.Collections.Generic.List<ExcelData.ThanksItem>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_THANKS_ITEM_ALL(); 
*/
            /// <summary>
            ///   ExcelData.ThanksItem GetThanksItemByID(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>class ExcelData.ThanksItem</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetThanksItemByID", "ExcelData.ThanksItem", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_THANKS_ITEM_BY_ID(System.Int32 id); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<ExcelData.UnlockExpItem> GetUnlockExpItemAll()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<ExcelData.UnlockExpItem></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetUnlockExpItemAll", "System.Collections.Generic.List<ExcelData.UnlockExpItem>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_UNLOCK_EXP_ITEM_ALL(); 
*/
            /// <summary>
            ///   ExcelData.UnlockExpItem GetUnlockExpItemByID(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>class ExcelData.UnlockExpItem</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetUnlockExpItemByID", "ExcelData.UnlockExpItem", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_UNLOCK_EXP_ITEM_BY_ID(System.Int32 id); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<ExcelData.WeatherAreaItem> GetWeatherAreaItemAll()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<ExcelData.WeatherAreaItem></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetWeatherAreaItemAll", "System.Collections.Generic.List<ExcelData.WeatherAreaItem>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_WEATHER_AREA_ITEM_ALL(); 
*/
            /// <summary>
            ///   ExcelData.WeatherAreaItem GetWeatherAreaItemByID(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>class ExcelData.WeatherAreaItem</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetWeatherAreaItemByID", "ExcelData.WeatherAreaItem", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_WEATHER_AREA_ITEM_BY_ID(System.Int32 id); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<ExcelData.WeatherTimeItem> GetWeatherTimeItemAll()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<ExcelData.WeatherTimeItem></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetWeatherTimeItemAll", "System.Collections.Generic.List<ExcelData.WeatherTimeItem>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_WEATHER_TIME_ITEM_ALL(); 
*/
            /// <summary>
            ///   ExcelData.WeatherTimeItem GetWeatherTimeItemByID(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>class ExcelData.WeatherTimeItem</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetWeatherTimeItemByID", "ExcelData.WeatherTimeItem", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_WEATHER_TIME_ITEM_BY_ID(System.Int32 id); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<ExcelData.WeatherTypeItem> GetWeatherTypeItemAll()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<ExcelData.WeatherTypeItem></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetWeatherTypeItemAll", "System.Collections.Generic.List<ExcelData.WeatherTypeItem>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_WEATHER_TYPE_ITEM_ALL(); 
*/
            /// <summary>
            ///   ExcelData.WeatherTypeItem GetWeatherTypeItemByID(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>class ExcelData.WeatherTypeItem</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetWeatherTypeItemByID", "ExcelData.WeatherTypeItem", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_WEATHER_TYPE_ITEM_BY_ID(System.Int32 id); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<ExcelData.YiExpItem> GetYiExpItemAll()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<ExcelData.YiExpItem></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetYiExpItemAll", "System.Collections.Generic.List<ExcelData.YiExpItem>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_YI_EXP_ITEM_ALL(); 
*/
            /// <summary>
            ///   ExcelData.YiExpItem GetYiExpItemByID(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>class ExcelData.YiExpItem</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetYiExpItemByID", "ExcelData.YiExpItem", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_YI_EXP_ITEM_BY_ID(System.Int32 id); 
*/
            /// <summary>
            ///   System.Object Load(System.String name)
            /// </summary>
            /// <param name = "name">class System.String</param>
            /// <returns>class System.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Load", "System.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial nint LOAD(nint name); 
*/
            /// <summary>
            ///   System.Void LoadAll()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadAll", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            public partial void LOAD_ALL(); 
*/
        }
    }
}