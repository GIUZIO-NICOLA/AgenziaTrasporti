
internal class Program
{
    static void Main(string[] args)
    {

    }



}

public class Controllore
{
    private string _nome { get; set; }
    private string _cognome { get; set; }
    private Mezzo _mezzo { get; set; }
    private Agenzia _agenzia { get; set; }

    public void CheckTicket(Mezzo _mezzo, Viaggiatore viaggiatore, string id) { }
    public int PersonePresentiNelMezzo(Mezzo mezzo)
    {
        if (mezzo.Equals(_mezzo))
            return _mezzo.OccupazioneMezzo();
        else
            throw new Exception("Mezzo non corrispondente!");
    }
}
public class Mezzo
{
    private int _numeroMezzo { get; set; }
    private string _nome { get; set; }
    private int _numeroPosti { get; set; }
    private int[] _posti;
    private string _tratta;
    public Controllore _controllore;

    public Mezzo()
    {
        _posti = new int[_numeroPosti];
    }
    public int OccupazioneMezzo()
    {
        return _posti.Length;
    }
}
public abstract class Agenzia
{
    private string _nome;
    private Mezzo[] _mezzo;
    private Controllore[] _controllore;
    private Viaggio[] _viaggio;

    public void CreaMezzo() { }
    public void CreaControllore() { }
    public void CheckViaggio() { }
    public void ControlloBiglietto(Biglietto biglietto, Viaggiatore viaggiatore)
    {
        // dal viaggiatore prendo il biglietto e lo confronto con il biglietto in ingresso

        // nell'array viaggio cerco il numero biglietto e confrontarlo con il biglietto passato se il risultato è 
    }
    //
    public Boolean ValiditaBiglietto(Biglietto biglietto)
    {
        if (DateTime.Today > biglietto.Validita)
            return true;
        else
            return false;
    }
    public void AssociaControlloreMezzo()
    { //(Controllore controllore, Mezzo mezzo) { 
      // può farlo in modo autonomo senza passarli come parametro
      // associa mezzo a controllore
      // primo mezzo a disposizione che non ha controllore, il primo mezzo cha controllore = null, lo associa al primo disponibile
      //}

        /*public void GetControlloreMezzo(Mezzo mezzo) {
            mezzo._controllore;
        }*/ // non neccessario

    }
    interface ICheckIn
    {
        public void CheckIn(Viaggiatore viaggiatore);
    }
    public class AgenziaAerea : Agenzia, ICheckIn
    {
        //
        private string[] mezzoAereo;
        private string codiceIATA;
        private int passeggeriTotImbarcatiAgenziaAerea;
        //
        public void CreaMezzoAereo() { }
        public void CheckIn(Viaggiatore viaggiatore)
        {
            throw new NotImplementedException();
        }

    }
    public class Viaggio
    {
        private string _nome { get; set; }
        private Mezzo[] _mezzo { get; set; }
        private DateTime _data { get; set; }
        private Biglietto _biglietto { get; set; }
        //
        public void AddTrattaMezzo(Mezzo mezzo) { }
        public void getTragitto() { }
        public void getTratta(Mezzo[] mezzo) { }

    }
    public class Biglietteria
    {
        private string _nome { get; set; }
        private Viaggio[] _viaggio { get; set; }
        private Agenzia[] _agenzia { get; set; }
        //
        public void CreaViaggio() { }
        public void ViaggiDisponibili() { }
        public void EmettiBiglietti(Viaggiatore viaggiatore, Viaggio viaggio) { }

    }
    public class Biglietto
    {
        private string _codice { get; set; }
        private Mezzo _mezzo { get; set; }
        private Viaggiatore[] _viaggiatore { get; set; }
        public DateTime Validita { get; }

        public Biglietto(DateTime dataViaggio)
        {
            Validita = dataViaggio;
        }
    }
    public class Viaggiatore
    {
        private string _nome { get; set; }
        private string _cognome { get; set; }
        // private string _azienda { get; set; }
        private string _documento { get; set; }
        private Biglietto[] _biglietto { get; set; }
        //
        public void CercaBiglietto(Biglietto biglietto) { }
        public void ElencoBiglietti() { }
        private void EmettiBiglietti(Viaggiatore viaggiatore, Viaggio viaggio) { }


    }
