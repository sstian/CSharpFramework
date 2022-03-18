using System;
using System.Threading;

namespace EventCustom
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Waiter waiter = new Waiter();
            customer.Order += waiter.Action;
            customer.Action();
            customer.PayTheBill();
        }
    }

    public class OrderEventArgs : EventArgs
    {
        public string DishName { get; set; }
        public string Size { get; set; }
    }

    // 1, 2
    // public delegate void OrderEventHander(Customer customer, OrderEventArgs e);

    public class Customer
    {
        // 1
        //private OrderEventHander orderEventHander;
        //public event OrderEventHander Order
        //{
        //    add { this.orderEventHander += value; }
        //    remove { this.orderEventHander -= value; }
        //}

        // 2
        //public event OrderEventHander Order;

        // 3
        public event EventHandler Order;

        public double Bill { get; set; }

        public void WalkIn()
        {
            Console.WriteLine("Walk into the restaurant.");
        }

        public void SitDown()
        {
            Console.WriteLine("Sit down.");
        }

        public void Think()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Let me think...");
                Thread.Sleep(1000);
            }

            OrderEventArgs e = new OrderEventArgs();
            e.DishName = "Gongbao Chicken";
            e.Size = "large";
            this.OnOrder(e);
        }

        protected void OnOrder(OrderEventArgs e)
        {
            // 1
            //if (this.orderEventHander != null)
            //{
            //    this.orderEventHander.Invoke(this, e);
            //}

            // 2, 3
            if (this.Order != null)
            {
                this.Order.Invoke(this, e);
            }
        }

        public void Action()
        {
            Console.ReadLine();
            this.WalkIn();
            this.SitDown();
            this.Think();
        }

        public void PayTheBill()
        {
            Console.WriteLine("Customer.PayTheBill: I will pay {0}", this.Bill);
        }
    }

    public class Waiter
    {
        // 1, 2
        //public void Action(Customer customer, OrderEventArgs e)
        // 3
        public void Action(object sender, EventArgs e)
        {
            // 3
            Customer customer = sender as Customer;
            OrderEventArgs orderInfo = e as OrderEventArgs;

            Console.WriteLine("Waiter.Action: I will serve you the dish - ${0}", orderInfo.DishName);
            double price = 10;
            switch(orderInfo.Size)
            {
                case "small": price *= 0.5; break;
                case "large": price *= 1.5; break;
                default: break;
            }
            customer.Bill += price;
        }
    }
}
