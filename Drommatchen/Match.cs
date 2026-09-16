public class Match {

    public string Hemmalag { get; private set; }
    public string Bortalag { get; private set; }
    public string Datum { get; private set; }

    public Match(string hemmalag, string bortalag, string datum) {
        
        Hemmalag = hemmalag;
        Bortalag = bortalag;
        Datum = datum;
    }
    
    public void Presentera() {
        Console.WriteLine($"{Hemmalag} vs {Bortalag} - {Datum}\n");
    }
    
    public void AnnounceraMålskytt(Spelare spelare) {
        Console.WriteLine($"#{spelare.Nummer} {spelare.Namn} {spelare.Position}");
    }

    public bool ÄrMatchhjälte(Spelare spelare) {
        string mål;
        if (spelare.Mål >= 1) {
            mål = "True";
            Console.WriteLine($"ÄrMatchhjälte - {spelare.Namn} {mål}");
            return true;
        }
        else {
            mål = "False";
            Console.WriteLine($"ÄrMatchhjälte - {spelare.Namn} {mål}");
        }
        return false;
    }
}