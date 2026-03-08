using System.Diagnostics;
using Exemplo_01.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exemplo_01.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //-----------------------------------------------------------------------------------------------------------------------------------

        [HttpGet]
        public IActionResult Variables()
        {
            string retorno = string.Empty;

            //escrita implicita
            int userCount = 10;

            //Tipo de anotacao
            int totalUsers;
            totalUsers = 20;

            //Constante
            const int interestRate = 5;

            retorno += $"Contagem de usuarios: {userCount}\n";
            retorno += $"Total de usuarios: {totalUsers}\n";
            retorno += $"Taxa de juros: {interestRate}%\n";

            return View("Variables", retorno);
        }

        //-----------------------------------------------------------------------------------------------------------------------------------

        [HttpGet]
        public IActionResult PersonalData()
        {
            string retorno = string.Empty;

            //Nome
            string name = "Bruno Furlan";

            //Data Nascimento
            string birthDate = "19/01/1996";

            //Idade
            int age = 30;

            //Altura
            float height = 1.92f;

            retorno += $"Nome: {name}\n";
            retorno += $"Data de Nascimento: {birthDate}\n";
            retorno += $"Idade: {age}\n";
            retorno += $"Altura: {height}m\n";

            return View("PersonalData", retorno);
        }

        //-----------------------------------------------------------------------------------------------------------------------------------

        [HttpGet]
        public async Task<IActionResult> Numbers()
        {
            string retorno = string.Empty;

            retorno += $"Valor máximo para int: {int.MaxValue}<br/>";
            retorno += $"Valor mínimo para int: {int.MinValue}<br/>";
            retorno += $"Valor máximo para double: {double.MaxValue}<br/>";
            retorno += $"Valor mínimo para double: { double.MinValue}<br/>";
            retorno += $"Valor máximo para decimal: {decimal.MaxValue}<br/>";
            retorno += $"Valor mínimo para decimal: {decimal.MinValue}<br/>";
            retorno += $"Valor máximo para long: {long.MaxValue}<br/>";
            retorno += $"Valor mínimo para long: {long.MinValue}<br/>";
            retorno += $"Valor máximo para float: {float.MaxValue}<br/>";
            retorno += $"Valor mínimo para float: {float.MinValue}<br/>";
            retorno += $"Valor máximo para byte: {byte.MaxValue}<br/>";
            retorno += $"Valor mínimo para byte: {byte.MinValue}<br/>";
            retorno += $"Valor máximo para short: {short.MaxValue}<br/>";
            retorno += $"Valor mínimo para short: {short.MinValue}<br/>";
            retorno += $"Valor máximo para sbyte: {sbyte.MaxValue}<br/>";
            retorno += $"Valor mínimo para sbyte: {sbyte.MinValue}<br/>";
            retorno += $"Valor máximo para uint: {uint.MaxValue}<br/>";
            retorno += $"Valor mínimo para uint: {uint.MinValue}<br/>";


            return View("Numbers", retorno);
        }

        //-----------------------------------------------------------------------------------------------------------------------------------

        [HttpGet]
        public async Task<IActionResult> Dictionary()
        {
            Dictionary<int, string> data = [];

            for(int i = 1; i <= 10; i++)
            {
                data.Add(i, $" Valor {i}");
            }

            return View("Dictionary", data);
        }

        //-----------------------------------------------------------------------------------------------------------------------------------

        public IActionResult Privacy()
        {
            return View();
        }

        //-----------------------------------------------------------------------------------------------------------------------------------

        [HttpGet]
        public IActionResult MediaFinal()
        {
            Dictionary<string, double> Notas = new Dictionary<string, double>();
            {
                Notas.Add("Cleber Meireles", 7.3);
                Notas.Add("Bruno Furlan", 8.5);
                Notas.Add("Maria Silva", 2.0);
                Notas.Add("João Santos", 6.8);
                Notas.Add("Ana Oliveira", 7.2);
                Notas.Add("Carlos Pereira", 2.9);
                Notas.Add("Fernanda Costa", 7.5);
                Notas.Add("Ricardo Almeida", 6.5);
                Notas.Add("Juliana Rodrigues", 4.0);
            };

            var maiorNota = Notas.Values.Max();
            var menorNota = Notas.Values.Min();
            var media = Notas.Values.Average();

            int aprovados = 0;
            int reprovados = 0;
            int exame = 0;

            foreach (var item in Notas)
            {
                if (item.Value >= 7.0)
                    aprovados++;

                else if (item.Value < 5.0)
                    reprovados++;

                else
                    exame++;
            }

            Dictionary<string, string> Resumo = new Dictionary<string, string>()
            {
                {"Maior Nota", maiorNota.ToString()},
                {"Menor Nota", menorNota.ToString()},
                {"Média", media.ToString()},
                {"Aprovados", aprovados.ToString()},
                {"Reprovados", reprovados.ToString()},
                {"Em Exame", exame.ToString()}
            };

            return View("MediaFinal", Resumo);
        }

        //-----------------------------------------------------------------------------------------------------------------------------------


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
