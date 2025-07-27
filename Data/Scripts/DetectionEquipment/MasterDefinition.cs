using DetectionEquipment.BaseDefinitions;

namespace DetectionEquipment
{
    internal partial class DetectionDefinitions
    {
        /// <summary>
        /// Definition loading priority.
        /// Lower numbers load first; to override another mod, set this to a higher value than the other mod.
        /// DetEq internal definitions have minimum priority, and will always be overriden if possible.
        /// </summary>
        internal const int LoadPriority = int.MinValue + 1;

        internal readonly SensorDefinition[] SensorDefinitions = new SensorDefinition[]
        {
            // Your sensor definitions here.
            ExampleSensorDef,
            ExampleSensorOverride,
        };

        internal readonly CountermeasureDefinition[] CountermeasureDefinitions = new CountermeasureDefinition[]
        {
            // Your countermeasure definitions here.
            ExampleCountermeasureDef,
        };

        internal readonly CountermeasureEmitterDefinition[] CountermeasureEmitterDefinitions = new CountermeasureEmitterDefinition[]
        {
            // Your countermeasure emitter definitions here.
            ExampleCountermeasureEmitterDef,
        };
    }
}
