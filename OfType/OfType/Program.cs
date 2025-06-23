using System.Collections;
using System.Net.Http.Headers;

ArrayList al = new ArrayList() { 2, "abc" , 3, 5, 6, 7, 2.3 , false, 5.5 , true, DateTime.Now, 999 };
OfType.OfType a = new OfType.OfType();
IEnumerable<int> lst = a.GetOfType<int>(al);

foreach (int i in lst)
{
    Console.WriteLine(i);
}