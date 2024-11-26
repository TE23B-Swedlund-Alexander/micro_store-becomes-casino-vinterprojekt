using System.Configuration.Assemblies;

Random rnd = new Random();
int money = 100;
bool cashout = false;
string game = "";
Console.WriteLine($"you have {money} money");


while (money > 0 && cashout == false)
{
    Console.WriteLine("what game do you want to play?");
    Console.WriteLine("rules");
    while (game != "roulette" && game != "dice" && game != "blackjack")
    {
        Console.WriteLine("roulette, dice or blackjack");
    }
}


if(game=="dice"){
int bet=0;
bool realBetDice = false;
while(realBetDice==false){
Console.WriteLine("how much do you bet");
string betInLetters =Console.ReadLine();
realBetDice = int.TryParse(betInLetters, out bet);
}
int dieOne=rnd.Next(1,6);
int dieTwo=rnd.Next(1,6);
int dieSum=dieOne+dieTwo;
if(dieSum==2 || dieSum==12);


}


if(game=="roulette"){



}


if(game=="blackjack"){



}




Console.ReadLine();