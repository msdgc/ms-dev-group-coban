using System;
using System.Threading;
using System.Threading.Tasks;

namespace demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Iniciamos un Task, ya que el método Void no es asíncrono.
            Task.Run(async() =>{
                // Creamos el objeto pedido
                Pedido oPedido = new Pedido();

                // Realizamos una llamada asíncrona mediante un Task
                Task<bool> etapa1 = oPedido.tarea1();

                //Realizamos una llamada síncrona
                oPedido.tarea2();

                //Esperamos el retorno de la llamada asíncrona, sin embargo la ejecución general contínua.
                bool resultado = await etapa1;
            }).GetAwaiter().GetResult();
        }
    }
}
