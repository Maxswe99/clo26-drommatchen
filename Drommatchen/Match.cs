public class Match {
                                                                                // Privata fält
    private string _hemmalag;
    private string _bortalag;
    private string _datum;
                                                                                // Properties — publik get, privat set
    public string Hemmalag { get; private set; }                                // get och privat set för Hemmalag 
    public string Bortalag { get; private set; }                                // get och privat set för Bortalag
    public string Datum { get; private set; }                                   // get och privat set för Datum
                                                                                // Konstruktor
    public Match(string hemmalag, string bortalag, string datum) {              // Konstruktor // TODO: tilldela de privata fälten
        
        Hemmalag = hemmalag;
        Bortalag = bortalag;
        Datum = datum;
    }
    
    public void Presentera() {                                                  // Metod 1: skriv ut matchens lag och datum // TODO
        Console.WriteLine($"{Hemmalag} vs {Bortalag} - {Datum}\n");
    }
    
    public void AnnounceraMålskytt(Spelare spelare) {                           // Metod 2: skriv ut spelarens namn, nummer och position // TODO
        Console.WriteLine($"#{spelare.Nummer} {spelare.Namn} {spelare.Position}");
    }
}