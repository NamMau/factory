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
        // Factory Method to create transaction (Order hoặc ShoppingCart)
        public static Transaction CreateTransaction(string transactionType)
        {
            switch (transactionType)
            {
                case "Order":
                    return new Order
                    {
                        ID = 2,
                        CustomerID = 2,
                        TotalAmount = 50.00,
                        OrderStatus = "Completed",
                        PaymentStatus = "Unpaid",
                        PaymentMethodID = 2,
                        OverDueDate = DateTime.Now.AddDays(7),
                        PaidAt = DateTime.Now,
                        DeliveryStatus = "Shipped",
                        ShippingProviderID = 2
                    };
                case "ShoppingCart":
                    return new ShoppingCart
                    {
                        ID = 3,
                        CustomerID = 123,
                        TotalAmount = 150.00,
                        CreatedAt = DateTime.Now,
                        Items = new List<CartProduct>
                    {
                        new CartProduct { ProductID = 1, Quantity = 2 },
                        new CartProduct { ProductID = 2, Quantity = 1 }
                    }
                    };
                default:
                    throw new ArgumentException("Invalid transaction type");
            }
        }
    }

}