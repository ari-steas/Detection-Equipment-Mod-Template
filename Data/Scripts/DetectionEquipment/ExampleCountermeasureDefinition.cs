using DetectionEquipment.BaseDefinitions;
using System;
using System.Collections.Generic;
using Sandbox.ModAPI;
using VRage;
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

            CountermeasureType = CountermeasureTypeEnum.Radar,
            MaxRange = 50000,
            FalloffScalar = 1.0E12f,
            MinNoise = 0f,
            FalloffType = FalloffTypeEnum.Quadratic,
            MinEffectAperture = (float) Math.PI,
            MaxEffectAperture = (float) Math.PI,
            MaxLifetime = uint.MaxValue,
            HasPhysics = false,
            DragMultiplier = 0f,
            ParticleEffect = null,

            ApplyDrfmToOtherTargets = true,
            MaxDrfmRange = 50000,
            ApplyOutsideSensorCone = false,
            DrfmEffects = (sensorId, counterId, emitter, targetId, targetCrossSection, targetRange, maxRangeErr, targetBearing, maxBearingErr, iffCodes) =>
            {
                MyAPIGateway.Utilities.ShowNotification($"DrfmEffects: {sensorId} {counterId} {emitter?.CustomName ?? "NULLEMM"}, {targetId}, {targetCrossSection}, {targetRange}, {maxRangeErr}, {targetBearing}, {maxBearingErr}, {iffCodes.Length}", 1000/60);
                return new MyTuple<double, double, double, Vector3D, double, string[]>(0, 0, 0, targetBearing, 0, iffCodes);
            },
            DrfmGenerator = (sensorId, sensorBlock, counterId, emitter) =>
            {
                return new[]
                {
                    new MyTuple<long, double, Vector2D, Vector3D, double, string[]>(100, 500, Vector2D.UnitX * 500, Vector3D.Forward, 0, Array.Empty<string>())
                };
            }
        };
    }
}
