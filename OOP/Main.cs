using AngleSharp.Dom;
using Microsoft.Graph;
using OfficeDevPnP.Core.Diagnostics.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            ITransactionStorage storage = new TransactionStorage();

            // Adding a product using Singleton ProductManager
            Product product1 = new Product
            {
                ProductID = 1,
                Name = "Product A",
                Description = "Description of Product A",
                Price = 10.99,
                Stock = 100,
                CreatedAt = DateTime.Now,
                ShopID = 1
            };

            ProductManager.Instance.AddProduct(product1);

            // Retrieving products
            var products = ProductManager.Instance.GetProducts();
            foreach (var product in products)
            {
                Console.WriteLine($"ID: {product.ProductID}, Name: {product.Name}, Price: {product.Price}");
            }

            // Using the TransactionFactory to create an Order and ShoppingCart
            Transaction newOrder = TransactionFactory.CreateTransaction("Order");
            Transaction cart = TransactionFactory.CreateTransaction("ShoppingCart");

            // Save the newly created Order
            storage.SaveTransaction(newOrder);

            // Save the newly created ShoppingCart
            storage.SaveTransaction(cart);
        }
    }
}
