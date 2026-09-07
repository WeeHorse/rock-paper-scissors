namespace rock_paper_scissors;

class Program
{
    static int playerScore = 0;
    static int computerScore = 0;

    static void Main(string[] args)
    {
        Console.WriteLine("Let's play best of three!");
        PlayMatch();
    }

    static void PlayMatch()
    {
        while (playerScore < 2 && computerScore < 2)
        {
            PlayRound();
            PrintScore();
        }

        PrintMatchWinner();
    }

    static void PlayRound()
    {
        string playerChoice = GetPlayerChoice();
        string computerChoice = GetComputerChoice();

        Console.WriteLine("The computer chose: " + computerChoice);

        DecideRoundWinner(playerChoice, computerChoice);
    }

    static string GetPlayerChoice()
    {
        Console.WriteLine("\nChoose rock, paper or scissors:");
        return Console.ReadLine().ToLower();
    }

    static string GetComputerChoice()
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 4);

        if (randomNumber == 1)
        {
            return "rock";
        }
        else if (randomNumber == 2)
        {
            return "paper";
        }
        else
        {
            return "scissors";
        }
    }

    static void DecideRoundWinner(
        string playerChoice,
        string computerChoice
    )
    {
        if (playerChoice == computerChoice)
        {
            Console.WriteLine("It is a draw! Play another round.");
        }
        else if (
            playerChoice == "rock" && computerChoice == "scissors" ||
            playerChoice == "paper" && computerChoice == "rock" ||
            playerChoice == "scissors" && computerChoice == "paper"
        )
        {
            Console.WriteLine("You win the round!");
            playerScore++;
        }
        else
        {
            Console.WriteLine("The computer wins the round!");
            computerScore++;
        }
    }

    static void PrintScore()
    {
        Console.WriteLine(
            $"Score: You {playerScore} – {computerScore} Computer"
        );
    }

    static void PrintMatchWinner()
    {
        if (playerScore == 2)
        {
            Console.WriteLine("\nYou win the match!");
        }
        else
        {
            Console.WriteLine("\nThe computer wins the match!");
        }
    }
}