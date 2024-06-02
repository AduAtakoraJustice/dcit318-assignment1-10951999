
using System;


namespace GradeCalculator{

    public class GradeCalculator{

        public static void Main(String[] args){
            
            Console.WriteLine("Grade calculator using C#\n\n");

            Console.WriteLine("Enter exams score: ");

            string userInput = Console.ReadLine();

            double score;
            
            bool conversionFlag = double.TryParse(userInput, out score);

            if(!conversioFlag){

                Console.writeLine("Error......You must enter a number.");
                
                return;
            }

            char grade;

            if(score >= 90){
                grade = 'A';
            }else if(score >= 80){
                grade = 'B';
            }else if(score >= 70){
                grade = 'C';
            }else if(score >= 60){
                grade = 'D';
            }else{
                grade = 'F';
            }

            Console.writeLine("Your score: " + grade);
            Console.writeLine("Your grade: " + grade);

        }
    }
}