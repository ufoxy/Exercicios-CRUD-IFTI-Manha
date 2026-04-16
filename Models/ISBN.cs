using System.Text.RegularExpressions;
using LeiaMais.Handlers;

namespace LeiaMais.Models
{
    public class ISBN
    {
        public string Isbn { get; set; }
        public ISBN(string isbn)
        {
            Guard.ValidarStringNulaOuVazia(isbn, "ERRO: O ISBN inserido é inválido.");

            string isbnLimpo = isbn.Replace("-", "").Replace(" ", "").ToUpper();
            string padrao = @"^(?:\d{9}[\dX]|\d{13})$";

            if (!Regex.IsMatch(isbnLimpo, padrao))
                throw new ArgumentException("ERRO: O formato do ISBN é inválido.");

            Isbn = isbnLimpo;
        }
    }
}
