
namespace CommandPatternDemo
{
    internal class LightOnCommand : ICommand
    {
        private Light _light;
        public LightOnCommand(Light light)
        {
            _light = light;
        }
        public void Execute()
        {
            _light.DoLightOn();
        }

        public void UnExecute()
        {
            _light.DoLightOff();
        }
    }
}
