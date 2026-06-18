using KsiazkaKucharska.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Xml.Linq;

namespace KsiazkaKucharska.Controllers;

public class PrzepisyController : Controller
{
    private static List<Przepisy> _przepisy = new List<Przepisy>
    {
        new Przepisy
        {
            Id = 1,
            Name = "Spagheti Bologa",
            Skladnik = "Makaron, mięso mielone, pomidory, cebula, czosnek",
            Instrukcja = "Ugotuj makaron, podsmaż ważywa delikatnie, dodaj mięso i trzymaj na ogniu aż mięso będzie gotowe, dodaj pomidory, wymieszaj."
        },
        new Przepisy
        {
            Id = 2,
            Name = "Cienkie Placki",
            Skladnik = "Mąka, mleko, jajka, sól, olej",
            Instrukcja = "Wymieszaj składniki na ciasto, smaż cienkie placki na patelni."
        },
        new Przepisy
        {
            Id = 3,
            Name = "Pieczony ziemniak",
            Skladnik = "Ziemniak duży, masło, sół",
            Instrukcja = "Wrzucić ziemniaka do żaru potrzymać 45minut, wyjąć przebić jak mięki rozciąć i dodać masło i sól, jak twardy jeszcze na kilka minut do żaru."
        },
        new Przepisy
        {
            Id = 4,
            Name = "Potrawka ze wszystkiego",
            Skladnik = "seler, marchewka, cebula, pietruszka, mięso mielone, cukinia, mocarella, papryka, czosnek, pomidory, olej",
            Instrukcja = "Podsmaż czosnek na oleju, dodaj cebulę, selera, pietruszkę, paprykę. Dodaj mięso i pomidory, duś pod przykryciem, potem warzywa i ser."
        },
        new Przepisy
        {
            Id = 5,
            Name = "Byczy kufel",
            Skladnik = "Piwo, goździki, miód, cynamon, cytrusy, kieliszek mocnego trunku",
            Instrukcja = "wymieszać wszystko w garnku, ważne nie doprowadzić do wrzenia ale podawać gorące."
        }
    };

    public IActionResult Index(string searchString)
    {
        var przepisy = _przepisy.AsEnumerable();

        if (!string.IsNullOrEmpty(searchString))
        {
            przepisy = przepisy
                .Where(p => p.Name.Contains(searchString, StringComparison.OrdinalIgnoreCase));
        }

        return View(przepisy);
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