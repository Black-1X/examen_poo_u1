
namespace elexamen.Ejercicios
{
    public class Eje02
    {
        public void Simulador()
        {
            double precio=0, subtotal, total, descuento;
            int i=5;
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Ingrese el tipo de combustible:");
            Console.WriteLine("1 = regular");
            Console.WriteLine("2 = premium");
            Console.WriteLine("3 = diésel");
            int.TryParse(Console.ReadLine(), out int type);
            if (type>3||type<1)
            {
                Console.Write("Tipo no valido");
                return;
            }
            /*Regular: L. 28.50. Premium: L. 32.00. Diésel: L. 26.75.*/
            switch (type)
            {
                case 1:
                    precio=28.50;
                    break;
                case 2:
                    precio=32.00;
                    break;
                case 3:
                    precio=26.75;
                    break;
                default:
                    break;
            }
            Console.WriteLine("Ingrese la cantidad de litros que desea maximo 60:");
            int.TryParse(Console.ReadLine(), out int lts);
            if (lts>60||lts<1)
            {
                Console.WriteLine("Cantidad no valida");
                return;
            }
            while (i<=lts)
            {
                Console.WriteLine($"Cantidad de litros cargados: {i}");
                i=i+5;
            }
            subtotal = precio*lts;
            if (subtotal>=1500.00)
            {
                descuento= subtotal/100*5;
            }else if (subtotal>=1000.00)
            {
                descuento = subtotal/100*3;
            }
            else
            {
                descuento=0;
            }
            total=subtotal-descuento;
            Console.WriteLine($"Total de litros: {lts}");
            Console.WriteLine($"Subtotal: {subtotal:F2}");
            Console.WriteLine($"Descuento: {descuento:F2}");
            Console.WriteLine($"Total a pagra: {total:F2}");




        }
    }
}