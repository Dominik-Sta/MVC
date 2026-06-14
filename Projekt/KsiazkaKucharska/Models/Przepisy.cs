using System.ComponentModel.DataAnnotations;

namespace KsiazkaKucharska.Models;

public class Przepisy
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string? Name { get; set; }

    [Required]
    [Display(Name = "Skladniki")]
    public string? Skladnik { get; set; }

    [Required]
    [Display(Name = "Instrukcja")]
    public string? Instrukcja { get; set; }
}