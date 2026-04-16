using System.ComponentModel.DataAnnotations;

namespace LeiaMais.Enums
{
    public enum StatusLivro
    {
        [Display(Name = "Disponível")]
        Disponivel = 1,

        [Display(Name = "Emprestado")]
        Emprestado = 2,
    }
}
