using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace B9AirBrake
{
    public class B9AirBrake : ModuleAeroSurface
    {
        new void Start()
        {
            base.Start();

            base.ignorePitch = true;
            base.ignoreYaw = true;

            Fields["ignorePitch"].guiActive = false;
            Fields["ignorePitch"].guiActiveEditor = false;

            Fields["ignoreYaw"].guiActive = false;
            Fields["ignoreYaw"].guiActiveEditor = false;

            Fields["aeroAuthorityLimiter"].guiActive = false;
            Fields["aeroAuthorityLimiter"].guiActiveEditor = false;
        }

        new void LateUpdate()
        {
            base.LateUpdate();

            // These two fields are not visible in the Start(), so need to be set here
            Fields["deploy"].guiActive = false;
            Fields["deploy"].guiActiveEditor = false;
        }
    }
}
