using VRage.Game.Components;
using VRage.Utils;

namespace DetectionEquipment.Communication
{
    [MySessionComponentDescriptor(MyUpdateOrder.NoUpdate)]
    // ReSharper disable once UnusedType.Global
    internal class DefinitionCollector : MySessionComponentBase
    {
        internal DefinitionApi DefinitionApi = new DefinitionApi();

        public override void LoadData()
        {
            MyLog.Default.WriteLineAndConsole($"{ModContext.ModName} - Preparing DefinitionApi.");
            DefinitionApi.Init(ModContext, OnDefApiReady);
        }

        protected override void UnloadData()
        {
            DefinitionApi.UnloadData();
            MyLog.Default.WriteLineAndConsole($"{ModContext.ModName} - DefinitionApi unloaded.");
        }

        private void OnDefApiReady()
        {
            var allDefinitions = new DetectionDefinitions();
            foreach (var sensorDef in allDefinitions.SensorDefinitions)
                DefinitionApi.RegisterDefinition(ModContext.ModName + "_" + sensorDef.Key, sensorDef.Value);
            foreach (var counterDef in allDefinitions.CountermeasureDefinitions)
                DefinitionApi.RegisterDefinition(ModContext.ModName + "_" + counterDef.Key, counterDef.Value);
            foreach (var counterEDef in allDefinitions.CountermeasureEmitterDefinitions)
                DefinitionApi.RegisterDefinition(ModContext.ModName + "_" + counterEDef.Key, counterEDef.Value);
            DefinitionApi.LogInfo($"{ModContext.ModName} - Registered all definitions.");
        }
    }
}
