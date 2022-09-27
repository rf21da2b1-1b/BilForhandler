using BilModelLib.model;

namespace BilForhandlerRest.Managers
{
    public class BilManager:IBilManager
    {
        private static List<Bil> _biler = new List<Bil>()
            {
                new Bil(){Model="Focus", Maerke="Ford",Aar=2008, Km=237000, Braendsel="Benzin", StelNummer="XC345627.456"},
                new Bil(){Model="Polo", Maerke="VW",Aar=2018, Km=13000, Braendsel="Diesel", StelNummer="XC3.45627.456"},
                new Bil(){Model="Fabia", Maerke="Skoda",Aar=2009, Km=137000, Braendsel="Benzin", StelNummer="XC3.45.627.456"},
                new Bil(){Model="Seed", Maerke="Kia",Aar=2020, Km=27000, Braendsel="Hybrid", StelNummer="XC3.456.27.45.6"},
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

        public List<Bil> GetModel(String model)
        {
            return _biler.FindAll(b => b.Model.Contains(model));
        }






        
        public Bil Get(string stelnummer)
        {
            if (!_biler.Exists(b => b.StelNummer == stelnummer))
                throw new KeyNotFoundException();

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


        /*
         * Alternativ update
         */
        public Bil Update2(string stelnummer, Bil bil)
        {
            int index = _biler.FindIndex(b => b.StelNummer==stelnummer);
            _biler[index] = bil;
            return _biler[index];
        }



        
    }
}
