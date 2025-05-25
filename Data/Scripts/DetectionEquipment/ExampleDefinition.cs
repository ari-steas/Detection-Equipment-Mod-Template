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
        private static SensorDefinition ExampleSensorDef => new SensorDefinition
        {
            Name = "ExampleSensorDef",

            BlockSubtypes = new[]
            {
                // These HAVE to be camera blocks for now.
                "LargeCameraBlock"
            },
            Type = SensorType.Radar,
            MaxAperture = MathHelper.ToRadians(45),
            MinAperture = MathHelper.ToRadians(35),
            Movement = null,

            DetectionThreshold = 30,
            BearingErrorModifier = 1,
            RangeErrorModifier = 1,

            MaxPowerDraw = 25000,
            RadarProperties = new RadarPropertiesDefinition
            {
                ReceiverArea = 1,
                PowerEfficiencyModifier = 0.00000000000000025,
                Bandwidth = 1.67E6,
                Frequency = 2800E6,
            }
        };
    }
}
