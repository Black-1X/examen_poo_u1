/*Cotizador de envios*/
namespace elexamen.Ejercicios
{
    public class Eje01
    {
        public void Cotizador()
        {

            decimal prezone=0, recargo, descuento=0, seguro=0, servicio=0, subtotal, total;
            Console.WriteLine("Ingrese el nombre del cliente:");
            string name = Console.ReadLine();


            Console.WriteLine("Seleccione una zona:");
            Console.WriteLine("1 = local");
            Console.WriteLine("2 = departamental");
            Console.WriteLine("3 = nacional");
            int.TryParse(Console.ReadLine(), out int zone);

            if (zone>3 || zone<1)
            {
                Console.WriteLine("Zona no valida");
                return;
            }
            switch (zone)
            {
                case 1:
                    prezone = 60; 
                    break;
                case 2:
                    prezone = 100;
                    break;
                case 3:
                    prezone=150;
                    break;
                default:
                    break;

            }

            Console.WriteLine("Ingrese el peso en kilogramos:");
            decimal peso = Convert.ToDecimal(Console.ReadLine());
            if (peso<=0)
            {
                Console.WriteLine("Ingrese un peso real");
                return;
            }

            if (peso<=1)
            {
                recargo= 0;
            }else if(peso<=5)
            {
                recargo = 40;
            }else if (peso<=10)
            {
                recargo = 80;
            }else
            {
                recargo = 140;
            }

            Console.WriteLine("Ingrese el tipo de servicio:");
            Console.WriteLine("1 = estándar");
            Console.WriteLine("2 = express");
            Console.WriteLine("3 = mismo día");
            int.TryParse(Console.ReadLine(), out int type);
             if (type>3 || type<1)
            {
                Console.WriteLine("Tipo de servicio no valido");
                return;
            }

            switch (type)
            {
                case 1:
                    servicio = (prezone+recargo)/100*0;
                    break;
                case 2:
                    servicio = (prezone+recargo)/100*25;
                    break;
                case 3:
                    servicio=(prezone+recargo)/100*50;
                    break;
                
                default:
                    break;
            }

            Console.WriteLine("Ingrese el valor declarado del paquete:");
            decimal valor = Convert.ToDecimal(Console.ReadLine());
            if (valor<0)
            {
                Console.WriteLine("El valor no puede ser negativo");
                return;
            }
            if (valor>=5000)
            {
                valor+=valor/100*2;
            }

            subtotal = prezone+ recargo + servicio + valor + seguro;
            if (subtotal>=700)
            {
                descuento = subtotal/100*5;
            }
            total = subtotal-descuento;
            Console.WriteLine($"Su total a pagar es de: {total}");

            /*● Zona 1 (local): L. 60.00; zona 2 (departamental): L. 100.00; zona 3 (nacional): L. 150.00.
● Recargo por peso: hasta 1 kg, L. 0.00; más de 1 y hasta 5 kg, L. 40.00; más de 5 y hasta 10 kg, L. 80.00; más de 10 kg, L. 140.00.
● Servicio: estándar +0%; express +25%; mismo día +50% sobre la suma de la base y el recargo por peso.
● Seguro: si el valor declarado supera L. 5,000.00, agregue el 2% de ese valor.
● Descuento: si el subtotal supera L. 700.00, aplique 5%.*/


 /*Valide la zona (1 a 3), el peso (mayor que cero), el tipo de servicio (1 a 3) y el valor declarado (mayor o igual que cero).
● Use decimal para todos los montos, switch para la zona y el servicio, y if/else para el peso, el seguro y el descuento.
● Use el operador ternario para mostrar «Envío asegurado» o «Envío sin seguro».
● Muestre un recibo con el detalle de cada concepto y el total a pagar, con dos decimales y formato de moneda.*/
        












        }
    }
}