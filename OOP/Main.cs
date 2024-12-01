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

            var transactionFacade = new TransactionFacade();

            Console.WriteLine("Saving Order...");
            transactionFacade.SaveTransaction("Order"); // Save Order

            Console.WriteLine("Saving ShoppingCart...");
            transactionFacade.SaveTransaction("ShoppingCart"); // Save ShoppingCart
        }
    }
}