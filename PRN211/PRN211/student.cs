using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211
{
    public class student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string description { get; set; }
        public string phone { get; set; }
        public string email {  get; set; }
        public DateTime Created { get; set; }

        public student(int id, string name, int age, string description, string phone, string email, DateTime created)
        {
            Id = id;
            Name = name;
            Age = age;
            this.description = description;
            this.phone = phone;
            this.email = email;
            Created = created;
        }

        public student(string name, int age) 
        {
            Name = name;
            Age = age;
        }

        public student() { }
    }
}
