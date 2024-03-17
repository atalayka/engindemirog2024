using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        //interfaces 2.

        public interface ICustomerDal
        {
            public void Add();
            public void Update();
            public void Delete();
        }

        public class SqlServerCustomerDal : ICustomerDal
        {
            public void Add()
            {
                Console.WriteLine("sql added");
            }

            public void Delete()
            {
                Console.WriteLine("sql deleted");
            }

            public void Update()
            {
                Console.WriteLine("sql updated");
            }
        }

        public class OracleCustomerDal : ICustomerDal
        {
            public void Add()
            {
                Console.WriteLine("oracle added");
            }

            public void Delete()
            {
                Console.WriteLine("oracle deleted");
            }

            public void Update()
            {
                Console.WriteLine("oracle updated");
            }
        }

        public class CustomerManager
        {
            public void Add(ICustomerDal customerDal)
            {
                customerDal.Add();
            }
            public void Delete(ICustomerDal customerDal)
            {
                customerDal.Add();
            }
            public void Update(ICustomerDal customerDal)
            {
                customerDal.Add();
            }
        }
        static void Main(string[] args)
        {
            CustomerManager manager = new CustomerManager();
            manager.Add(new SqlServerCustomerDal());
            manager.Add(new OracleCustomerDal());
        }
    }
}

