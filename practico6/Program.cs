//Principal
double num1, num2, resultado = 0;
int op;
string res = "1";
bool bandera = false;
do
{
    System.Console.WriteLine("Que operacion desea realizar?");
    System.Console.WriteLine("1) Sumar");
    System.Console.WriteLine("2) Restar");
    System.Console.WriteLine("3) Multiplicar");
    System.Console.WriteLine("4) Dividir");
    op = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Ingrese el primer numero:");
    num1 = Convert.ToDouble(Console.ReadLine());
    System.Console.WriteLine("Ingrese el segundo numero:");
    num2 = Convert.ToDouble(Console.ReadLine());
    bandera = true;
    switch (op)
    {
        case 1:
            resultado = num1 + num2;
            break;
        case 2:
            resultado = num1 - num2;
            break;
        case 3:
            resultado = num1 * num2;
            break;
        case 4:
            if (num2 != 0)
                resultado = num1 / num2;
            else
            {
                System.Console.WriteLine("No se puede dividir en 0");
                bandera = false;
            }
            break;
        default:
            bandera = false;
            System.Console.WriteLine("Esta operacion no existe ");
            break;
    }
    if (bandera)
    {
        System.Console.WriteLine($"El resultado de la operacion es: {resultado}");
    }
    System.Console.WriteLine("Desea seguir operando? (si | 1) (no | 0)");
    res = Console.ReadLine();
} while (res != "0");