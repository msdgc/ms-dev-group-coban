using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace demo1
{
    public class Pedido
    {
        // Creamos un método asíncrono.
        public async Task<bool> tarea1(){
            Console.WriteLine("Envío de sms");

            HttpClient llamada = new HttpClient();
            await llamada.GetAsync("https://google.es");

            Console.WriteLine("Se envío sms");
            return true;
        }

        // Creamos un método síncrono
        public void tarea2(){
            Console.WriteLine("Mostrar pedido en cocina");
            Thread.Sleep(500);
            Console.WriteLine("Cocina ha empezado preparación");
        }
    }
}