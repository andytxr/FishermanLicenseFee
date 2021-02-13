using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenseFee
{
    class FishermanTaxCalculator
    {

        private char _category;
        private int _age;
        private string _name;

        public char category
        {
            get
            {
                return _category;
            }
            set
            {
                _category = value;
            }
        }

        public int age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }

        public string name
        {
            get
            {
                return _name;           
            }
            set
            {
                _name = value;
            }
        }

        public double anualTax
        {
            get
            {
                if(category=='C' && age>0)
                {
                    return 15;
                }
                else if (category == 'E' && age > 10)
                {
                    return 30;
                }
                else
                {
                    return 6;
                }
            }
        }

        public FishermanTaxCalculator()
        {
            name = "Default";
            age = 0;
            category = 'D';
        }

        public FishermanTaxCalculator(string n, int a, char c)
        {
            name = n;
            age = a;
            category = c;
        }
    }
}
