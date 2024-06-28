using System;
using System.Collections.Generic;

// declaro el  delegado
public delegate void NotificacionHandler(string mensaje);

public class SistemaDeMensajes
{
    
    public event NotificacionHandler NuevaNotificacion;

    // aqui le digo que si redivi el mensaje
    public void RecibirMensaje(string mensaje)
    {
        Console.WriteLine("Mensaje recibido: " + mensaje);
        // si la notificacion no es nula, entonces la notificacion es igual al mensaje
        (NuevaNotificacion != null)? NuevaNotificacion(mensaje): null;
    }
}

//aqui notificare
public class ComponentA
{
    // Metodo que coinside con la firma del delegado
    public void Notificar(string mensaje)
    {
        Console.WriteLine("ComponentA notificado: " + mensaje);
    }
}
public class ComponentB
{
    //conside con la firma
    public void Notificar(string mensaje)
    {
        Console.WriteLine("ComponentB notificado: " + mensaje);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        //creo una isntantancia para crear un mensaje y recibirlo
        SistemaDeMensajes sistemaDeMensajes = new SistemaDeMensajes();

        // Crear instancias de los componentes
        ComponentA compA = new ComponentA();
        ComponentB compB = new ComponentB();

        // aqui sampo el metodo "NOTIFICAR" al objeto compA al evento de la nueva nogtificacion, y eso 
        // se disparara cuando el metodo notificar del obj sea llamdo es similar para ls dos
        sistemaDeMensajes.NuevaNotificacion += compA.Notificar; 

        sistemaDeMensajes.NuevaNotificacion += compB.Notificar;

        sistemaDeMensajes.RecibirMensaje("HOLAAAA WWWWWWWWWWWWEEEEEEEEEEEEEEEEE");
        Console.ReadLine();
    }
}

