using KsiazkaKucharska.Models;
using Microsoft.AspNetCore.Mvc;

namespace KsiazkaKucharska.Controllers;

public class PrzepisyController : Controller
{
    public IActionResult Index()
    {
        var przepisy = new List<Przepisy>
        {
            new Przepisy
            {
                Id = 1,
                Name = "Spaghetti Bolognese",
                Skladnik = "Makaron, mięso mielone, pomidory, cebula, czosnek",
                Instrukcja = "Ugotuj makaron, podsmaż ważywa delikatnie, dodaj mięso i trzymaj na ogniu aż mięso będie gotowe, dodaj pomidory, wymieszaj."
                
            },
            new Przepisy
            {
                Id = 2,
                Name = "Naleśniki",
                Skladnik = "Mąka, mleko, jajka, sól, olej",
                Instrukcja = "Wymieszaj składniki na ciasto, smaż cienkie placki na patelni."
            },
            new Przepisy
            {
                Id = 3,
                Name = "Potrawka ze wszystkiego",
                Skladnik = "seler, marchewka, cebula, pietruszka, wieso mielone, cukinia, mocarella, papryka, czosnek, pomidory, olej",
                Instrukcja = "Podsmaż czosnek na oleju dodaj cebule, selera, pietruszkę, paprykę, chwilę potrzymaj do złapania temperatury. Dodaj mięso i pomidory i duś pod przykryciem do aż mięso nie będzie surowe w środku. Dodaj marchewkę i cukinie cienko pokrojone, mocarrelle i duś do połączenia składników. Gotowe"
            }

        };

        return View(przepisy);
    }
}