using KsiazkaKucharska.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace KsiazkaKucharska.Controllers;

public class PrzepisyController : Controller
{
    private static List<Przepisy> _przepisy = new List<Przepisy>
    {
        new Przepisy
        {
            Id = 1,
            Name = "Spaghetti Bolognese",
            Skladnik = "Makaron, mięso mielone, pomidory, cebula, czosnek",
            Instrukcja = "Ugotuj makaron, podsmaż ważywa delikatnie, dodaj mięso i trzymaj na ogniu aż mięso będzie gotowe, dodaj pomidory, wymieszaj."
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
            Skladnik = "seler, marchewka, cebula, pietruszka, mięso mielone, cukinia, mocarella, papryka, czosnek, pomidory, olej",
            Instrukcja = "Podsmaż czosnek na oleju, dodaj cebulę, selera, pietruszkę, paprykę. Dodaj mięso i pomidory, duś pod przykryciem, potem warzywa i ser."
        }
    };

    public IActionResult Index()
    {
        return View(_przepisy);
    }

    public IActionResult Dodawanie()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Dodawanie(Przepisy przepis)
    {
        if (ModelState.IsValid)
        {
            var newId = _przepisy.Any() ? _przepisy.Max(p => p.Id) + 1 : 1;
            przepis.Id = newId;

            _przepisy.Add(przepis);
            return RedirectToAction(nameof(Index));
        }

        return View(przepis);
    }


    public IActionResult Edytuj(int id)
    {
        var przepis = _przepisy.FirstOrDefault(p => p.Id == id);
        if (przepis == null)
        {
            return NotFound();
        }

        return View(przepis);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edytuj(Przepisy przepis)
    {
        if (ModelState.IsValid)
        {
            var istniejący = _przepisy.FirstOrDefault(p => p.Id == przepis.Id);
            if (istniejący == null)
            {
                return NotFound();
            }

            istniejący.Name = przepis.Name;
            istniejący.Skladnik = przepis.Skladnik;
            istniejący.Instrukcja = przepis.Instrukcja;

            return RedirectToAction(nameof(Index));
        }

        return View(przepis);
    }


    public IActionResult Usun(int id)
    {
        var przepis = _przepisy.FirstOrDefault(p => p.Id == id);
        if (przepis == null)
        {
            return NotFound();
        }

        return View(przepis);
    }

    [HttpPost, ActionName("Usun")]
    [ValidateAntiForgeryToken]
    public IActionResult UsunPotwierdzone(int id)
    {
        var przepis = _przepisy.FirstOrDefault(p => p.Id == id);
        if (przepis == null)
        {
            return NotFound();
        }

        _przepisy.Remove(przepis);
        return RedirectToAction(nameof(Index));
    }
    public IActionResult Szczegoly(int id)
    {
        var przepis = _przepisy.FirstOrDefault(p => p.Id == id);
        if (przepis == null)
        {
            return NotFound();
        }

        return View(przepis);
    }
}