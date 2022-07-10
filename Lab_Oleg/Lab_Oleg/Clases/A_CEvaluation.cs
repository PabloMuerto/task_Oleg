using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Oleg.Clases
{
    abstract class A_CEvaluation
    {        
        /* використання абстрактного аксесора 
         * (бо це властивість яку можна назвати методом але 
         * вона маскується під поле.. якась така приблуда) 
         * в якості зберігання оцінки*/
        public abstract int number { get; }

        public abstract void PrintEvaluation();
        public void ShowInfoNumper() 
        {
            Console.WriteLine($"{number}");
        }
    }

    class EvaluationMass : A_CEvaluation
    {
        public override int number { get { return 5; } }

        public override void PrintEvaluation()
        {
            Console.Write("Оцiнки iз матану: ");
        }
    }
    class EvaluationPhysics : A_CEvaluation
    {
        public override int number { get { return 4; } }
        public override void PrintEvaluation()
        {
            Console.Write("Оцiнки за кр iз фiзики: ");
        }
    }

}
