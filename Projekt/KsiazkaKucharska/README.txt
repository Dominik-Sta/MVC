Książka kucharska v3

Projekt zaliczeniowy z przedmiotu Wzorzec MVC w tworzeniu aplikacji internetowych.  
Aplikacja webowa w ASP.NET Core MVC pozwalająca zarządzać kolekcją ulubionych przepisów kulinarnych (dodawanie, edycja, usuwanie, przeglądanie, wyszukiwanie).


Funkcjonalności

Strona główna z opisem projektu i grafiką tematyczną oraz przyciskiem przejścia do listy przepisów.
Wyświetlanie listy wszystkich przepisów.
Dodawanie nowego przepisu (nazwa, składniki, instrukcja przygotowania).
Edycja istniejącego przepisu.
Usuwanie wybranego przepisu z listy.
Wyświetlanie szczegółów pojedynczego przepisu.
Wyszukiwanie przepisów po nazwie (filtrowanie listy).
Walidacja formularzy po stronie serwera i klienta (wymagane pola).

Wykorzystane technologie

C#, .NET
ASP.NET Core MVC
Razor Views
Bootstrap (stylowanie widoków)

Struktura MVC

Model:Przepisy zawiera pola Id, Nazwa, Skladnik, Instrukcja oraz atrybuty walidacyjne.
Kontroler: PrzepisyController obsługuje żądania dotyczące przepisów (lista, dodawanie, edycja, usuwanie, szczegóły, wyszukiwanie).

Widoki:

Index lista przepisów z wyszukiwarką.
Dodawanie formularz dodawania nowego przepisu.
Edytuj formularz edycji przepisu.
Usun widok potwierdzenia usunięcia.
Szczegoly wyświetlanie pojedynczego przepisu.
Home/Index strona główna z opisem projektu.

Jak uruchomić aplikację

1. Sklonować repozytorium z GitHub: 
2. Otwórz link w Visual Studio.
3. Upewnij się, że masz zainstalowany .NET SDK w wersji zgodnej z projektem.
5. Uruchom aplikację (F5).
6. W przeglądarce przejdź pod adres wskazany przez Kestrel (np. `https://localhost:xxxx`).

Autor

Imię i nazwisko:  
Grupa: L2  
Nr indeksu: 5

