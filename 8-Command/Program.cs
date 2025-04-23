namespace Command
{
    using System;

    // Command interface
    public interface ICommand
    {
        void Execute();
    }

    // Receiver
    public class Light
    {
        public void TurnOn()
        {
            Console.WriteLine("Light is ON");
        }

        public void TurnOff()
        {
            Console.WriteLine("Light is OFF");
        }
    }

    // Concrete Command to turn on the light
    public class TurnOnLightCommand : ICommand
    {
        private Light _light;

        public TurnOnLightCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOn();
        }
    }

    // Concrete Command to turn off the light
    public class TurnOffLightCommand : ICommand
    {
        private Light _light;

        public TurnOffLightCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOff();
        }
    }

    // Invoker
    public class RemoteControl
    {
        private ICommand _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void PressButton()
        {
            _command.Execute();
        }
    }

    // Client
    class Program
    {
        static void Main()
        {
            Light light = new Light();

            ICommand turnOn = new TurnOnLightCommand(light);
            ICommand turnOff = new TurnOffLightCommand(light);

            RemoteControl remote = new RemoteControl();

            remote.SetCommand(turnOn);
            remote.PressButton(); // Output: Light is ON

            remote.SetCommand(turnOff);
            remote.PressButton(); // Output: Light is OFF
        }
    }

}
