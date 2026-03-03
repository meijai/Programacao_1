using Microsoft.AspNetCore.Mvc;

namespace Exemplo_01.Controllers
{
    public class OperatorsController : Controller
    {
        public IActionResult Index()
        {
            //Aritméticos
            int y = -10; // = É operador unario de atribuicao
            int x = 2; 
            int z = y - x;

            //Precedência
            int xx = 10 - 20 * 10;
            // Neste caso o c# já conhece a regra de precedencia dos operadores aritmeticos
            // No entanto, se eu desejar manipular a ordem da operacoes, podemos usar ()
            int yy = (10 - 20) * 10;

            // Operadores de composicao
            int xXx = 10;
            int yXy = 20;
            xXx += yXy;
            xXx = xXx + yXy;

            // Operadores de incremento e Decremento

            // Podemos incrementar de forma original
            int luiz = x + 1;
            luiz = x++; // Incrementando
            luiz = x--; // Decrementando 

            // No entando existe outra forma de controlar a precedencia do incremento e decremento
            // Se eu desejar que a incrementacao ocorra antes de qualquer outra operacao, colocamos os operadores antes da variavel
            luiz = ++luiz * 2; // Incrementa antes de multiplicar

            // Operadores de comparacao
            int num1 = 9;
            int num2 = 9;
            string resultado = string.Empty;

            if(num1 == num2)
            {
                resultado = "São iguais.";
            }

            //Tambem podemos atribuir uma comparacao diretamente a uma variavel

            bool eIgual = (num1 == num2);

            return View();
        }
    }
}
