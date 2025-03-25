using contactos_POO.contactos;






Agenda agenda = new Agenda();
bool ejecutando = true;



Console.WriteLine("Mi Agenda Perrón");
Console.WriteLine("Bienvenido a tu lista de contactes");




while (ejecutando)
{
    Console.WriteLine("1. Agregar Contacto    2. Ver Contactos    3. Buscar Contacto");
    Console.WriteLine("4. Modificar Contacto  5. Eliminar Contacto  6. Salir");
    Console.Write("Elige una opción: ");

    if (int.TryParse(Console.ReadLine(), out int opcion))
    {


        switch (opcion)
        {

            case 1:
                agenda.AgregarContacto();
                break;
            case 2:
                agenda.VerContactos();
                break;
            case 3:
                agenda.BuscarContacto();
                break;
            case 4:
                agenda.EditarContacto();
                break;
            case 5:
                agenda.EliminarContacto();
                break;
            case 6:
                ejecutando = false;
                break;
            default:
                Console.WriteLine("Opción no válida\n");
                break;
        }
    }

    else
    {
        Console.WriteLine("Por favor, ingrese un número válido\n");
    }
}

Console.WriteLine("¡Adioa!");