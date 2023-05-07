

Console.WriteLine("Enter a number:");
int userNum = Convert.ToInt32(Console.ReadLine());

int result = userNum % 2;

if(result != 0) //ei ole võrdne !=, on võrne ==
{
    Console.WriteLine("USer number is odd.");

}
else
{
    Console.WriteLine("User number is even");
}