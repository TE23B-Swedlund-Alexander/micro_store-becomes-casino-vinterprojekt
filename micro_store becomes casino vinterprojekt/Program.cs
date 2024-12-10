using System.Configuration.Assemblies;

Random rnd = new Random();
int money = 100;
bool cashout = false;
bool workingbet = false;
string game = "";
int bet = 0;
string betString;
string Roulettechoice = "";
int[] rouletteGreen = [1, 50];
int[] rouletteBlack = [3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35, 37, 39, 41, 43, 45, 47, 49];
int[] rouletteRed = [2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38, 40, 42, 44, 46, 48];
bool  workingroulette = false;
int roulettechoiceint;

while (money > 0 && cashout == false)
{
    Console.WriteLine($"you have {money} money");
    Console.WriteLine("what game do you want to play?");
    Console.WriteLine("write rewards for rewards list");
    while (game != "roulette" && game != "dice" && game != "blackjack")
    {
        Console.WriteLine("roulette, dice or blackjack");
        game = Console.ReadLine();
        if (game == "rewards")
        {
            Console.WriteLine("dice can win you 3x on a sum of seven and 5x on a sum of 2 or 12");
            Console.WriteLine("roulette can win you 2x on a right color (red or black) guess, x14 on right color green and 30x on a right number guess");
            Console.WriteLine("blackjack rewards 2x on win");
        }
    }



    while (game == "dice")
    {
        while (workingbet == false && bet<money && bet>0)
        {
            Console.WriteLine($"how much do you bet 1-{money}");
            betString = Console.ReadLine();
            workingbet = int.TryParse(betString, out bet);
        }
        Console.WriteLine("ready?");
        Console.ReadLine();
        int dieOne = rnd.Next(1, 6);
        int dieTwo = rnd.Next(1, 6);
        int dieSum = dieOne + dieTwo;
        Console.WriteLine($"rolled a {dieSum}");
        if (dieSum == 2 || dieSum == 12)
        {
            money += bet * 5;
            Console.WriteLine($"nice you win {bet * 5} money");
        }
        if (dieSum == 7)
        {
            money = money + bet * 2;
            Console.WriteLine($"you win {bet * 2} money");
        }
        if (dieSum != 2 && dieSum != 12 && dieSum != 7)
        {
            money -= bet;
            Console.WriteLine("toobad you did not win");
        }

        Console.WriteLine($"you have {money} money. play again? if not type 'no' otherwise type anything else");
        string dicecontinue = Console.ReadLine();
        if (dicecontinue == "no" || money <= 0) game = ""; dicecontinue = "";
    }


    if (game == "roulette")
    {
        while (workingbet == false)
        {
            Console.WriteLine($"how much do you bet 1-{money}");
            betString = Console.ReadLine();
            workingbet = int.TryParse(betString, out bet);
        }
        while (workingroulette == false)
        {
            Console.WriteLine("red,black,green or number?");
           string roulettechoice = Console.ReadLine();
           workingroulette = int.TryParse(roulettechoice, out roulettechoiceint);
        }






        Console.WriteLine($"you have {money} money. play again? if not type 'no' otherwise type anything else");
        string roulettecontinue = Console.ReadLine();
        if (roulettecontinue == "no" || money <= 0) game = ""; roulettecontinue = "";
    }


    if (game == "blackjack")
    {



    }
}



Console.ReadLine();