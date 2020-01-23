using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
   public class Person
    {
        private String name;
        private int age;
        private String wasteAmount;
        private String waste;
        private String recycle;

        public Person(String name, int age, String wasteAmount,String waste,String recycle)
        {
            this.Name = name;
            this.Age = age;
            this.wasteAmount = wasteAmount;
            this.waste = waste;
            this.recycle = recycle;
        }

       public String Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }


        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public String WasteAmount
        {
            get
            {
                return wasteAmount;
            }
            set
            {
                wasteAmount = value;
            }
        }

        public String Waste
        {
            get
            {
                return waste;
            }
            set
            {
                waste = value;
            }
        }

        public String Recycle
        {
            get
            {
                return recycle;
            }
            set
            {
                recycle = value;
            }
        }

        public String toString ()
        {
            return name + " " + age + "\n"
                + waste+ " " + WasteAmount + "\n"
                +recycle;
        }
    }
}
