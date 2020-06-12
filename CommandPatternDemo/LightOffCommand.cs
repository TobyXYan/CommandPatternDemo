
namespace CommandPatternDemo
{
    internal class LightOffCommand : ICommand
    {
        private Light _light;
        public LightOffCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.DoLightOff();
        }

        public void UnExecute()
        {
            _light.DoLightOn();
        }
    }
}
