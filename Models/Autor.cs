using LeiaMais.Handlers;

namespace LeiaMais.Models
{
    public class Autor
    {
        public string Nome { get; set; }
        public string Nacionalidade { get; set; }
        public DateTime DataNascimento { get; set; }
        public Autor(string nome, string nacionalidade, DateTime dataNascimento)
        {
            Guard.ValidarStringNulaOuVazia(nome, "ERRO: O nome inserido é inválido.");
            Guard.ValidarStringNulaOuVazia(nacionalidade, "ERRO: A nacionalidade inserida é inválida");
            Guard.ValidarData(dataNascimento, "ERRO: A data de nascimento inserida é inválida.", 1900); // Verifica se o nascimento passa do ano, dia e mês atual.

            Nome = nome;
            Nacionalidade = nacionalidade;
            DataNascimento = dataNascimento;
        }
    }
}
