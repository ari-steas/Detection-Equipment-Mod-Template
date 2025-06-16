using System;
using DetectionEquipment.BaseDefinitions;
using VRageMath;
using static DetectionEquipment.BaseDefinitions.CountermeasureDefinition;
using static DetectionEquipment.BaseDefinitions.CountermeasureEmitterDefinition;
using static DetectionEquipment.BaseDefinitions.SensorDefinition;

namespace DetectionEquipment
{
    internal partial class DetectionDefinitions
    {
        // Hover over field names or look at the base definition for more information.
        private static CountermeasureEmitterDefinition ExampleCountermeasureEmitterDef => new CountermeasureEmitterDefinition
        {
            Name = "ExampleCountermeasureEmitterDef",

            BlockSubtypes = new[]
            {
                // These HAVE to be conveyor sorters.
                "SimpleJammer",
            },
            Muzzles = new[]
            {
                "muzzle",
            },
            CountermeasureIds = new[]
            {
                "DetEq_SimpleAreaJammer",
            },
            IsCountermeasureAttached = true,
            ShotsPerSecond = 60,
            MagazineSize = 0,
            ReloadTime = 0,
            MagazineItem = null,
            EjectionVelocity = 0,
            FireParticle = null,
            ActivePowerDraw = 10,
            InventorySize = 0,
        };
    }
}
