using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avoda_Managerment.Models
{
    public class Transaction
    {
        private int id;
        private string name;
        private string phone;
        private long total_price;
        private int score_use;
        private long final_price;
        private int score_earn;
        private DateTime date;

        public Transaction()
        {
        }

        public Transaction(int id, string name, string phone, long total_price, int score_use, long final_price, int score_earn, DateTime date)
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
            this.total_price = total_price;
            this.score_use = score_use;
            this.final_price = final_price;
            this.score_earn = score_earn;
            this.date = date;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public long Total_price { get => total_price; set => total_price = value; }
        public int Score_use { get => score_use; set => score_use = value; }
        public long Final_price { get => final_price; set => final_price = value; }
        public int Score_earn { get => score_earn; set => score_earn = value; }
        public DateTime Date { get => date; set => date = value; }
    }
}