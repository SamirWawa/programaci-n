 public class Empleado
    {
        private readonly string  dni;
        private readonly string nombre;
        private readonly int añoNacimiento;
        public const int SALARIO_BASE=1200;
        Categoria categoria;
        public enum Categoria
        {
            Subalterno=10, Administrativo=20, JefeDepartamento=40, Gerente=60
        }
        public Empleado(in string dni, in string nombre, in int nacimiento, Categoria categoria)
        {
            this.dni=dni;
            this.nombre=nombre;
            this.añoNacimiento=nacimiento;
        }
        public Empleado(in Empleado e)
        {
            dni=e.dni;
            nombre=e.nombre;
            añoNacimiento=e.añoNacimiento;
        }
        public string GetNombre()
        {
            return nombre;
        }
        public int GetAñoNacimiento()
        {
            return añoNacimiento;
        }
        public string GetDni()
        {
            return dni;
        }
        public void SetCategoria(Categoria categoria)
        {
            this.categoria=categoria;
        }
        public double Salario()
        {
            return SALARIO_BASE+SALARIO_BASE*(int)categoria/100;
        }
        public string ACadena()
        {
            return $"El empleado {nombre} con dni: {dni} tiene un salario {Salario()} y su categoria {categoria}";
        }
    }
    class Empresa
    {
        private readonly string cif;
        private readonly string razonSocial;
        private string direccion;
        private Empleado[] empleados;
        public Empresa(in string cif, in string razonSocial, in string direccion)
        {
            this.cif=cif;
            this.razonSocial=razonSocial;
            this.direccion=direccion;
            empleados=new Empleado[1];
        }
        public Empresa(in Empresa e)
        {
            cif=e.cif;
            razonSocial=e.razonSocial;
            direccion=e.direccion;
        }
        public string NombreGerente()
        {
            return empleados[0].GetNombre();
        }
        public string GetDireccion()
        {
            return direccion;
        }
        public string GetRazonSocial()
        {
            return razonSocial;
        }
        public string GetCif()
        {
            return cif;
        }
        public void AñadeGerente(in string dni, in string nombre, in int añoNacimiento)
        {
            empleados[0]=new Empleado(dni, nombre, añoNacimiento, Empleado.Categoria.Gerente);
            Array.Resize(ref empleados, empleados.Length+1);
        }
        public void SetDireccion(in string direccion)
        {
            this.direccion=direccion;
        }
        public string DatosEmpresa()
        {
            return $"La empresa Empresa {cif}\n{NombreGerente()}\n{razonSocial}\n{direccion}";
        }
        public Empleado[] GetEmpleados(Empleado[] empleado)
        {
            return empleado;
        }
        public void Contrata(in string dni, in string nombre, in int añoNacimiento,Empleado.Categoria categoria)
        {
            Empleado c=new Empleado(dni, nombre, añoNacimiento, categoria);
            Array.Resize(ref empleados, empleados.Length+1);
            empleados[empleados.Length-1]=c;
        }
        public string ACadena()
        {
            string cadena = $"{DatosEmpresa()}";
            foreach(Empleado empleado in empleados)
                cadena+=$"{empleado.ACadena()}\n";
            return cadena;
        }
    }
    internal class Program
{
    static void Main(string[] args)
        {
         
           //  Se manda la información para crear las instancias directamente en los métodos correspondientes
            Empresa empresa = new Empresa("La Empresa S.L", "C23456732A", "Calle el Pozo, 34 Bajo");
            empresa.AñadeGerente("6541324F", "Pipo", 2);
            empresa.Contrata("14568712G", "Juanma Perez Ortiz", 1990, Empleado.Categoria.Administrativo);
            empresa.Contrata("12346123K", "Pedro Martinez Sancho", 1999, Empleado.Categoria.Administrativo);
            Console.WriteLine(empresa.ACadena());
           
        }
}