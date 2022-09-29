using BilModelLib.model;

namespace BilForhandlerRest.Managers
{
    public interface IBilManager
    {
        // CRUD
        List<Bil> Get();
        Bil Create(Bil bil);
        Bil Update(String stelnummer, Bil bil);
        Bil Delete(String stelnummer);

        // find bil fra stelnummer
        Bil Get(String stelnummer);
        // find biler fra model
        List<Bil> GetModel(String model);
        // finde biler fra et interval af år
        List<Bil> SearchYear(int? lowYear, int? highYear);

        


    }
}
