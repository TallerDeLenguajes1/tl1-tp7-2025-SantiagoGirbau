namespace SisPersonal{
    //using time;
    public class Empleado{

        public Empleado(string nombreIngresado, string apellidoIngresado){
            this.nombre = nombreIngresado;
            this.apellido = apellidoIngresado;
        }

        private string nombre;
        private string apellido;
        //private datetime fechaDeNacimiento;
        private char estadoCivil;
        //private datetime ingreso;
        private double sueldoBasico;
        //private cargos cargo;

        public string Nombre {get => nombre; set => nombre = value;}
        public string Apellido {get => apellido; set => apellido = value;}

        //Empleado();
    }


}