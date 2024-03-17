using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        //interfaces supported polymorphism.

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
        public class MySqlCustomerDal : ICustomerDal
        {
            public void Add()
            {
                Console.WriteLine("Mysql added");
            }

            public void Delete()
            {
                Console.WriteLine("Mysql deleted");
            }

            public void Update()
            {
                Console.WriteLine("Mysql updated");
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
            ICustomerDal[] customerDals = new ICustomerDal[3]{
            new SqlServerCustomerDal(),
            new OracleCustomerDal(),
            new MySqlCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

        }
    }
}

