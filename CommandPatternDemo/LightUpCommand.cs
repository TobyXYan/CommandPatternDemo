
namespace CommandPatternDemo
{
    internal class LightUpCommand : ICommand
    {
        private Light _light;
        public LightUpCommand(Light light)
        {
            _light = light;
        }
        public void Execute()
        {
            _light.DoLightUp();
        }

        public void UnExecute()
        {
            _light.DoLightDown();
        }
    }
}
