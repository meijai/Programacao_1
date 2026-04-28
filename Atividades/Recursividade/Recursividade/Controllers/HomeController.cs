using Microsoft.AspNetCore.Mvc;
using Recursividade.Models;
using System.Diagnostics;

namespace Recursividade.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public double Factorial(int number = 10)
        {
            if (number == 0)
                return 1;

            double factorial = 1;
            for (int i = number; i >= 1; i--)
            {
                factorial = factorial * i;
            }
            return factorial;
        }

        public double RecursiveFactorial(int number)
        {
            //Caso base: O fatorial de 0 é 1
            if (number == 0)
                return 1;

            //Chamada recursiva
            return number * RecursiveFactorial(number - 1);
        }

        public string NaturalNumberRecursion(int n, int count)
        {
            string ret = string.Empty;

            //Caso base: Se o contador for menor que 1
            if (count <= 1)
                return $" {n} ";

            ret += $" {n} ";
            count--; //Decrementa count

            //Chamada recursiva: Incrementa n e decrementa count
            //Para imprimir o numero
            ret += NaturalNumberRecursion(n + 1, count);

            return ret;
        }

        public string Factorial2(int number = 10)
        {
            if (number <= 1) return $" {number} ";

            int factorial = 1;
            string factorialString = string.Empty;
            for (int i = number; i >= 1; i--)
            {
                factorial = factorial * i;
                factorialString += $" {i} ";
            }
            return factorialString;
        }

        public string PrintNaturalRecursion(int count = 10)
        { 
            return NaturalNumberRecursion(1, count);
        }
    }
}
