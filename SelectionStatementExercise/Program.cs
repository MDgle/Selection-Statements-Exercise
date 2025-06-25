namespace SelectionStatementExercise
{
    public class Program
    {
        
        public static void NumberGuessingGameIntro()
        {
            Console.WriteLine("Let's play a guessing game!");
            Console.WriteLine("I'm thinking of a number between 1 and 1000!");
            Input();
        }

        public static void Input()
        {   Console.WriteLine("Guess a number and I will tell you if you are too high, too low, or correct!");
            var r = new Random();
            var favNumber = r.Next(1,1000);
            var userInput = int.Parse(Console.ReadLine());
            if (userInput < favNumber)
            {
                Console.WriteLine("Too Low");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("Too high!");
            }
            else if (userInput == favNumber)
            {
                Console.WriteLine("You guessed it!!!");
            }


            
            
        }
        static void Main(string[] args)
        { 
        NumberGuessingGameIntro();
            
            
            
          
        }
    }
}
