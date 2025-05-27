namespace EspacioCalculadora
{
    public class Calculadora{
        private double dato;
        private double resultado = 0;

        public double Resultado { get => resultado; }
        public double Dato { get => dato; set => dato = value; }

        public void Sumar(double termino){
            dato += dato;
        }

        public void Restar(double termino){
            dato -= dato;
        }
    }
}