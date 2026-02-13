using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayFour.ObjectOriented
{
    /// <summary>
    /// Demonstrates Read-Only Properties.
    /// </summary>
    class Supplier
    {
        int _supplierId;
        string _supplierName;

        Supplier() { }
        public Supplier(int id, string name)
        {
            this._supplierId = id;
            this._supplierName = name;
        }  
        
        public int SupplierId { get { return _supplierId; } } 
        public string SupplierName { get { return _supplierName; } }
    }

    internal class ReadOnlyPropertyDemo
    {
        static void Main()
        {
            Supplier supplier = new Supplier(1, "FoodDeliveryService");
            Console.WriteLine(supplier.SupplierId);
            Console.WriteLine(supplier.SupplierName);
        }
    }
}
