namespace EspacioCalculadora
{

    public class MiCalculadora
    {
        private double dato = 0;

        public double Resultado{
            get => dato;
        }

        /*public Calculadora(int valorInicial){ //constructor se incializa en valor indicado
            dato = valorInicial;
        }   
        
        public Calculadora(){ //constructor incializa en 0
            dato = 0;
        }*/

        public void Sumar(double x){
            dato+=x;
        }
        public void Restar(double x){
            dato-=x;
        }
        public void Multiplicar(double x){
            dato*=x;
        }
        public void Dividir(double x){
            if (x != 0)
            {
                dato/=x;
            }
        }
        public void Limpiar(){
            dato = 0;
        }
    }


    

}