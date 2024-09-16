//# raylib 4.0 bindings.   MPL 2.0 Licensed.  Source here: https://github.com/NotNotTech/Raylib-CsLo
//# Find Raylib+docs here:   https://github.com/raysan5/raylib/blob/master/src/raylib.h
//# This file, and it's containing folder are automatically generated.  Do not Modify.
using System.Runtime.CompilerServices;

namespace Raylib_CsLo
{
    public partial struct rresResourceChunkInfo
    {
        [NativeTypeName("unsigned char[4]")]
        public _type_e__FixedBuffer type;

        [NativeTypeName("unsigned int")]
        public uint id;

        [NativeTypeName("unsigned char")]
        public byte compType;

        [NativeTypeName("unsigned char")]
        public byte cipherType;

        [NativeTypeName("unsigned short")]
        public ushort flags;

        [NativeTypeName("unsigned int")]
        public uint packedSize;

        [NativeTypeName("unsigned int")]
        public uint baseSize;

        [NativeTypeName("unsigned int")]
        public uint nextOffset;

        [NativeTypeName("unsigned int")]
        public uint reserved;

        [NativeTypeName("unsigned int")]
        public uint crc32;

        [InlineArray(4)]
        public partial struct _type_e__FixedBuffer
        {
            public byte e0;
        }
    }
}
