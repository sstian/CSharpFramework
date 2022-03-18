using System;

namespace DelegateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProductFactory productFactory = new ProductFactory();
            PizzaFactory pizzaFactory = new PizzaFactory();
            ToyCarFactory toyCarFactory = new ToyCarFactory();
            WrapFactory wrapFactory = new WrapFactory();

            //Func<Product> pizzaFunc = new Func<Product>(productFactory.MakePiza);
            //Func<Product> toyCarFunc = new Func<Product>(productFactory.MakeToyCar);

            //Logger logger = new Logger();
            //Action<Product> logAction = new Action<Product>(logger.Log);
            //Box pizzaBox = wrapFactory.WrapProduct(pizzaFunc, logAction);
            //Box toyCarBox = wrapFactory.WrapProduct(toyCarFunc, logAction);

            Box pizzaBox = wrapFactory.WrapProduct(pizzaFactory);
            Box toyCarBox = wrapFactory.WrapProduct(toyCarFactory);

            Console.WriteLine(pizzaBox.Product.Name);
            Console.WriteLine(toyCarBox.Product.Name);
            //// Product 'ToyCar' created at 2021-12-19 14:42:16, price is 100.
            // Pizza
            // ToyCar
        }
    }

    class Logger
    {
        public void Log(Product product)
        {
            Console.WriteLine("Product '{0}' created at {1}, price is {2}.", 
                product.Name, DateTime.UtcNow, product.Price);
        }
    }

    interface IProductFactory
    {
        Product Make();
    }

    class PizzaFactory : IProductFactory
    {
        public Product Make()
        {
            Product product = new Product();
            product.Name = "Pizza";
            product.Price = 12;
            return product;
        }
    }

    class ToyCarFactory : IProductFactory
    {
        public Product Make()
        {
            Product product = new Product();
            product.Name = "ToyCar";
            product.Price = 100;
            return product;
        }
    }

    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }

    class Box
    {
        public Product Product { get; set; }
    }

    class WrapFactory
    {
        // 模板方法 + 回调方法
        //public Box WrapProduct(Func<Product> getProduct, Action<Product> logCallback)
        //{
        //    Box box = new Box();
        //    Product product = getProduct.Invoke();
        //    if (product.Price >= 50)
        //    {
        //        logCallback.Invoke(product);
        //    }
        //    box.Product = product;
        //    return box;
        //}

        public Box WrapProduct(IProductFactory productFactory)
        {
            Box box = new Box();
            Product product = productFactory.Make();
            box.Product = product;
            return box;
        }
    }

    //class ProductFactory
    //{
    //    public Product MakePiza()
    //    {
    //        Product product = new Product();
    //        product.Name = "Pizza";
    //        product.Price = 12;
    //        return product;
    //    }

    //    public Product MakeToyCar()
    //    {
    //        Product product = new Product();
    //        product.Name = "ToyCar";
    //        product.Price = 100;
    //        return product;
    //    }
    //}
}
