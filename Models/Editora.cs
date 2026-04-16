using LeiaMais.Handlers;

namespace LeiaMais.Models
{
    public class Editora
    {
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public string Email { get; set; }

        public Editora(string nome, string Cnpj, string email)
        {
            Guard.ValidarStringNulaOuVazia(nome, "ERRO: O nome inserido é inválido.");
            Guard.ValidarEmail(email, "ERRO: O email inserido não é válido");
            Guard.ValidarCnpj(Cnpj, "ERRO: O CNPJ inserido não é válido");

            Nome = nome;
            CNPJ = Cnpj;
            Email = email;
        }
    }
}
