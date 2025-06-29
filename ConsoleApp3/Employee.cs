using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Employee
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Department { get; set; }
        public decimal Salary { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}, Ad: {Name}, Bolme: {Department}, Maas: ${Salary}, Yas: {Age}";
        }
    }
}

