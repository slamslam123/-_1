using System;

namespace Задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Переменные

            string FullName = "Никита";
            byte Age = 26;
            string Email = "slamslam122.95@gmail.com";
            double ProgrammingPoints = 15.9;
            double MathScores = 56.2;
            double PhysicsScores = 24.5;
            double Add = ProgrammingPoints + MathScores + PhysicsScores;
            double Div = Add / 3;

            Console.WriteLine($"Имя: {FullName} \nВозраст: {Age} \nEmail: {Email} \nБаллы по программированию: {ProgrammingPoints} \nБаллы по математике: {MathScores} \nБаллы по физике: {PhysicsScores}");
            Console.ReadKey();
            
            Console.WriteLine($"Сумма баллов: {Add}. \nСредний балл: {Div}.");
            Console.ReadKey();

        }
    }
}
