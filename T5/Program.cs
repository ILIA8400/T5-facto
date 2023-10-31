// ایلیا اصغرحری
// تمرین پنجم


string yn;
do
{

    Console.WriteLine("Enter the number to calculate the factorial:");
    long number = Convert.ToInt64(Console.ReadLine());

    long x = 1;

    for (int i = 2; i <= number; i++)
    {
        x = x * i;

    }

    Console.WriteLine("your answer:" + x);

    Console.WriteLine("Do you want to continue? y/n");
    yn = Console.ReadLine();

}
while (yn == "y");
