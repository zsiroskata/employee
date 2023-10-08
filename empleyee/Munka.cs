using System;
using System.Collections.Generic;
using System.Text;

namespace empleyee
{
    class MunkaValalo
    {
        //name, age, city, department, position, gender, marital status, salary (EUR)
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public bool Gender { get; set; }
        public string MaritalStatus { get; set; }
        public int Salary{ get; set; }

        public MunkaValalo(string sorok)
        {
            string[] sor = sorok.Split(";");
            Name = sor[0];
            Age = int.Parse(sor[1]);
            City = sor[2];
            Department = sor[3];
            Position = sor[4];
            Gender = sor[5] == "Male";
            MaritalStatus = sor[6];
            Salary = int.Parse(sor[7]);
        }

        public void kiir()
        {
            Console.WriteLine($"legidősebb ember adatai: {Name}, {Age}, {Position}, {Gender}, {MaritalStatus}, {Salary}");
        }

    }
}
