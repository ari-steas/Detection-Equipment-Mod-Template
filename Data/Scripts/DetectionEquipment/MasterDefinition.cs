using System.Collections.Generic;
using DetectionEquipment.BaseDefinitions;

namespace DetectionEquipment
{
    internal partial class DetectionDefinitions
    {
        internal readonly Dictionary<string, SensorDefinition> SensorDefinitions = new Dictionary<string, SensorDefinition>
        {
            // Your sensor definitions here.
        };

        internal readonly Dictionary<string, CountermeasureDefinition> CountermeasureDefinitions = new Dictionary<string, CountermeasureDefinition>
        {
            // Your countermeasure definitions here.
        };

        internal readonly Dictionary<string, CountermeasureEmitterDefinition> CountermeasureEmitterDefinitions = new Dictionary<string, CountermeasureEmitterDefinition>
        {
            // Your countermeasure emitter definitions here.
        };
    }
}
