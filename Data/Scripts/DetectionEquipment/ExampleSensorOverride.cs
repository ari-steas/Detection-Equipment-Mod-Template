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
        private static SensorDefinition ExampleSensorOverride => new SensorDefinition
        {
            // To override a definition, ensure the Name field is identical and set a higher priority in MasterDefinition.cs.
            // This overrides the DetEq internal vanilla camera definition.
            Name = "DetEq_VanillaCamera",

            BlockSubtypes = new[]
            {
                "LargeCameraBlock",
                "LargeCameraTopMounted",
                "SmallCameraBlock",
                "SmallCameraTopMounted",
            },
            Type = SensorType.Infrared,
            MaxAperture = Math.PI/2,
            MinAperture = Math.PI/16,
            DetectionThreshold = 0.00001,
            BearingErrorModifier = 0.05,
            RangeErrorModifier = 0.05,
            MaxPowerDraw = -1,
            Movement = null,
        };
    }
}
