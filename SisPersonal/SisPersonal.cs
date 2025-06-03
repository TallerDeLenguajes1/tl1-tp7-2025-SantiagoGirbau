namespace SisPersonal{

    public class Empleado
    {


        private string nombre;
        private string apellido;
        private DateTime fechaDeNacimiento;
        private char estadoCivil;
        private DateTime ingreso;
        private double sueldoBasico;

        public enum Cargo
        {
            Administrativo = 0, Ingeniero = 1, Especialista = 2, Investigador = 3
        };
        private Cargo cargo;

        public Empleado(string nombreIngresado, string apellidoIngresado, DateTime fechaNac, char estadoCivilIngresado, DateTime fechaDeIngreso, double sueldo, Cargo cargoIngresado)
        {
            this.nombre = nombreIngresado;
            this.apellido = apellidoIngresado;
            this.fechaDeNacimiento = fechaNac;
            this.estadoCivil = estadoCivilIngresado;
            this.ingreso = fechaDeIngreso;
            this.sueldoBasico = sueldo;
            this.cargo = cargoIngresado;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        public int Edad()
        {
            if (System.DateTime.Today.Month > fechaDeNacimiento.Month)
            {
                return System.DateTime.Today.Year - fechaDeNacimiento.Year + 1;
            }
            if (System.DateTime.Today.Month == fechaDeNacimiento.Month && System.DateTime.Today.Day >= fechaDeNacimiento.Day)
            {
                return System.DateTime.Today.Year - fechaDeNacimiento.Year + 1;
            }
            return System.DateTime.Today.Year - fechaDeNacimiento.Year;
        }

        public int Jubilarse()
        {
            return 65 - Edad();
        }

        public int Antiguedad()
        {
            if (System.DateTime.Today.Month > ingreso.Month)
            {
                return System.DateTime.Today.Year - ingreso.Year + 1;
            }
            if (System.DateTime.Today.Month == ingreso.Month && System.DateTime.Today.Day >= ingreso.Day)
            {
                return System.DateTime.Today.Year - ingreso.Year + 1;
            }
            return System.DateTime.Today.Year - ingreso.Year;
        }

        public double salarioFinal()
        {
            int antiguedad = Antiguedad();
            double adicional;
            if (antiguedad < 20)
            {
                adicional = 0.01 * antiguedad;
            }
            else
            {
                adicional = 0.25;
            }

                Console.WriteLine(adicional);
            if (cargo == Cargo.Ingeniero || cargo == Cargo.Especialista)
            {
                adicional *= 1.5;
            }
                Console.WriteLine(adicional);
            if (estadoCivil == 'c' || estadoCivil == 'C')
            {
                return sueldoBasico * (1+adicional) + 150000;
            }
            else
            {
                return sueldoBasico * (1+adicional);
            }
        }
    }


}