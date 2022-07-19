namespace SOLID.ISP.Violation
{
    internal class HPPrinterCodeSmell : IPrinterTasksCodeSmell
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
