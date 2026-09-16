# Rapport

**Kurs:** Grundläggande OOP i C#  
**Uppgift:**  Grundläggande OOP i C#, CLO26, Grundläggande objektorienterad\
**Grupp:**  Team Hydra -> Solo\
**Datum:**  2026-09-16\
**GitHub:**  https://github.com/Maxswe99/clo26-drommatchen

---

## Gruppmedlemmar

| Namn               | Lämnade in |
|--------------------|-----------|
| Team Hydra -> Solo | Zip + RAPPORT.md + REFLEKTION.md |


---

## G — Hur vi löste uppgiften

> Förklara kortfattat hur du löste varje G-krav. En till tre meningar per punkt räcker.  
> Skriv med egna ord — kopiera inte uppgiftsbeskrivningen.

### Klasserna

> Klasserna var redan definerade från start. jag använde dem för att kalla på dem till program.cs
> från Spelare.cs och Match.cs genom att kalla på objekten. Satte dessutom auto implement på propteries och tog bort överflödiga properties

### Metoderna

> löste metoderna genom att skriva ut properties. Console.WriteLine(); skrev ut objektets propterties.
> som ger mig ett sätt att läsa.

### Main()

> skapade spelare av från Spelare.cs genom att definera dem. Sen anropade jag metoderna
> med match.AnnounceraMålskytt(tomas); som använder tomas som spelare. anropade på match från
> variabel namnet.

### Git

> 

### Kodkvalitet

> Valde att köra new school med {get; set;} för att det är moderna och lättare att förstå och läsa.
> raderade manuellt implementerade properties för att det inte behövs defineras två gånger

---

## VG — Motivering

> Fyll i det här avsnittet om du siktar på VG. Lämna tomt = G-bedömning.

### Vad vi lade till

> i Match.cs lade vi till metoden ÄrMatchhjälte. Denna metod är en bool som retunerar true
> om Mål>=1 annars false. I Spelare.cs så lade vi till Mål i field, property och i parametrarna.
> i Program.cs lade vi egentligen bara till Console.WriteLine x2 för att skriva ut true false.
> hämtar namnet från variabel namnet från skapad spelare och namn från propertyn.
> sen match.ÄrMatchhjälte(tomas) så hämtar den metoden match hjälte från match.cs och använder
> tomas som argument.

### Varför vi löste det såhär

> uppgiften ville ha en bool som säger om målskytten är true eller false därav gjorde vi en
> metod för att kunna anropa boolen. vi satte Mål>=1 för att titta om spelaren var matchhjälte
> eller inte. i mina tidigare commits försökte jag lägga en if sats i själva metoden som skrev
> ut vilket var onödigt.

---

## Git-logg

Klistra in utskriften från `git log --oneline` här:

```
e03a2ac (HEAD -> main) commit rapport & reflektion
183bed2 final last commit
a714160 last commit
ef310e0 commit version 4? haha
48b8113 version 3
32f2519 commit version 2
f173eae lade till {get; private set;} samt la till tilldelning i konstruktorn
35825ed Solutionfile added at root
34de7d5 refactor: gör property-kroppar tomma — studerande implementerar själva
66f4917 init: starterrepo för Drömmatchen (Inlämning 1)
```
