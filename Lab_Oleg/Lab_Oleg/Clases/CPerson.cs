using Lab_Oleg.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Oleg.Person
{
    class CPerson
    {
        public CPerson(string firstName_, string lastName_) 
        {
            this.firstName_ = firstName_;
            LastName = lastName_;
        }
        /*демонстрація можливості ключового слова this
         у випадку неоднозначності імен полів
        При використанні this компілятор точно зрозуміє,
        до якого класу, конструктора відноситься поле(змінна)*/
        private string firstName_ { get; set; }
        private string LastName { get; set; }

        public void PrintPerson() 
        { 
            Console.WriteLine($"Мене звати {firstName_} {LastName}");
        }
    }
}
