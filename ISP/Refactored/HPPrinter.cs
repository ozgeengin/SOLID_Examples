namespace SOLID.ISP.Refactored
{
    internal class HPPrinter : IPrinterTasks, IFaxTasks
    {
        public bool Fax()
        {
            return true;
        }

        public bool Print()
        {
            return true;
        }

        public bool Scan()
        {
            return true;
        }
    }
}
