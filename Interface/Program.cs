using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Program
    {
        static void Main(string[] args)
        {
            IWaiter waiter = new Server();
            waiter.ServeDish();
            waiter.TakeOrder();
            waiter.CollectPayment();

            IChef chef = new Chef();
            chef.PrepareFood();
            chef.PlateFood();
        }
    }
}

public interface IWaiter
{
    void TakeOrder();
    void ServeDish();
    void CollectPayment();
}
public interface IChef
{
    void PrepareFood();
    void PlateFood();
}

public class Server : IWaiter
{
    public void CollectPayment()
    {
        Console.WriteLine("Ödeme alındı.");
    }

    public void ServeDish()
    {
        Console.WriteLine("Yemek servis edildi.");
    }

    public void TakeOrder()
    {
        Console.WriteLine("Sipariş alındı.");
    }
}
public class Chef : IChef
{
    public void PlateFood()
    {
        Console.WriteLine("Yemek sunuma hazır.");
    }

    public void PrepareFood()
    {
        Console.WriteLine("Yemek hazırlanıyor.");
    }
}