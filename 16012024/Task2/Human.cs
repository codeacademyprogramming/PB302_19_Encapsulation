using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    internal class Human
    {
        public string Fullname;
        protected byte Age = 18;
        private string _birthPlace;

        public string BirthPlace { 
            get
            {
                return _birthPlace;
            }
            set
            {
                if(value != null)
                    _birthPlace= value;
            }
        }

        public void SetBirthPlace(string value)
        {
            if(value!=null) _birthPlace = value;
        }

        public string GetBirthPlace() { return _birthPlace; }
        public virtual void SetAge(byte value)
        {
            if (value >= 18 && value <= 65)
                Age = value;
        }

        public byte GetAge()
        {
            return Age;
        }
    }
}
