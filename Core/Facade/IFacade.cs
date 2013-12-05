namespace Core.Facade
{
    public class SystemFacade
    {
        private readonly SubSystemOne _one;
        private readonly SubSystemTwo _two;
        private readonly SubSystemThree _three;
        private readonly SubSystemFour _four;

        public SystemFacade()
        {
            _one = new SubSystemOne();
            _two = new SubSystemTwo();
            _three = new SubSystemThree();
            _four = new SubSystemFour();
        }

        public void LaunchA()
        {
            _one.Launch();
            _two.Launch();
        }

        public void LaunchB()
        {
            _three.Launch();
            _four.Launch();
        }
    }
}