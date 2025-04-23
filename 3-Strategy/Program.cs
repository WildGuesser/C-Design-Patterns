namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int order = 100;
            PaymentService paymentService = new PaymentService(order, true);

            //CreditCard Payment
            CreditCard creditCard = new CreditCard("1111-222-333");
            IPaymentStrategy creditCardPayment = new CreditCardStrategy(creditCard);
            paymentService.ProcessOrder(creditCardPayment);

            //CreditCard Payment
            PayPal paypal = new PayPal("jose@avanade.com");
            IPaymentStrategy paypalPayment = new PayPalStrategy(paypal);
            paymentService.ProcessOrder(paypalPayment);

        }
    }
}
