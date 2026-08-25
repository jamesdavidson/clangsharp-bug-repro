using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace Bug.Windows.X64
{
    public partial struct QUIC_GLOBAL_SETTINGS
    {
        [NativeTypeName("__AnonymousRecord_bug_L4_C5")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("uint16_t")]
        public ushort RetryMemoryLimit;

        [NativeTypeName("uint16_t")]
        public ushort LoadBalancingMode;

        [NativeTypeName("uint32_t")]
        public uint FixedServerID;

        [UnscopedRef]
        public ref ulong IsSetFlags
        {
            get
            {
                return ref Anonymous.IsSetFlags;
            }
        }

        [UnscopedRef]
        public ref _Anonymous_e__Union._IsSet_e__Struct IsSet
        {
            get
            {
                return ref Anonymous.IsSet;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("uint64_t")]
            public ulong IsSetFlags;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_bug_L6_C9")]
            public _IsSet_e__Struct IsSet;

            public partial struct _IsSet_e__Struct
            {
                public ulong _bitfield;

                [NativeTypeName("uint64_t : 1")]
                public ulong RetryMemoryLimit
                {
                    readonly get
                    {
                        return _bitfield & 0x1UL;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~0x1UL) | (value & 0x1UL);
                    }
                }

                [NativeTypeName("uint64_t : 1")]
                public ulong LoadBalancingMode
                {
                    readonly get
                    {
                        return (_bitfield >> 1) & 0x1UL;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0x1UL << 1)) | ((value & 0x1UL) << 1);
                    }
                }

                [NativeTypeName("uint64_t : 1")]
                public ulong FixedServerID
                {
                    readonly get
                    {
                        return (_bitfield >> 2) & 0x1UL;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0x1UL << 2)) | ((value & 0x1UL) << 2);
                    }
                }

                [NativeTypeName("uint64_t : 61")]
                public ulong RESERVED
                {
                    readonly get
                    {
                        return (_bitfield >> 3) & 0x1FFFFFFFUL;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0x1FFFFFFFUL << 3)) | ((value & 0x1FFFFFFFUL) << 3);
                    }
                }
            }
        }
    }
}