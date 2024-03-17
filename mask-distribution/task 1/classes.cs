using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        class CustomerManager
        {
            public void Add()
            {
                //Customer Added. 
            }
            public void Update()
            {
                //Customer Updated. 
            }

        }  class ProductManager
        {
            public void Add()
            {
                //Product Added. 
            }
            public void Update()
            {
                //Product Updated. 
            }

        }
        static void Main(string[] args)
        {
            //classes.

            CustomerManager customerManager = new CustomerManager(); // an reference is created on heap.
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager(); // an reference is created on heap.
            productManager.Add();
            productManager.Update();
        }
    }
}

