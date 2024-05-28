class QuizApp
{
    static void Main()
    {
        string[] questions =
        {
            "er zijn 1000 kippen hier wat is 1 % van die kippen ",
            "van die 1000 kipen zijn er 397 di een bril dragen hvl % draagt een  bril ",
            "bij de 1000 kippen is de toenamen 46 % hvl kippen zijn er nu "
        };

        string[] answers =
        {
            "A.100 \nB.10 \nC.1",
            "A.3,97 \nB.39,7 \nC.44,7",
            "A.1460 \nB.1500 \nC.540"
        };

        int[] correctAnswers = { 1, 1, 0 };

        int playerScore = 0;

        Console.WriteLine("Hallo deze quize gaat over .... veel plezier");
        for (int i=0; i < questions.Length; i++)
        {
            Console.WriteLine("Question" + (i + 1));
            Console.WriteLine(questions[i]);
            Console.WriteLine(answers[i]); 
            Console.WriteLine("voer hier je andwoord in ('A','B', of 'C'):");
            string playerAnswer = Console.ReadLine();

            if(string.Equals(playerAnswer, "A", StringComparison.OrdinalIgnoreCase) && correctAnswers[i] == 0)
            {
                playerScore++;
            }
            else if(string.Equals(playerAnswer, "B", StringComparison.OrdinalIgnoreCase) && correctAnswers[i] == 1)
            {
                playerScore++;
            }
            else if (string.Equals(playerAnswer,"C", StringComparison.OrdinalIgnoreCase) && correctAnswers[i] == 2)
            {
                playerScore++;
            }

        }

        Console.WriteLine("dit was de quiz ik hoop dat je het leuk vond! ");
        Console.WriteLine("Jouw score is: " + playerScore + "/" + questions.Length);
    }
}