using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contactos_POO.contactos
{
    class Contacto
    {
        
    public int Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }

        public Contacto(int id, string nombre, string telefono, string email, string direccion)
        {
            Id = id;
            Nombre = nombre;
            Telefono = telefono;
            Email = email;
            Direccion = direccion;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"{Id}    {Nombre}    {Telefono}    {Email}    {Direccion}");
        }
    }

    // AQUI YO MANEJARE LA AGENDA DE CONTACTOS
    class Agenda
    {
        private List<Contacto> contactos = new List<Contacto>();

        public void AgregarContacto()
        {
            int id = contactos.Count + 1;

            Console.Write("Digite el Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Digite el Teléfono: ");
            string telefono = Console.ReadLine();

            Console.Write("Digite el Email: ");
            string email = Console.ReadLine();

            Console.Write("Digite la Dirección: ");
            string direccion = Console.ReadLine();

            contactos.Add(new Contacto(id, nombre, telefono, email, direccion));

            Console.WriteLine("¡Contacto agregado con éxito!\n");
        }

        public void VerContactos()
        {
            Console.WriteLine("Id    Nombre    Teléfono    Email    Dirección");
            Console.WriteLine("------------------------------------------------");
            foreach (var contacto in contactos)
            {
                contacto.MostrarInformacion();
            }
        }

        public void BuscarContacto()
        {
            Console.Write("Digite el Id del contacto a buscar: ");
            int id = Convert.ToInt32(Console.ReadLine());

            var contacto = contactos.Find(c => c.Id == id);

            if (contacto != null)
            {
                contacto.MostrarInformacion();
            }
            else
            {
                Console.WriteLine("¡Contacto no encontrado!\n");
            }
        }

        public void EditarContacto()
        {
            VerContactos();
            Console.Write("Digite el Id del contacto a editar: ");
            int id = Convert.ToInt32(Console.ReadLine());

            var contacto = contactos.Find(c => c.Id == id);

            if (contacto != null)
            {
                Console.Write("Nuevo Nombre: ");
                contacto.Nombre = Console.ReadLine();

                Console.Write("Nuevo Teléfono: ");
                contacto.Telefono = Console.ReadLine();

                Console.Write("Nuevo Email: ");
                contacto.Email = Console.ReadLine();

                Console.Write("Nueva Dirección: ");
                contacto.Direccion = Console.ReadLine();

                Console.WriteLine("¡Contacto actualizado con éxito!\n");
            }
            else
            {
                Console.WriteLine("¡Contacto no encontrado!\n");
            }
        }

        public void EliminarContacto()
        {
            VerContactos();
            Console.Write("Digite el Id del contacto a eliminar: ");
            int id = Convert.ToInt32(Console.ReadLine());

            var contacto = contactos.Find(c => c.Id == id);

            if (contacto != null)
            {
                contactos.Remove(contacto);
                Console.WriteLine("¡Contacto eliminado con éxito!\n");
            }
            else
            {
                Console.WriteLine("¡Contacto no encontrado!\n");
            }
        }
    }
}