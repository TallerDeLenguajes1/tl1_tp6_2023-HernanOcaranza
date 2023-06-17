int invertir(int num)
{
    char[] numArray = num.ToString().ToCharArray();
    Array.Reverse(numArray);
    string reverseNum = "";
    foreach (var numero in numArray)
    {
        reverseNum += numero;
    }
    return Convert.ToInt32(reverseNum);
}

//Principal
int num = 0;
string sNum;
do
{
    Console.WriteLine("Ingrese el numero a invertir:");
    sNum = Console.ReadLine();
} while (!int.TryParse(sNum, out num));

if (num > 0)
{
    Console.WriteLine($"Su numero invertido es {invertir(num)}");
}
else
{
    Console.WriteLine("Ingrese un numero positivo");
}
