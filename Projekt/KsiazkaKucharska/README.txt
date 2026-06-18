Zadanie 14 - Kolekcja ulubionych przepisów kulinarnych

>>Spis treści
1> Opis projektua
2> Funkcjonalności
3> Wykorzystane technologie
4> Struktura MVC
5> Jak uruchomić aplikację
6> Autor

1> Opis projektu
"Książka kucharska v3"

Projekt zaliczeniowy z przedmiotu Wzorzec MVC w tworzeniu aplikacji internetowych.  
Aplikacja webowa w ASP.NET Core MVC pozwalająca zarządzać kolekcją ulubionych przepisów kulinarnych (dodawanie, edycja, usuwanie, przeglądanie, wyszukiwanie).

2>Funkcjonalności

Strona główna z opisem projektu i grafiką oraz przyciskiem przejścia do listy przepisów.
Wyświetlanie listy wszystkich przepisów.
Dodawanie nowego przepisu (nazwa, składniki, instrukcja ).
Edycja istniejącego przepisu.
Usuwanie wybranego przepisu z listy.
Wyświetlanie szczegółów pojedynczego przepisu.
Wyszukiwanie przepisów po nazwie (filtrowanie listy).
Walidacja formularzy po stronie serwera i klienta (wymagane pola).

3> Wykorzystane technologie

C#, .NET
ASP.NET Core MVC
Razor Views
Bootstrap

4> Struktura MVC

Model:Przepisy zawiera pola Id, Nazwa, Skladnik, Instrukcja oraz atrybuty walidacyjne.
Kontroler: PrzepisyController obsługuje żądania dotyczące przepisów (lista, dodawanie, edycja, usuwanie, szczegóły, wyszukiwanie).

Widoki:

Lista przepisów z wyszukiwarką.
Dodawanie formularz dodawania nowego przepisu.
Edytowanie przepisu.
Usun i widok potwierdzenia usunięcia.
Szczegóły wyświetlanie pojedynczego przepisu.
Strona główna z opisem projektu.

5> Jak uruchomić aplikację

1. Sklonować repozytorium z GitHub: 
2. Otwórz link w Visual Studio.
3. Aplikacja była tworzona i testowana na .NET 8.0. Aby ją uruchomić, wymagane jest zainstalowanie .NET SDK w wersji co najmniej 8.0.
4. Uruchom aplikację (F5).
5. Visual Studio powinno samo otworzy przeglądarkę.

6> Autor

Imię i nazwisko:  Dominik Stawicki
Grupa: L2  
Nr indeksu: 59857

