using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.Company_Manager
{
    class ReadAndPrintInfo
    {
        static void Main()
        {
            string companyName;
            string companyAddress;
            string companyPhoneNumber;
            string companyFaxNumber;
            string companyWebSite;
            string companyManager;

            string managerFirstName;
            string managerLastName;
            byte managerAge;
            string managerPhoneNumber;

            Console.Write("Manager First Name = "); managerFirstName = Console.ReadLine() ;
            Console.Write("Manager Last Name = "); managerLastName = Console.ReadLine();
            Console.Write("Manager Age =  "); managerAge = byte.Parse(Console.ReadLine());
            Console.Write("Manager Phone Number = "); managerPhoneNumber = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Company Name = "); companyName = Console.ReadLine();
            Console.Write("Company Address = "); companyAddress = Console.ReadLine();
            Console.Write("Company  Phone Number = "); companyPhoneNumber = Console.ReadLine();
            Console.Write("Company Fax Number = "); companyFaxNumber = Console.ReadLine();
            Console.Write("Company Web Site = "); companyWebSite = Console.ReadLine();

            Console.WriteLine();

            companyManager = managerFirstName + " " + managerLastName;

            Console.WriteLine("Company Info:");
            Console.WriteLine(companyName);
            Console.WriteLine(companyAddress);
            Console.WriteLine("Phone: {0}",companyPhoneNumber);
            Console.WriteLine("Fax: {0}",companyFaxNumber);
            Console.WriteLine(companyWebSite);
            Console.WriteLine("Manager: {0}",companyManager);

            Console.WriteLine();

            Console.WriteLine("Manager Info:");
            Console.WriteLine("{0} {1}",managerFirstName,managerLastName);
            Console.WriteLine("Age: {0}",managerAge);
            Console.WriteLine("Phone: {0}",managerPhoneNumber);

            Console.ReadKey(false);

        }
    }
}
