namespace SOLID.ISP.Violation
{
    internal class ABPrinterCodeSmell : IPrinterTasksCodeSmell
    {
        public bool Fax()
        {
            throw new NotImplementedException();
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
