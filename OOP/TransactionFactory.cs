using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public static class TransactionFactory
    {
        public static Transaction CreateTransaction(string transactionType)
        {
            
            return transactionType switch
            {
                "Order" => new Order
                {
                    ID = 1,
                    CustomerID = 101,
                    TotalAmount = 150.75,
                    OrderStatus = "Pending",
                    PaymentStatus = "Unpaid",
                    PaymentMethodID = 2,
                    OverDueDate = DateTime.Now.AddDays(5),
                    DeliveryStatus = "Awaiting shipment",
                    ShippingProviderID = 1
                },
                "ShoppingCart" => new ShoppingCart
                {
                    ID = 2,
                    CustomerID = 202,
                    TotalAmount = 89.50,
                    CreatedAt = DateTime.Now,
                    Items = new List<CartProduct>
                    {
                        new CartProduct { ProductID = 1, Quantity = 2 },
                        new CartProduct { ProductID = 2, Quantity = 3 }
                    }
                },
                _ => throw new ArgumentException("Invalid transaction type.")
            };
        }
    }
}