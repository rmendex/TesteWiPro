using MoedaCotacaoClient.Controllers;
using MoedaCotacaoClient.Entidades;
using Nito.AsyncEx;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MoedaCotacaoClient
{
    class Program
    {
        public static string URI = "https://localhost:44374/api/item/obteritem";
        static ClienteController clienteController = new ClienteController();

        static void Main(string[] args)
        {
            while (true)
            {
                AsyncContext.Run(() => MainAsync(args)); 
            }
        }

        static async void MainAsync(string[] args)
        {
            while(true)
            {

                var stopwatch = new Stopwatch();
                stopwatch.Start();

                Console.WriteLine("Verificando itens na Fila");

                var item = await clienteController.ObterProxItem(URI);

                if (item == null || item.ID == 0)
                {
                    Console.WriteLine("A fila está vazia!");
                    Console.WriteLine();
                }

                else
                {
                    Console.WriteLine("Obtendo Dados Moeda");
                    var lstDadosMoeda = clienteController.ObterDadosMoeda(item);

                    Console.WriteLine("Obtendo Dados Cotação");
                    var lstDadosCotacao = clienteController.ObterDadosCotacao();

                    Console.WriteLine("Realizando DePara e extraindo dados");
                    clienteController.MontarDePara(lstDadosMoeda, lstDadosCotacao);

                    stopwatch.Stop();
                    Console.WriteLine($@"Execução finalizada em: {stopwatch.Elapsed}");
                    Console.WriteLine();
                }
                Thread.Sleep(TimeSpan.FromMinutes(2));
            }
        }
    }
}
