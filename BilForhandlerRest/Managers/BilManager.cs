using BilModelLib.model;

namespace BilForhandlerRest.Managers
{
    public class BilManager:IBilManager
    {
        private static List<Bil> _biler = new List<Bil>()
            {
                new Bil(){Model="Focus", Maerke="Ford",Aar=2008, Km=237000, Braendsel="Benzin", StelNummer="XC345627.456"},
                new Bil(){Model="Golf", Maerke="VW",Aar=2018, Km=47000, Braendsel="Benzin", StelNummer="CF324.335.222"}
            };

        public BilManager()
        {

        }

        public Bil Create(Bil bil)
        {
            _biler.Add(bil);
            return bil;
        }

        public Bil Delete(string stelnummer)
        {
            Bil sletBil = Get(stelnummer);
            _biler.Remove(sletBil);
            return sletBil;
        }

        public List<Bil> Get()
        {
            return new List<Bil>(_biler);
        }

        public Bil Get(string stelnummer)
        {
            return _biler.Find(b => b.StelNummer == stelnummer);
        }

        public Bil Update(string stelnummer, Bil bil)
        {
            Bil updateBil = Get(stelnummer);
            if (updateBil is not null)
            {
                updateBil.Aar = bil.Aar;
                updateBil.Braendsel = bil.Braendsel;
                updateBil.Maerke = bil.Maerke;
                updateBil.Model = bil.Model;    
                updateBil.StelNummer = bil.StelNummer;
                updateBil.Km = bil.Km;
            }
            return updateBil;
        }
    }
}
