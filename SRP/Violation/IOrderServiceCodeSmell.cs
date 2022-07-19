namespace SOLID.SRP.Violation
{
    internal interface IOrderServiceCodeSmell
    {
        string CreateOrder();
        bool MakePayment(string orderId);
        bool GenerateInvoice(string orderId);
        bool EmailInvoice(string orderId);
    }
}
