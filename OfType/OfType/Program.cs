using System.Collections;
using System.Net.Http.Headers;

OfType.OfType a = new OfType.OfType();
List<Exception> lst = new List<Exception>() { new Exception() , new ArgumentNullException(),new DivideByZeroException() };
IEnumerable<ArgumentException> wow = a.GetOfType<Exception, ArgumentException>(lst);

foreach (ArgumentException i in wow)
{
    Console.WriteLine(wow);
}