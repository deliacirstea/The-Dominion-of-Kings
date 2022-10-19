Console.WriteLine("Let's find out great your kingdom is!");
Console.WriteLine("-----------------------------");

Console.WriteLine("How many provinces does your kingdom has?");
int provPoint = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("How many duchies does your kingdom has?");
int duchPoint = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("How manye estates does your kingdom has?");
int estatePoint = Convert.ToInt32(Console.ReadLine());

int province = 6 * provPoint;
int duchy = 3 * duchPoint;
int estate = 1 * estatePoint;
int total = province + duchy + estate;  

Console.WriteLine("Your kingdom has "  + total +  "  points in total!\n Keep conquering more land!"); 


