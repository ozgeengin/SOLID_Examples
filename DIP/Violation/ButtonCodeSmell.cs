namespace SOLID.DIP.Violation
{
    internal class ButtonCodeSmell
    {
        private LampCodeSmell lamp;

        public bool TurnOn()
        {
            if(lamp != null)
            {
                return lamp.TurnOn();
            }

            return false;
        }
    }
}
