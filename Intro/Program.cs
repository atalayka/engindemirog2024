
using Intro.Business;
using Intro.DataAccess.Concretes;
using Intro.Entities;

CourseManager courseManager = new(new CourseDal());
List<Course> courses2 = courseManager.GetAll();
for (int i = 0; i < courses2.Count; i++)
{
   Console.WriteLine(courses2[i].Name);
}

//IndividualCustomer customer1 = new IndividualCustomer();
//IndividualCustomer customer2 = new IndividualCustomer();
//CorporateCustomer customer3 = new CorporateCustomer();
//CorporateCustomer customer4 = new CorporateCustomer();

//customer1.Id = 1;
//customer1.FirstName = "Ahmet";
//customer1.LastName = "Yılmaz";
//customer1.NationalIdentity = "123456789";
//customer1.CustomerNumber = "12345";

//customer2.Id = 2;  
//customer2.FirstName = "Mehmet";
//customer2.LastName = "Demir";
//customer2.NationalIdentity = "987654321";
//customer2.CustomerNumber = "23456";

//customer3.Id = 3;
//customer3.Name = "Kodlama.io";
//customer3.CustomerNumber = "34567";
//customer3.TaxNumber = "123456789";

//customer4.Id = 4;
//customer4.Name = "Kodla.io";
//customer4.CustomerNumber = "45678";
//customer4.TaxNumber = "987654321";

////Base sınıflar, miras verdiği sınıfların referanslarını tutabilir.
////Bu sayede polymorphism ilkesi uygulanabilir.

////miras verdiği sınıflardan oluşturulan nesnelerin referanslarını tutan bir basecustomer dizisi oluşturuldu.
//BaseCustomer[] customers = new BaseCustomer[] { customer1, customer2, customer3, customer4 };
////                                               101 ref    102 ref   103 ref   104 ref

//foreach (BaseCustomer baseCustomer in customers)
//{
//    Console.WriteLine(baseCustomer.Id);
//}

