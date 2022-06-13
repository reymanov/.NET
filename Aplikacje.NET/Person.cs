using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacje.NET
{
    internal class Person: Observable
    {
        private string name;
        private string[] names = new string[2];
        private string firstName;
        private string lastName;
        private string date;
        private string[] dates = new string[3];
        private int years;

        public Person()
        {
            this.name = "";
            this.date = "";
        }

        public string[] Names
        {
            get { return names; }
            set { names = value; }
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                names = name.Split(' ');
                if(names.Length > 0)
                {
                    if(names.Length == 1) FirstName = Names[0];

                    if(names.Length > 1)
                    {
                        FirstName = Names[0];
                        LastName = Names[1];
                    }
                }
        
                OnPropertyChanged();
            }
        }

        public string FirstName
        {
            get { return firstName; }
            set
            {

                firstName = value;
                OnPropertyChanged();

            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
                OnPropertyChanged();
            }

        }

        public string[] Dates
        {
            get { return dates; }
            set { dates = value; }
        }

        public string Date
        {
            get { return date; }
            set
            {
                date = value;
                dates = date.Split('.');
                if (dates.Length > 2)
                {
                    Years = 2022 - Convert.ToInt16(dates[2]);
                }

                OnPropertyChanged();
            }
        }

        public int Years
        {
            get { return years; }
            set { 
                years = value;
                OnPropertyChanged();
            }
        }
    }
}
