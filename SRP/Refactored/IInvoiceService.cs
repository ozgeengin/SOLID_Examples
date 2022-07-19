namespace SOLID.SRP.Refactored
{
    internal interface IInvoiceService
    {
        bool GenerateInvoice(string orderId);
    }
}
