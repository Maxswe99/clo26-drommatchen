public class Spelare {

    public string Namn { get; private set; }
    public int Nummer { get; private set; }
    public string Position { get; private set; }
    public int Mål { get; private set; }
    

    public Spelare(string namn, int nummer, string position, int mål) {
        
        Namn = namn;
        Nummer = nummer;
        Position = position;
        Mål = mål;
    }
}