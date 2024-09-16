//# raylib 4.0 bindings.   MPL 2.0 Licensed.  Source here: https://github.com/NotNotTech/Raylib-CsLo
//# Find Raylib+docs here:   https://github.com/raysan5/raylib/blob/master/src/raylib.h
//# This file, and it's containing folder are automatically generated.  Do not Modify.
using System.Runtime.CompilerServices;

namespace Raylib_CsLo
{
    public partial struct BoneInfo
    {
        [NativeTypeName("char[32]")]
        public _name_e__FixedBuffer name;

        public int parent;

        [InlineArray(32)]
        public partial struct _name_e__FixedBuffer
        {
            public sbyte e0;
        }
    }
}
