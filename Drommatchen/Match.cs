public class Match {

    //private string _hemmalag;
    //private string _bortalag;
    //private string _datum;

    /*public string Hemmalag{
        get { return _hemmalag; }
        private set { _hemmalag = value; }
    }*/

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
}