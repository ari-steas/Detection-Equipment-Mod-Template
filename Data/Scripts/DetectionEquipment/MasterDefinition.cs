using DetectionEquipment.BaseDefinitions;

namespace DetectionEquipment
{
    internal partial class DetectionDefinitions
    {
        internal readonly SensorDefinition[] SensorDefinitions = new SensorDefinition[]
        {
            // Your sensor definitions here.
            ExampleSensorDef,
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
