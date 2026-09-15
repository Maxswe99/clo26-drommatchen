public class Spelare {

    private string _namn;
    private int _nummer;
    private string _position;

    public string Namn { get; private set; }
    public int Nummer { get; private set; }
    public string Position { get; private set; }

    public Spelare(string namn, int nummer, string position) {
        
        Namn = namn;
        Nummer = nummer;
        Position = position;
    }
}