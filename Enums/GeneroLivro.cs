using System.ComponentModel.DataAnnotations;

namespace LeiaMais.Enums
{
    public enum GeneroLivro
    {
        [Display(Name = "Ficção Científica")]
        FiccaoCientifica = 1,

        [Display(Name = "Fantasia")]
        Fantasia = 2,

        [Display(Name = "Romance")]
        Romance = 3,

        [Display(Name = "Terror")]
        Terror = 4,

        [Display(Name = "Suspense")]
        Suspense = 5,

        [Display(Name = "Policial")]
        Policial = 6,

        [Display(Name = "Drama")]
        Drama = 7,

        [Display(Name = "Aventura")]
        Aventura = 8,

        [Display(Name = "Biografia")]
        Biografia = 9,

        [Display(Name = "História")]
        Historia = 10
    }
}
