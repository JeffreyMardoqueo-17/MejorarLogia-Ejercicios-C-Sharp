﻿using POOPractice;

Jeffrey jeffrey = new Jeffrey();

Console.WriteLine("Ingrese su nombre: ");
jeffrey.Nombre = Console.ReadLine();

Console.WriteLine("Ingrese su apellido: ");
jeffrey.Apellido = Console.ReadLine();

Console.WriteLine("Ingrese su edad: ");
jeffrey.Edad = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese su carrera: ");
jeffrey.Carrera = Console.ReadLine();

Console.WriteLine("Ingrese el nombre de su novia: ");
jeffrey.Novia = Console.ReadLine();

jeffrey.MostrarInfo();
jeffrey.Estudiar();