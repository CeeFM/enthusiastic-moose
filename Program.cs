using System;

Main();

void Main()

{
Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
Console.WriteLine("--------------------------------------------");
Console.WriteLine();

bool MooseAsks(string question)
{
    Console.Write($"{question} (Y/N): ");
    string answer = Console.ReadLine().ToLower();

    while (answer != "y" && answer != "n")
    {
        Console.Write($"{question} (Y/N): ");
        answer = Console.ReadLine().ToLower();
    }

    if (answer == "y")
    {
        return true;
    }
    else
    {
        return false;
    }
}


void MooseSays(string message)
{
    Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ /     \  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ /---| |X \ /
                       | X  / \   |  {message}
                      / `^`   `^` \   
                     /             \    
                    | '._.'         \      
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}

MooseSays("WHAT THE FUUUUUUUUUUUUUUUUUCK IN A GOOD WAY THO I'M NOT MAD I'M JUST ENTHUSIASTIC");

void Questions () 
{
    List<string> AIQuestions = new List<string>() { "Is Canada real?", "You like food tho?", "You got a car or are you out here strugglin?"};
    List<string> TrueAnswers = new List<string>() { "Really? It seems very unlikely", "This is the only correct answer", "damn ok I see you mr. monopoly money bags MF"};
    List<string> FalseAnswers = new List<string>() { "I K N E W I T!!!!!!!", "wtf who hurt you bro?", "ouch it's like they say the strugg is rill"};

    for (int i = 0; i < 3; i++)
        {
           bool isTrue = MooseAsks(AIQuestions[i]);
           if (isTrue)
           {
            MooseSays(TrueAnswers[i]);
           }
           else 
           {
            MooseSays(FalseAnswers[i]);
           }
        }

}

//void CanadaQuestion ()
//{
//    bool isTrue = MooseAsks("Is Canada real?");
//    if (isTrue)
//    {
//        MooseSays("Really? It seems very unlikely.");
//    }
//    else
//    {
//        MooseSays("I  K N E W  I T !!!");
//    }
//}
//
//void FoodQuestion ()
//{
//    bool isTrue = MooseAsks("You like food tho?");
//    if (isTrue)
//    {
//        MooseSays("this is the only correct answer");
//    }
//    else
//    {
//        MooseSays("wtf who hurt you bro");
//    }
//}
//
//void CarQuestion ()
//{
//    bool isTrue = MooseAsks("You got a car or are you out here strugglin?");
//    if (isTrue)
//    {
//        MooseSays("damn ok flex mr. monopoly money bag mf");
//    }
//    else
//    {
//        MooseSays("ouch");
//    }
//}
//
//CanadaQuestion();
//FoodQuestion();
//CarQuestion();
Questions();

}