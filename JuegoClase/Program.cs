using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JuegoClase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HELLO WORLD, YO SOY UN PROGRAMADOR Y EXPERTO EN REDES EXCELENTE Y RECONOCIDO...");
            //Creamos instancias de la estructura Cliente
            Cliente cliente1 = new Cliente();
            cliente1.nombre = "LARRYSALSA";
            cliente1.edad = 45;
            cliente1.direccion = "Marroquin 1";

            Cliente cliente2 = new Cliente();
            cliente2.nombre = "JENNIFER";
            cliente2.edad = 18 ;
            cliente2.direccion = "Troncal";

            //Console.WriteLine(cliente1.ToString());

            //Console.WriteLine(cliente2.ToString());

            //Instanciamos a la clase RegistroClientes
            RegistroClientes registro1 = new RegistroClientes();

            //Registrar clientes a travez del metodo
            registro1.RegistrarCliente(cliente1);
            registro1.RegistrarCliente(cliente2);

            //Mostrar lista de clientes registrados
            registro1.MostrarClientesRegistrados();

        }
    }
   
  struct Cliente
    {

        public string nombre;
        public int edad;
        public string direccion;

        /*public override string ToString()
        {
            string mensaje;
            mensaje = $"Nombre: {nombre} \nEdad: {edad} \nDireccion: {direccion} ";
            return mensaje;
        }*/

    }
    class RegistroClientes
    {
        //Declaramos una lista generica para guardar a los clientes
        List<Cliente> listaClientes = new List<Cliente>();

        //Metodo para registrar clientes
        public void RegistrarCliente(Cliente clientePa)
        {
            listaClientes.Add(clientePa);


        }

        //Metodo para mostrar clientes
        public void MostrarClientesRegistrados()
        {
            Console.WriteLine("Lista de clientes registrados:\n");
            Console.WriteLine("------------------------------------");
            foreach (var elemento in listaClientes)
            {
                Console.WriteLine($"Nombre: {elemento.nombre}");
                Console.WriteLine($"Edad: {elemento.edad}");
                Console.WriteLine($"Direccion: {elemento.direccion}");
                Console.WriteLine("------------------------------------");
            }
        }

    }
    
}
