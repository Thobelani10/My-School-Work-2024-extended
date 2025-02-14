using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            TextMessage[] txtmessages = new TextMessage[3]; 

           
            for (int i = 0; i < 3; i++)
            {
                txtmessages[i] = new TextMessage();
                Console.Write("Enter the number of characters for message " + (i + 1) + ": ");
                int numberofCharacters = int.Parse(Console.ReadLine());
                txtmessages[i].setCharacters(numberofCharacters);
            }

            
            
            foreach (TextMessage txtmessage in txtmessages)
            {
                Console.WriteLine("\nMessage:");
                txtmessage.display();
                Console.WriteLine();
            }


            Console.ReadKey();
        }

        
        abstract class Message
        {
            public abstract double calculateCostOfMessage();
            public abstract void display();
        }

       
        class TextMessage : Message
        {
            private int characters;

            
            public TextMessage()
            {
                characters = 0;
            }

            
            public void setCharacters(int numberofCharacters)
            {
                characters = numberofCharacters;
            }

            
            public override double calculateCostOfMessage()
            {
                return characters * 0.05; 
            }

            
            public override void display()
            {
                Console.WriteLine("Number of characters: " + characters);
                Console.WriteLine("Cost of the text message: R" + calculateCostOfMessage());
            }
        }
    }
}
