using System;
using Lab_Oleg.Person;
using Lab_Oleg.Clases;
namespace Lab_Oleg
{
    class Program
    {
        static void Main(string[] args)
        {
            CStudent student = new CStudent("Павло","Халус","Бакалавр");
            student.PrintStudent();
            // Реалізація абстрактного класу
            A_CEvaluation[] listGlobal = { new EvaluationMass(), new EvaluationPhysics() };

            foreach (var item in listGlobal)
            {
                student.PrintEvaluation(item);
                student.ShowInfo(item);
            }

            //Реалізація поліформізму в інтерфейсі
            IData data = new CProcessor();
            data.ProcessData(new CdbData());
        }
    }
}
