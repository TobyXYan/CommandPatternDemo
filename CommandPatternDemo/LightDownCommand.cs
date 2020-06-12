
namespace CommandPatternDemo
{
    internal class LightDownCommand : ICommand
    {
        private Light _light;
        public LightDownCommand(Light light)
        {
            _light = light;
        }
        public void Execute()
        {
            _light.DoLightDown();
        }

        public void UnExecute()
        {
            _light.DoLightUp();
        }
    }
}
