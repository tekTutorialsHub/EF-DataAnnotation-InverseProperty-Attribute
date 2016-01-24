using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnnotation_InverseProperty_Attribute
{
    class Program
    {
        static void Main(string[] args)
        {
            EFContext ctx = new EFContext();

            ctx.Employees.Select(e => e.EmployeeID == 0);

            Console.WriteLine("Press any key to close");
            Console.ReadKey();

        }
    }
}
