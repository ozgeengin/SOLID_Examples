namespace SOLID.SRP.Refactored
{
    internal interface IEmailService
    {
        bool EmailInvoice(string orderId);
    }
}
