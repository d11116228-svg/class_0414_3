using System.Security.Cryptography.X509Certificates;

namespace Class_0414_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Caller c = new Caller();

            c.CallGetName(new Person());

            c.CallGetName(new Student());

            c.CallGetName(new Teacher());
        }
    }
}