//# raylib 4.0 bindings.   MPL 2.0 Licensed.  Source here: https://github.com/NotNotTech/Raylib-CsLo
//# Find Raylib+docs here:   https://github.com/raysan5/raylib/blob/master/src/raylib.h
//# This file, and it's containing folder are automatically generated.  Do not Modify.
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Raylib_CsLo
{
    public partial struct VrStereoConfig
    {
        [NativeTypeName("Matrix[2]")]
        public _projection_e__FixedBuffer projection;

        [NativeTypeName("Matrix[2]")]
        public _viewOffset_e__FixedBuffer viewOffset;

        [NativeTypeName("float[2]")]
        public _leftLensCenter_e__FixedBuffer leftLensCenter;

        [NativeTypeName("float[2]")]
        public _rightLensCenter_e__FixedBuffer rightLensCenter;

        [NativeTypeName("float[2]")]
        public _leftScreenCenter_e__FixedBuffer leftScreenCenter;

        [NativeTypeName("float[2]")]
        public _rightScreenCenter_e__FixedBuffer rightScreenCenter;

        [NativeTypeName("float[2]")]
        public _scale_e__FixedBuffer scale;

        [NativeTypeName("float[2]")]
        public _scaleIn_e__FixedBuffer scaleIn;

        [InlineArray(2)]
        public partial struct _projection_e__FixedBuffer
        {
            public Matrix4x4 e0;
        }

        [InlineArray(2)]
        public partial struct _viewOffset_e__FixedBuffer
        {
            public Matrix4x4 e0;
        }

        [InlineArray(2)]
        public partial struct _leftLensCenter_e__FixedBuffer
        {
            public float e0;
        }

        [InlineArray(2)]
        public partial struct _rightLensCenter_e__FixedBuffer
        {
            public float e0;
        }

        [InlineArray(2)]
        public partial struct _leftScreenCenter_e__FixedBuffer
        {
            public float e0;
        }

        [InlineArray(2)]
        public partial struct _rightScreenCenter_e__FixedBuffer
        {
            public float e0;
        }

        [InlineArray(2)]
        public partial struct _scale_e__FixedBuffer
        {
            public float e0;
        }

        [InlineArray(2)]
        public partial struct _scaleIn_e__FixedBuffer
        {
            public float e0;
        }
    }
}
