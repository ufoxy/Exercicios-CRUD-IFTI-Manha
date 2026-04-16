using LeiaMais.Interfaces;
using LeiaMais.Models;
using LeiaMais.Enums;

namespace Services
{
    public class EmprestimoService : IEmprestimoService
    {
        public void RealizarEmprestimo(Usuario usuario, Livro livro)
        {
            if(usuario.LivrosEmprestados.Count() >= 3)
            {
                Console.WriteLine("ERRO: O limite de livros emprestados já foi excedido.");
                return;
            }

            if(livro.Status != StatusLivro.Disponivel)
            {
                Console.WriteLine("ERRO: O livro não está disponível.");
                return;
            }
        }

        public void FinalizarEmprestimo(Usuario usuario, Livro livro)
        {

        }
    }
}
