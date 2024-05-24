//Ejercicio-1
/*
using EspacioCalculadora;
MiCalculadora MiCalculadora = new MiCalculadora(); 
int opcion = 0;

do
{
    Console.WriteLine("#####MENU CALCULADORA########");
    Console.WriteLine("1 - SUMAR");
    Console.WriteLine("2 - RESTAR#");
    Console.WriteLine("3 - MULTIPLICAR");
    Console.WriteLine("4 - DIVIDIR");
    Console.WriteLine("5 - LIMPIAR");
    Console.WriteLine("Ingrese una opcion: ");

    if (int.TryParse(Console.ReadLine(), out opcion))
    {
        double valor;
        switch (opcion)
        {
            case 1:
                Console.WriteLine("Ingrese un valor a sumar");
                if (double.TryParse(Console.ReadLine(), out valor))
                {
                    MiCalculadora.Sumar(valor);
                    Console.WriteLine($"Se sumo el valor: {valor}. El resultado es: {MiCalculadora.Resultado}");
                }
                else
                {
                    Console.WriteLine("Valor Ingresado Incorrecto");
                }
            break;
            case 2:
                Console.WriteLine("Ingrese un valor a Restar");
                if (double.TryParse(Console.ReadLine(), out valor))
                {
                    MiCalculadora.Restar(valor);
                    Console.WriteLine($"Se resto el valor: {valor}. El resultado es: {MiCalculadora.Resultado}");
                }
                else
                {
                    Console.WriteLine("Valor Ingresado Incorrecto");
                }
            break;
            case 3:
                Console.WriteLine("Ingrese un valor a Multiplicar");
                if (double.TryParse(Console.ReadLine(), out valor))
                {
                    MiCalculadora.Multiplicar(valor);
                    Console.WriteLine($"Se multiplico el valor: {valor}. El resultado es: {MiCalculadora.Resultado}");
                }
                else
                {
                    Console.WriteLine("Valor Ingresado Incorrecto");
                }
            break;
            case 4:
                Console.WriteLine("Ingrese un valor para dividir");
                if (double.TryParse(Console.ReadLine(), out valor))
                {
                    if (valor != 0)
                    {
                        MiCalculadora.Dividir(valor);
                        Console.WriteLine($"Se dividio por {valor}. El resultado es: {MiCalculadora.Resultado}");
                    }
                    else
                    {
                        Console.WriteLine("Valor Ingresado Incorrecto ingreso 0 (no se puede dividir por 0)");
                    }
                }
                else
                {
                    Console.WriteLine("Valor Ingresado Incorrecto");
                }
            break;
            case 5:
                MiCalculadora.Limpiar();
                Console.WriteLine($"Se limpio el resultado: {MiCalculadora.Resultado}");
            break;
            default:
            break;
        }
    }
    else{
        Console.WriteLine("Opcion ingresada incorrecta");
    }
    Console.WriteLine("Desea continuar operando? : 1 - Si");
    opcion = Convert.ToInt32(Console.ReadLine());
} while (opcion == 1);
*/


//Ejercicio 2

using EspacioPersonal;
Empleados[] arregloEmpledos = new Empleados();

