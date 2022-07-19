namespace SOLID.SRP.Violation
{
    internal class OrderServiceCodeSmell : IOrderServiceCodeSmell
    {
        public string CreateOrder()
        {
            return "";
        }

        public bool MakePayment(string orderId)
        {
            return true;
        }

        public bool GenerateInvoice(string orderId)
        {
            return true;
        }

        public bool EmailInvoice(string orderId)
        {
            return true;
        }
    }
}
