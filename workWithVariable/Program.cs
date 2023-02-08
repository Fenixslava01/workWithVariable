using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workWithVariable
{
    class Program
    {
        static void Main()
        {
            //Задание 1

            string userFullName = "Иванов Иван Иванович";
            int userAge = 40;
            string userMail = "iii@gmail.com";
            float userProgrammingScore = 365.54f;
            float userMathScore = 387.6f;
            float userPhysicsScore = 894.7f;

            Console.WriteLine($"userFullName = {userFullName}\nuserAge = {userAge}\nuserMail = {userMail}\nuserProgrammingScore = {userProgrammingScore}" +
                $"\nuserMathScore = {userMathScore}\nuserPhysicsScore = {userPhysicsScore}");

            // Задание 2

            float scoreSumm;
            scoreSumm = userProgrammingScore + userMathScore + userPhysicsScore;
            float averageScoreSumm;
            averageScoreSumm = scoreSumm / 3;

            Console.WriteLine($"\nОбщая сумма баллов = {scoreSumm}");
            Console.WriteLine("Нажмите любую кнопку для продолжения");
            Console.ReadKey();
            Console.WriteLine($"\nСреднеарифметическая сумма баллов = {averageScoreSumm}");

            
            Console.WriteLine("Нажмите любую кнопку для выхода...");
            Console.ReadKey();

        }
    }
}
