using Maple.MonoGameAssistant.Core;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

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

    partial struct Ref_MonoDictionary_BeastSaga : IRefMonoDictionary
    {
        public int Count => _count;

        public int FreeCount => _freeCount;

        public PMonoArray Entries => _entries;


        public int Size => Count - FreeCount;

    }


    [StructLayout(LayoutKind.Sequential)]
    public readonly unsafe partial struct PMonoDictionary_BeastSaga<T_KEY, T_VALUE>(nint ptr) : IPtrMonoDictionary<Ref_MonoDictionary_BeastSaga, T_KEY, T_VALUE, Ref_MonoEntry<T_KEY, T_VALUE>>
        where T_KEY : unmanaged
        where T_VALUE : unmanaged
    {

        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator PMonoDictionary_BeastSaga<T_KEY, T_VALUE>(nint ptr) => new(ptr);
        public static implicit operator nint(PMonoDictionary_BeastSaga<T_KEY, T_VALUE> obj) => obj._ptr;

        public override string ToString()
        {
            return _ptr.ToString("X8");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Valid() => _ptr != nint.Zero;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref Ref_MonoDictionary_BeastSaga AsRef() => ref _ptr.AsRefStruct<Ref_MonoDictionary_BeastSaga>();

        public PMonoEntry<Ref_MonoEntry<T_KEY, T_VALUE>, T_KEY, T_VALUE>[] AsRefArray()
            => this.AsRefArray<PMonoDictionary_BeastSaga<T_KEY, T_VALUE>, Ref_MonoDictionary_BeastSaga, T_KEY, T_VALUE, Ref_MonoEntry<T_KEY, T_VALUE>>();


    }

}
