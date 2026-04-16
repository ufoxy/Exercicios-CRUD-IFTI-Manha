using LeiaMais.Models;

namespace LeiaMais.Interfaces
{
    public interface IEmprestimoService
    {
        void RealizarEmprestimo(Usuario usuario, Livro livro);
        void FinalizarEmprestimo(Usuario usuario, Livro livro);
    }
}
