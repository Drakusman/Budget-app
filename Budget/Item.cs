using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget
{
    public class Item
    {
        public int id;
        public string name;
        public float amount;
        public string date;
        public bool rep;
        public string type;

        public Item(int id, string name, float amount, string date, bool rep)
        {
            this.id = id;
            this.name = name;
            this.amount = amount;
            this.date = date;
            this.rep = rep;
            if (amount >= 0)
                this.type = "income";
            else
                this.type = "expense";
       
        }
    }
}
