namespace EspacioPersonal
{
    public class Empleado
    {
        private string nombre;
        private string apellido;
        private DateTime nacimiento;
        private char estadoCivil;
        private DateTime ingresoEmpresa;
        private double sueldoBasico;
        private Cargos cargo;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime Nacimiento { get => nacimiento; set => nacimiento = value; }
        public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public DateTime IngresoEmpresa { get => ingresoEmpresa; set => ingresoEmpresa = value; }
        public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
        public Cargos CargoEmpleado { get => cargo; set => cargo = value; }

        public enum Cargos
        {
            Auxiliar,        // 0
            Administrativo,  // 1
            Ingeniero,       // 2
            Especialista,    // 3
            Investigador     // 4
        }

        public int CalcularAntiguedad(){
            DateTime Actual  = DateTime.Now; //se crea una fecha actual
            int ant = Actual.Year - ingresoEmpresa.Year; //se calcula la antiguedad
            if(ingresoEmpresa.Month > Actual.Month) --ant; //si todavia o es el es del ingrreso a la empresa se resta un año de antiguedad
            return ant; //se devuelve la antiguedad
        }

        public int CalculcularEdad(){
            DateTime Actual  = DateTime.Now; //se crear fecha actual
            int edad  = Actual.Year - nacimiento.Year; //calculo de edad
            if(nacimiento.Month > Actual.Month) --edad; //si todavia no es el mes de nacimiento se resta un año a la edad
            return edad; //se devuelve la edad
        }

        public int CalcularAniosParaJub(){
            return (65 - CalculcularEdad()); //se devuelven los años faltantespara jubilarse
        }

        public double CalcularAdicional(){
            double adicional = 0;
            int antiguedad = CalcularAntiguedad();

            if(antiguedad <=20){
                adicional = sueldoBasico * ((0.01)*antiguedad); //hasta los 20 años el 1 % del sueldo basico por ada año de antiguedad
            }
            else
            {
                adicional += sueldoBasico * 0.25; //gana un 25% adicional de su sueldo básico independientemente de los años adicionales que siga trabajando. (se fija en un 25%)
            }

            if(cargo == Cargos.Ingeniero || cargo == Cargos.Especialista){
                adicional *= 1.50; //el adicional se incrementa en un 50%
            }

            if(EstadoCivil == 'c' || EstadoCivil == 'C'){
                adicional+=150000; //si es casado se aumenta $150.000
            }
            return adicional; //retorna el adicional
        }

        public double CalcularSalario(){            
            return sueldoBasico + CalcularAdicional(); //retorna salario
        }
        
        //metodo constructor
        public Empleado(string nombre, string apellido, DateTime nacimiento, char estadoCivil, DateTime ingresoEmpresa, double sueldoBasico, Cargos cargo){
            Nombre = nombre;
            Apellido = apellido;
            Nacimiento = nacimiento;
            EstadoCivil = estadoCivil;
            IngresoEmpresa = ingresoEmpresa;
            SueldoBasico = sueldoBasico;
            CargoEmpleado = cargo;
        }
    }
}
