using System.ComponentModel.DataAnnotations;

namespace KsiazkaKucharska.Models;

public class Przepisy
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Nazwa jest wymagana")]
    [StringLength(100, ErrorMessage = "Nazwa może mieć maksymalnie 100 znaków")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Składniki są wymagane")]
    public string Skladnik { get; set; }

    [Required(ErrorMessage = "Instrukcja jest wymagana")]
    public string Instrukcja { get; set; }
}