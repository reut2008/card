using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace קלפים
{
    class Card
    {
        private int value;
        private int sign;
        public Card(int value,int sign)
        {
        
            this.value = value;
            this.sign = sign;
        }
        public int GetValue()
        {
            
        return value;
        }
        public int GetSign()
        { 
        return sign;
        }

        public override string ToString()
        {
        return "Card:("+value+""+"of"+""+sign+")";
        }
    }
}
