namespace Core.Command
{
    public class RemoteControl
    {
        private ICommand _command;

        public ICommand Command
        {
            set { _command = value; }
        }

        public void PressButton()
        {
            _command.Execute();
        }
    }
}