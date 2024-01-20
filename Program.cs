using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod6OOP
{
    class Company
    {
        public string Type;
        public string Name;
    }

    class Department 
    {
        public Company MyCompany = new Company();
        public City MyCity = new City();
       
    }

    class City
    {
        public string Name;
    }

    internal class Program
    {        
        static void Main(string[] args)
        {           
            var department = GetCurrentDepartment();

            Console.ReadKey();
        }
        static Department GetCurrentDepartment()
        {
            City city = new City { Name = "Санкт-Петербург" };
            Company company = new Company { Type = "Банк" };
            Department department = new Department();
            department.MyCity = city;
            department.MyCompany = company;

            if (department?.MyCompany?.Type == "Банк" && department?.MyCity?.Name == "Санкт-Петербург")
            {
                Console.WriteLine("У банка {0} есть отделение в Санкт-Петербурге", department?.MyCompany.Name ?? "Неизвестная компания");
            } 
            
            return department;
        }

    }
}
