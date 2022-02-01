Console.WriteLine("Enter tables number:");
int number = Convert.ToInt32(Console.ReadLine());


for (int i = 0; i < 11; i++)
{
    Console.WriteLine("{0} * {1} = {2}", number, i, number * i);
}


