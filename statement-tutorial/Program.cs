


using Microsoft.VisualBasic;
using System.Globalization;

int[] nbrs = {

   754, 233, 509, 792, 700, 596, 833, 658, 998, 742,

   187, 754, 308, 914, 489, 867, 717, 586, 929, 467,

   460, 241, 770, 324, 599, 259, 120, 800, 336, 609,

   690, 134, 598, 249, 282, 574, 334, 956, 659, 214,

   435, 643, 809, 874, 906, 620, 328, 369, 426, 561

};
int highest = 0;
int lowest = 1000;
foreach(var nbr in nbrs) {
    if(nbr > highest) {
        highest = nbr;
    }
    if(nbr < lowest) {
        lowest = nbr;
    }
}





/*
string[] names = {"rob", "trevor", "jace", "jason", "lynn", "zack", "jake", "skyler", "tim", "jacob" };
foreach(string name in names) {
    Console.WriteLine(name);
}
*/





/*
int total = 0;
for(int i = 1; i <= 50; i++) {
    if(i % 2 != 0)
    {
        total = total + i;
    } 
} 
Console.WriteLine($"{total}");
/*

/*
int sum = 0;
for (int i = 0; i < 10; i++) {
    sum = sum + i;
    Console.WriteLine($"i={i}, sum={sum}");
}
*/



/*
Console.Write("Enter an Integer: ");
string? answerString = Console.ReadLine();

int answer = Convert.ToInt32(answerString);

string evenOdd = "";

if (answer % 2 == 0) {
    evenOdd = "even";
} else {
    evenOdd = "odd";
}
 
Console.WriteLine($"The number {answer} is {evenOdd}");
*/