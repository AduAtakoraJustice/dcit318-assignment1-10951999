
using System;

namespace TicketSystem{
    
    public class TicketSystem{

        public static void Main(string[] args){

            Console.WriteLine("Ticket Price Calculator \n\n");

            Console.Write("Enter your age: ");

            int age = Convert.ToInt32(Console.readLine());

            double ticketPrice = 10;
            
            if(age <= 12 || age >= 65){
                ticketPrice = 7;
            }

            Console.WriteLine("\n Your age is " + age + "\n You are to pay: " + ticketPrice);

        }

    }

}