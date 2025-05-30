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
        private static CountermeasureDefinition ExampleCountermeasureDef => new CountermeasureDefinition
        {
            Name = "ExampleCountermeasureDef",

            CountermeasureType = CountermeasureDefinition.CountermeasureTypeEnum.Radar,
            MaxRange = 50000,
            FalloffScalar = 1.0E12f,
            MinNoise = 0f,
            FalloffType = CountermeasureDefinition.FalloffTypeEnum.Quadratic,
            MinEffectAperture = (float) Math.PI,
            MaxEffectAperture = (float) Math.PI,
            MaxLifetime = uint.MaxValue,
            HasPhysics = false,
            DragMultiplier = 0f,
            ParticleEffect = null
        };
    }
}
