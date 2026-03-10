using Exemplo_01.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exemplo_01.Controllers
{
    public class FlowersController : Controller
    {
        public IActionResult ListaDeFlores()
        {
            Flowers rosa = new Flowers();
            rosa.Nome = "Rosa";
            rosa.Tipo = "Arbusto ornamental";
            rosa.Especie = "Rosa spp";
            rosa.Cor = "Vermelho, Rosa, Branco, Amarelo";
            rosa.Aroma = "Doce e marcante";
            rosa.Tamanho = "40 a 100 cm";
            rosa.Valor = "8 a 25 reais por haste";

            Flowers tulipa = new Flowers();
            tulipa.Nome = "Tulipa";
            tulipa.Tipo = "Herbácea bulbosa";
            tulipa.Especie = "Tulipa gesneriana";
            tulipa.Cor = "Vermelho, amarelo, roxo, branco";
            tulipa.Aroma = "Suave";
            tulipa.Tamanho = "20 a 60 cm";
            tulipa.Valor = "15 a 40 reais por haste";

            Flowers girassol = new Flowers();
            girassol.Nome = "Girassol";
            girassol.Tipo = "Herbácea anual";
            girassol.Especie = "Helianthus annuus";
            girassol.Cor = "Amarelo com centro marrom";
            girassol.Aroma = "Leve";
            girassol.Tamanho = "1 a 3 m";
            girassol.Valor = "10 a 30 reais por haste";

            Flowers orquidea = new Flowers();
            orquidea.Nome = "Orquídea";
            orquidea.Tipo = "Planta epífita";
            orquidea.Especie = "Phalaenopsis spp.";
            orquidea.Cor = "Branco, rosa, roxo, amarelo";
            orquidea.Aroma = "Suave ou inexistente";
            orquidea.Tamanho = "30 a 70 cm";
            orquidea.Valor = "60 a 18 reais por vaso";

            Flowers hibisco = new Flowers();
            hibisco.Nome = "Hibisco";
            hibisco.Tipo = "Arbusto tropical";
            hibisco.Especie = "Hibiscus rosa-sinensis";
            hibisco.Cor = "Vermelho, rosa, laranja";
            hibisco.Aroma = "Quase sem aroma";
            hibisco.Tamanho = "1 a 3 m";
            hibisco.Valor = "20 a 50 reais por muda";

            Flowers margarida = new Flowers();
            margarida.Nome = "Margarida";
            margarida.Tipo = "Herbácea";
            margarida.Especie = "Bellis perennis";
            margarida.Cor = "Branco com centro amarelo";
            margarida.Aroma = "Leve";
            margarida.Tamanho = "10 a 25 cm";
            margarida.Valor = "10 a 25 reais por vaso";

            Flowers peonia = new Flowers();
            peonia.Nome = "Peônia";
            peonia.Tipo = "Herbácea perene";
            peonia.Especie = "Paeonia lactiflora";
            peonia.Cor = "Rosa, vermelho, branco";
            peonia.Aroma = "Forte e doce";
            peonia.Tamanho = "60 a 100 cm";
            peonia.Valor = "30 a 80 reais por haste";

            Flowers lavanda = new Flowers();
            lavanda.Nome = "Lavanda";
            lavanda.Tipo = "Arbusto aromático";
            lavanda.Especie = "Lavandula angustifolia";
            lavanda.Cor = "Roxo";
            lavanda.Aroma = "Aroma forte e relaxante";
            lavanda.Tamanho = "30 a 60 cm";
            lavanda.Valor = "25 a 60 reais por vaso";

            Flowers florDeCerejeira = new Flowers();
            florDeCerejeira.Nome = "Flor De Cerejeira";
            florDeCerejeira.Tipo = "Árvore ornamental";
            florDeCerejeira.Especie = "Prunus serrulata";
            florDeCerejeira.Cor = "Rosa claro";
            florDeCerejeira.Aroma = "Muito suave";
            florDeCerejeira.Tamanho = "Até 10 m";
            florDeCerejeira.Valor = "80 a 250 reais por muda";

            Flowers lirio = new Flowers();
            lirio.Nome = "Lírio";
            lirio.Tipo = "Bulbosa ornamental";
            lirio.Especie = "Lilium candidum";
            lirio.Cor = "Branco, laranja, rosa";
            lirio.Aroma = "Forte e perfumado";
            lirio.Tamanho = "60 a 120 cm";
            lirio.Valor = "20 a 50 reais por haste";

            List<Flowers> listaDeFlores = new List<Flowers>();
            listaDeFlores.Add(rosa);
            listaDeFlores.Add(tulipa);
            listaDeFlores.Add(girassol);
            listaDeFlores.Add(orquidea);
            listaDeFlores.Add(hibisco);
            listaDeFlores.Add(margarida);
            listaDeFlores.Add(peonia);
            listaDeFlores.Add(lavanda);
            listaDeFlores.Add(florDeCerejeira);
            listaDeFlores.Add(lirio);


            return View(listaDeFlores);
        }
    }
}
