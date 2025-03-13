using Maple.MonoGameAssistant.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Maple.BeastSaga.Metadata
{
    [StructLayout(LayoutKind.Explicit)]
    public readonly unsafe partial struct Ref_MonoDictionary_BeastSaga
    {
        [FieldOffset(0)]
        public readonly REF_MONO_OBJECT _obj;

        /// <summary>
        /// 0x10 System.Int32[] _buckets
        /// </summary>
        [FieldOffset(0x10)]
        public readonly PMonoArray<Ref_MonoArray, int> _buckets;


        /// <summary>
        /// 0x18 System.Collections.Generic.Dictionary.Entry<TKEY,TVALUE>[] _entries
        /// </summary>
        [FieldOffset(0x18)]
        public readonly PMonoArray _entries;

        /// <summary>
        /// 0x20 System.Collections.Generic.IEqualityComparer<TKEY> _comparer
        /// </summary>
        [FieldOffset(0x20)]
        public readonly nint _comparer;

        /// <summary>
        /// 0x28 System.Collections.Generic.Dictionary.KeyCollection<TKEY,TVALUE> _keys
        /// </summary>
        [FieldOffset(0x28)]
        public readonly nint _keys;

        /// <summary>
        /// 0x30 System.Collections.Generic.Dictionary.ValueCollection<TKEY,TVALUE> _values
        /// </summary>
        [FieldOffset(0x30)]
        public readonly nint _values;

        /// <summary>
        /// 0x38 System.Object _syncRoot
        /// </summary>
        [FieldOffset(0x38)]
        public readonly nint _syncRoot;

        /// <summary>
        /// 0x40 System.Int32 _count
        /// </summary>
        [FieldOffset(0x40)]
        public readonly System.Int32 _count;

        /// <summary>
        /// 0x44 System.Int32 _freeList
        /// </summary>
        [FieldOffset(0x44)]
        public readonly System.Int32 _freeList;


        /// <summary>
        /// 0x48 System.Int32 _freeCount
        /// </summary>
        [FieldOffset(0x48)]
        public readonly System.Int32 _freeCount;

        /// <summary>
        /// 0x4C System.Int32 _version
        /// </summary>
        [FieldOffset(0x4C)]
        public readonly System.Int32 _version;

    }

}
