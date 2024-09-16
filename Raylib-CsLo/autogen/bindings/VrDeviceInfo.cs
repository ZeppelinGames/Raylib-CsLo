//# raylib 4.0 bindings.   MPL 2.0 Licensed.  Source here: https://github.com/NotNotTech/Raylib-CsLo
//# Find Raylib+docs here:   https://github.com/raysan5/raylib/blob/master/src/raylib.h
//# This file, and it's containing folder are automatically generated.  Do not Modify.
using System.Runtime.CompilerServices;

namespace Raylib_CsLo
{
    public partial struct VrDeviceInfo
    {
        public int hResolution;

        public int vResolution;

        public float hScreenSize;

        public float vScreenSize;

        public float vScreenCenter;

        public float eyeToScreenDistance;

        public float lensSeparationDistance;

        public float interpupillaryDistance;

        [NativeTypeName("float[4]")]
        public _lensDistortionValues_e__FixedBuffer lensDistortionValues;

        [NativeTypeName("float[4]")]
        public _chromaAbCorrection_e__FixedBuffer chromaAbCorrection;

        [InlineArray(4)]
        public partial struct _lensDistortionValues_e__FixedBuffer
        {
            public float e0;
        }

        [InlineArray(4)]
        public partial struct _chromaAbCorrection_e__FixedBuffer
        {
            public float e0;
        }
    }
}
