//# raylib 4.0 bindings.   MPL 2.0 Licensed.  Source here: https://github.com/NotNotTech/Raylib-CsLo
//# Find Raylib+docs here:   https://github.com/raysan5/raylib/blob/master/src/raylib.h
//# This file, and it's containing folder are automatically generated.  Do not Modify.
using System.Runtime.CompilerServices;

namespace Raylib_CsLo
{
    public unsafe partial struct Material
    {
        public Shader shader;

        public MaterialMap* maps;

        [NativeTypeName("float[4]")]
        public _params_e__FixedBuffer @params;

        [InlineArray(4)]
        public partial struct _params_e__FixedBuffer
        {
            public float e0;
        }
    }
}
