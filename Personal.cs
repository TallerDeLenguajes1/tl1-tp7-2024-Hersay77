namespace EspacioPersonal
{
    public class Empleados
    {
        private string nombre;

        private string apellido;

        private datetime nacimiento;

        private char estadoCivil;

        private datetime ingreso;

        private double sueldoBasico;

        


        public enum Cargo
        {
            Auxiliar,        // 0
            Administrativo,  // 1
            Ingeniero,       // 2
            Especialista,    // 3
            Investigador     // 4
        }

        public Empleados();
    }

    
}