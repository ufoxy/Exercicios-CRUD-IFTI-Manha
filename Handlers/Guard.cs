using System.Text.RegularExpressions;
using LeiaMais.Models;

namespace LeiaMais.Handlers
{
    public class Guard
    {
        public static void ValidarStringNulaOuVazia(string propiedade, string mensagem)
        {
            if (string.IsNullOrWhiteSpace(propiedade))
                throw new ArgumentException(mensagem);
        }
        public static void ValidarData(DateTime data, string mensagem, int earliestDate)
        {
            if (data.Date > DateTime.Now.Date || data.Year < earliestDate)
                throw new ArgumentException(mensagem);
        }
        public static void ValidarListaNulaOuVazia(List<Autor> authors, string mensagem)
        {
            if (authors == null || authors.Count == 0)
                throw new ArgumentException(mensagem);
        }
        public static void ValidarEmail(string email, string mensagem)
        {
            // Não nulo, não vazio e sem ser apenas espaços em branco.
            // Aceita uma string no formato padrão sem espaços: contendo texto, o caractere @, texto, o caractere . e texto final (Exemplo: nome@dominio.com).

            if (string.IsNullOrWhiteSpace(email)) throw new ArgumentException(mensagem);

            string padrao = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email, padrao)) throw new ArgumentException(mensagem);
        }

        public static void ValidarCnpj(string cnpj, string mensagem)
        {
            // Não nulo, não vazio e sem ser apenas espaços em branco.
            // Pode conter ou não formatação (aceita pontos, traços e barras).
            // Deve conter exatamente 14 caracteres numéricos após remover a formatação.
            // Não pode ter todos os dígitos iguais (Exemplo: rejeitará 11.111.111/1111-11).
            // O número deve ser um CNPJ matemático válido e real (cálculo oficial dos dois últimos dígitos verificadores).
            // Exemplos aceitos no CNPJ: 12.345.678/0001-90 ou 12345678000190

            if (string.IsNullOrWhiteSpace(cnpj)) throw new ArgumentException(mensagem);

            string cnpjLimpo = cnpj.Replace(".", "").Replace("-", "").Replace("/", "").Trim();

            if (cnpjLimpo.Length != 14 || new string(cnpjLimpo[0], 14) == cnpjLimpo)
                throw new ArgumentException(mensagem);

            int[] multiplicador1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCnpj = cnpjLimpo.Substring(0, 12);
            int soma = 0;

            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

            int resto = (soma % 11);
            resto = resto < 2 ? 0 : 11 - resto;
            string digito = resto.ToString();

            tempCnpj += digito;
            soma = 0;

            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

            resto = (soma % 11);
            resto = resto < 2 ? 0 : 11 - resto;
            digito += resto.ToString();

            if (!cnpjLimpo.EndsWith(digito))
                throw new ArgumentException(mensagem);
        }

        public static void ValidarEnum(Enum valor, string mensagem)
        {
            if (!Enum.IsDefined(valor.GetType(), valor))
                throw new ArgumentException(mensagem);
        }
    }
}
