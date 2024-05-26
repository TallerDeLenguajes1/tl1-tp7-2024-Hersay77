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

// arreglo de Empleado
Empleado[] empleados = new Empleado[] //creo un arrgelo de tipos clase Empleado y reservo memoria apra el mismo a la vez que lo inciialzo, y cada empleado lo cargo con el metodo constructor de empleado ( inicializo el arreglo y crea los objetos al mismo tiempo)
{
    new Empleado("Empleado", "Prueba", new DateTime(1960, 10, 26), 'C', new DateTime(2009, 2, 12), 650000, Empleado.Cargos.Ingeniero),//empleados[0]
    new Empleado("Aquiles", "Bailo", new DateTime(1980, 1, 1), 'C', new DateTime(2010, 1, 1), 650000, Empleado.Cargos.Administrativo),//empleados[1]
    new Empleado("Yo", "Merengues", new DateTime(1965, 4, 10), 'C', new DateTime(2000, 2, 20), 650000, Empleado.Cargos.Especialista)//empleados[2]
};


double montoTotal = 0;
int aniosParaJub, menosAnios = 0;
Empleado emp  = empleados[0];

foreach (var empleado in empleados)
{
    montoTotal += empleado.CalcularSalario();
    aniosParaJub  = empleado.CalcularAniosParaJub();
    if (aniosParaJub <= menosAnios)
    {
        menosAnios = aniosParaJub; //guardo la cantidad de menos años
        emp = empleado; //guardo los datos del empleado con menos años
    }
}

Console.WriteLine("El monto total en concepto de Salarios es: $" + montoTotal);
Console.WriteLine("Datos de empleado con menos anios para jubilarse: ");
Console.WriteLine("Nombre y Apellido: " + emp.Nombre + " " + emp.Apellido);
Console.WriteLine("Nacimiento: "+ emp.Nacimiento);
Console.WriteLine("Estado Civil (C: casado, S: soltero): "+ emp.EstadoCivil);
Console.WriteLine("Ingreso a la empresa: " + emp.IngresoEmpresa);
Console.WriteLine($"Sueldo Basico: $ {emp.SueldoBasico}" );
Console.WriteLine("Cargo: " + emp.CargoEmpleado);
Console.WriteLine($"Antiguedad: {emp.CalcularAntiguedad()}");
Console.WriteLine($"Edad del empleado: {emp.CalculcularEdad()}");
Console.WriteLine($"Anios que faltan para jubilarse: {emp.CalcularAniosParaJub()}");
Console.WriteLine($"Salario correspondiente: $ {emp.CalcularSalario()}");



