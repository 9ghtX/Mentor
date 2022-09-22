using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using System.Xml.Serialization;

namespace Mentor.Interfaces
{
    internal interface IDurable
    {
        int Durability{ get; set; }

        void GetDamaged(int damage)
        {
            this.Durability -= damage;
        }

        void GetRepaired(int repair)
        {
            this.Durability += repair;
        }
    }
}
