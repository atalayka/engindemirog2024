using Business.Concrete;
using Entities.Concrete;
//namespace workaround!



//////////////uygulama///////////////////////////////////////////
Person person1 = new Person();
person1.FirstName = "Atalay";
person1.LastName = "KABAKÇI";
person1.DateOfBirthYear = 1996;
person1.NationalIdentity = 111111111111;
PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);
///////////uygulama///////////////////////////////////////////

//////////////arrays///////////////////////////////////////////
//array: a collection type.
string Ogrenci1 = "Engin";
string Ogrenci2 = "Atalay";
string Ogrenci3 = "Ali";
string[] Ogrenciler = ["engin", "atalay", "ali"];

Ogrenciler = new string[4];
Ogrenciler[3] = "veli";
Ogrenciler[0] = "engin";
Ogrenciler[1] = "atalay";
Ogrenciler[2] = "ali";
/*referans olarak tutulduğu için tekrar bir instance çekildiğinde bellekten atılır, indexlerin el ile tekrar doldurulması lazm*/

for (int i = 0; i < Ogrenciler.Length; i++)
{
    Console.WriteLine(Ogrenciler[i]);
}
foreach (var item in Ogrenciler)
{
    Console.WriteLine(item);
}
//////////////arrays///////////////////////////////////////////

//////////////list///////////////////////////////////////////
List<string> Sehirler1 = new List<string> { "Ankara", "İstanbul", "Mersin" };
Sehirler1.Add("Edirne");

//////////////list///////////////////////////////////////////

//////////////reference types///////////////////////////////////////////
/*array, class, interface, abstracts, string(char array) are reference types
theyr holds by stack in a reference logic */

string[] sehirler1 = new[] { "ankara", "istanbul", "izmir" };
string[] sehirler2 = new[] { "bursa", "antalya", "mersin" };
sehirler2 = sehirler1; //sehirler2 referansı artık sehirler1 referansıdır. 
sehirler1[0] = "Adana";

foreach (string item in sehirler2)
{
    Console.WriteLine(item);
}
foreach (string item in sehirler1)
{
    Console.WriteLine(item);
}
//////////////reference types///////////////////////////////////////////

//////////////value types///////////////////////////////////////////
/* int, double, bool, char... are value types.*/
int num1 = 10;
int num2 = 20;
num1 = num2;
//num1 = 20 now.
//////////////value types///////////////////////////////////////////

//////////////method///////////////////////////////////////////
Citizen ct = new();
Console.WriteLine(ct.Name);
SelamVer("E. Demirog");

int result = Sum(13, 2);
Console.WriteLine(result);

Console.ReadLine();

static void SelamVer(string isim = "")
{
    Console.WriteLine("Merhaba, " + isim);
}

static int Sum(int num1 = 5, int num2 = 5)
{
    int summ = num1 + num2;
    Console.WriteLine("Toplam: " + summ);
    return summ;
}
//////////////method///////////////////////////////////////////

//////////////class///////////////////////////////////////////
//seperating to logic rooms (objects)
public class Citizen
{
    public string Name = "Atalay";
    string LName = "Kabakçı";
    int BYear = 1996;
    long tcNo = 012345678910;

    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int DogumYili { get; set; }
    public long TcNo { get; set; }
}
//////////////class///////////////////////////////////////////





