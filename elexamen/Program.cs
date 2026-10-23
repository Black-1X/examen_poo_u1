using elexamen.Ejercicios;

int n=0;
while (n!=3)
{
    Console.WriteLine("----------------------------------");
    Console.WriteLine("Ingrese el ejercicio que desea ver");
    Console.WriteLine("1. Cotizador de envíos");
    Console.WriteLine("2. Simulador de carga de combustible");
    Console.WriteLine("3. Salir");
    int.TryParse(Console.ReadLine(), out n);
    switch (n)
    {
        case 1:
            Eje01 eje01 = new Eje01();
            eje01.Cotizador();
            break;
        case 2:
            Eje02 eje02 = new Eje02();
            eje02.Simulador();
            break;
        case 3:
            Console.WriteLine("Gracias por ver :D");
            break;
        default:
         break;
    }
}