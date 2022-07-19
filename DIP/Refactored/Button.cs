namespace SOLID.DIP.Refactored
{
    internal class Button
    {
        private IDevice device;

        public bool TurnOn()
        {
            if (device != null)
            {
                return device.TurnOn();
            }

            return false;
        }
    }
}
