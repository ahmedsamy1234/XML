using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLProject
{
    class Employee
    {
        int  id;
        string name;
        string email;
        string phone;
        string address;

        public Employee(int id, string name, string phone, string address, string email )
        {
            this.Name = name;
            this.Id = id;
            this.Email = email;
            this.Phone = phone;
            this.Address = address;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
    }
}
