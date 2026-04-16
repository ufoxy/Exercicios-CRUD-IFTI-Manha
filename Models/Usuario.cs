using LeiaMais.Handlers;
using LeiaMais.Enums;

namespace LeiaMais.Models
{
    public class Usuario
    {
        public string Nome { get; set; }
        public List<Livro> LivrosEmprestados { get; set; }
        public StatusUsuario Status { get; set; } = StatusUsuario.Ativo;

        public Usuario(string nome)
        {
            Guard.ValidarStringNulaOuVazia(nome, "ERRO: O nome inserido é inválido.");
            
            Nome = nome;
        }
    }
}
