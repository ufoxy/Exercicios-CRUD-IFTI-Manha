
using System.Reflection;
using System.ComponentModel.DataAnnotations;
using LeiaMais.Handlers;
using LeiaMais.Enums;

namespace LeiaMais.Models
{
    public class Livro
    {
        public string Titulo { get; set; }
        public GeneroLivro Genero { get; set; }
        public List<Autor> Autores { get; set; }
        public ISBN ISBN { get; set; }
        public Editora Editora { get; set; }
        public DateTime AnoPublicacao { get; set; }

        public Livro(string titulo, GeneroLivro genero, List<Autor> autores, ISBN isbn, Editora editora, DateTime anoPublicacao)
        {
            Guard.ValidarStringNulaOuVazia(titulo, "ERRO: O titulo inserido é inválido.");
            Guard.ValidarListaNulaOuVazia(autores, "ERRO: A lista de autores é nula ou não contem autor.");
            Guard.ValidarData(anoPublicacao, "ERRO: A data de publicação é inválida", 1440);
            Guard.ValidarEnum(genero, "ERRO: O gênero inserido é inválido.");

            Titulo = titulo;
            Genero = genero;
            Autores = autores;
            ISBN = isbn;
            Editora = editora;
            AnoPublicacao = anoPublicacao;
        }
    }
}
