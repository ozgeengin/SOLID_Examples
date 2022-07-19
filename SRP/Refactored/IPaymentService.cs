namespace SOLID.SRP.Refactored
{
    internal interface IPaymentService
    {
        bool MakePayment(string orderId);
    }
}
