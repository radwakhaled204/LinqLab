
using SeedData;
using SeedData.Models;
using System.Linq;


var cats = GetData.GetCategories(GetData.GetCustomers());

//var list = cats.Select(c => c.customer);
//foreach (var c in list)
//{
//    foreach (var cust in c)
//    {
//        Console.WriteLine(cust.id + " : " + cust.name);
//    }
//}

//SELECT METHOD
var list = cats.SelectMany(c => c.customer);
foreach (var c in list)
{
    Console.WriteLine(c.id + " : " + c.name);
}

