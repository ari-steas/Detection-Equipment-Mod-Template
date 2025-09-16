using DetectionEquipment.BaseDefinitions;
using VRage.Game.Components;
using VRage.Utils;

namespace DetectionEquipment.Communication
{
    [MySessionComponentDescriptor(MyUpdateOrder.NoUpdate, DetectionDefinitions.LoadPriority)]
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
            foreach (var def in allDefinitions.SensorDefinitions)
            {
                DefinitionApi.RegisterDefinition(def.Name, def);
                var delegates = def.GenerateDelegates();
                if (delegates != null)
                    DefinitionApi.RegisterDelegates<SensorDefinition>(def.Name, delegates);
            }
            foreach (var def in allDefinitions.CountermeasureDefinitions)
            {
                DefinitionApi.RegisterDefinition(def.Name, def);
                var delegates = def.GenerateDelegates();
                if (delegates != null)
                    DefinitionApi.RegisterDelegates<CountermeasureDefinition>(def.Name, delegates);
            }
            foreach (var def in allDefinitions.CountermeasureEmitterDefinitions)
            {
                DefinitionApi.RegisterDefinition(def.Name, def);
                var delegates = def.GenerateDelegates();
                if (delegates != null)
                    DefinitionApi.RegisterDelegates<CountermeasureEmitterDefinition>(def.Name, delegates);
            }
            foreach (var def in allDefinitions.ControlBlockDefinitions)
            {
                DefinitionApi.RegisterDefinition(def.Name, def);
                var delegates = def.GenerateDelegates();
                if (delegates != null)
                    DefinitionApi.RegisterDelegates<ControlBlockDefinition>(def.Name, delegates);
            }
            DefinitionApi.LogInfo($"{ModContext.ModName} - Registered all definitions.");
        }
    }
}
