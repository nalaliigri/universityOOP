/* Task:
   Використовуючи паттерн Facade створити додаток для розміщення замовлення.
   Cистемами будуть класи «Product», «Payment» та «Invoice», і кожен клас повинен мати відповідну реалізацію.
*/


using System;
namespace FacadeDesignPattern
{

    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            order.PlaceOrder();
            Console.Read();
        }
    }
    public class Product
    {
        public void GetProductDetails()
        {
            Console.WriteLine("Fetching the product details");
        }
    }

    public class Payment
    {
        public void MakePayment()
        {
            Console.WriteLine("Payment done successfully");
        }
    }

    public class Invoice
    {
        public void Sendinvoice()
        {
            Console.WriteLine("Invoice send successfully");
        }
    }
    public class Order
    {
        public void PlaceOrder()
        {
            Console.WriteLine("Place order started");
            Product product = new Product();
            product.GetProductDetails();
            Payment payment = new Payment();
            payment.MakePayment();
            Invoice invoice = new Invoice();
            invoice.Sendinvoice();
            Console.WriteLine("Order placed successfully");
        }
    }
}
