using System;
using System.Collections.Generic;

namespace CompositePattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var tom = new Developer {Name = "Tom"};
            var dick = new Developer { Name = "Dick" };
            var harry = new Developer { Name = "Harry" };
            var developers = new Developers {  Members = { tom, dick, harry } };

            var lineManager = new LineManager { Name = "Fred" };
            var applicationDevelopement = new Team
            {
                Name = "The Dream Team",
                Members = { lineManager, developers }
            };
            
            var departmentHead = new DepartmentHead { Name = "Frank" };
            var department = new Department
            {
                Name = "IT",
                Members = {departmentHead, applicationDevelopement},
                Bonus = 12000d
            };

            department.PrintStatistics();

            Console.ReadKey();
        }
    }
}