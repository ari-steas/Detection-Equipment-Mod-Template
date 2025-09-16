using System;
using DetectionEquipment.BaseDefinitions;
using VRageMath;
using static DetectionEquipment.BaseDefinitions.CountermeasureDefinition;
using static DetectionEquipment.BaseDefinitions.CountermeasureEmitterDefinition;
using static DetectionEquipment.BaseDefinitions.SensorDefinition;
using static DetectionEquipment.BaseDefinitions.ControlBlockDefinition;

namespace DetectionEquipment
{
    internal partial class DetectionDefinitions
    {
        // Hover over field names or look at the base definition for more information.
        private static ControlBlockDefinition ExampleControlBlockDef => new ControlBlockDefinition
        {
            Name = "ExampleControlDef",

            SubtypeIds = new[]
            {
                // These HAVE to be conveyor sorters. Do not put multiple on one block.
                "YourSubtypeHere"
            },
            Type = LogicType.IffReflector,
        };
    }
}
