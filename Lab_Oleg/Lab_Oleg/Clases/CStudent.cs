using Lab_Oleg.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Oleg.Person
{
    class CStudent : CPerson
    {
        public CStudent(string firstName_, string lastName_, string status_) : base(firstName_, lastName_)
        {
            Status = status_ ;
        }
        public string Status { get; set; }
        public void PrintStudent() 
        {
            base.PrintPerson();
            Console.WriteLine($"Числеться в iнститутi {Status}");
        }
       
        // цей метод відповідає за реалізацію наслідників абстрактного класу
        public void PrintEvaluation(A_CEvaluation Evaluation) 
        {
            Evaluation.PrintEvaluation();
        }
        public void ShowInfo(A_CEvaluation Evaluation) 
        {
            Evaluation.ShowInfoNumper();
        }
    }
}
