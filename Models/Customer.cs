using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avoda_Managerment.Models
{
    public class Customer
    {
        private int id;
        private string name;
        private string phone;
        private int score;

        public Customer()
        { }

        public Customer(int id, string name, string phone, int score)
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
            this.score = score;
        }

        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public int Score { get => score; set => score = value; }
        public int Id { get => id; set => id = value; }
    }
}