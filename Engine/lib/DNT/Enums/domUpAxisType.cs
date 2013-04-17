using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinterLeaf.Enums
    {
    public enum domUpAxisType
        {
        UPAXISTYPE_X_UP,
        UPAXISTYPE_Y_UP,
        UPAXISTYPE_Z_UP,
        UPAXISTYPE_COUNT = 3
        };

    enum TSStatic__MaskBits : uint
        {
        InitialUpdateMask = 0x00000000,
        ScaleMask = 0x00000001,
        FlagMask = 0x00000002,
        MountedMask = 0x00000004,
        TransformMask = 0x00000008,
        AdvancedStaticOptionsMask = 0x00000010,
        UpdateCollisionMask = 0x00000020,
        SkinMask = 0x00000040,
        LightObjectType = 0x00000080
        };

    
    }

