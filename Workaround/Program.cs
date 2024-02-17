
using Entities.Concrete;
using System.Xml.Linq;
using Business.Concrete;

//NewMethod();

Citizen citizen = new();
citizen.Name = "Mustafa";
citizen.LastName = "Alkaya";
citizen.BirthDay = 1999;
citizen.NationalIdentity = 999;

Hi("Mustafa");
Hi();
Hi();
static void Hi(string isim = "Anonim")
{
    Console.WriteLine("Merhaba " + isim);
}

string[] students = new string[3];
students[0] = "Mustafa";
students[1] = "Enes";
students[2] = "Semih";

for (int i = 0; i < students.Length; i++)
{
    Console.WriteLine(students[i]);
}

foreach (var student in students)
{
    Console.WriteLine(student);
}

List<string> sehirler = new List<string> { "Kayseri", "Muğla", "Edirne" };
sehirler.Add("Yozgat");
foreach (var city in sehirler)
{
    Console.WriteLine(city);
}

PttManager pttManager = new PttManager(new CitizenManager());
pttManager.GiveMask(citizen);

Console.ReadLine();

static void NewMethod()
{
    string message = "Selam";
    double amount = 1000.5;
    int number = 100;
    bool isJoin = false;

    Console.WriteLine(message);
}