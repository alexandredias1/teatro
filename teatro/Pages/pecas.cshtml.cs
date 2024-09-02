using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace teatro.Pages
{
    public class pecasModel : PageModel
    {
        public List<pecas> pecas { get; set; } = new List<Peca>();
        public void OnGet()
        {
            pecas = new List<pecasModel>
            {
                new pecas
        {
                Titulo = "DeadPool & Wolverine",
                Genero = "Ação/Comédia",
                Duracao = 127,
                Sessoes = "14:00, 18:00",
                ImagemUrl = "/imagens/A_Menina_Escorrendo_Dos_Olhos_DaMãe.webp"
            },
            new pecas
            {
                Titulo = "Divertida Mente 2",
                Genero = "Infantil/Comédia",
                Duracao = 96,
                Sessoes = "16:00, 20:00",
                ImagemUrl = "/imagens/A_NOVIÇA_REBELDE.webp"
            },
            new pecas
            {
                Titulo = "Meu Malvado Favorito 4",
                Genero = "Infantil/Comédia",
                Duracao = 94,
                Sessoes = "15:00, 19:00",
                ImagemUrl = "/imagens/ALMA_DESPEJADA.webp"
            },
            new pecas
            {
                Titulo = "O Corvo",
                Genero = "Ação/Fantasia",
                Duracao = 102,
                Sessoes = "17:00, 21:00",
                ImagemUrl = "/imagens/No_Front.webp"
            },
            new pecas
            {
                Titulo = "HellBoy e o Homem Torto",
                Genero = "Terror/Ação",
                Duracao = 115,
                Sessoes = "13:00, 17:00",
                ImagemUrl = "/imagens/Pandemônio.webp"
            },
            new pecas
            {
                Titulo = "Luccas e Gi em Dinossauros",
                Genero = "Infantil/Aventura",
                Duracao = 91,
                Sessoes = "13:00, 17:00",
                ImagemUrl = "/imagens/TRÊS_MULHERES_ALTAS.webp"
            },
            };
        }
    }
}
