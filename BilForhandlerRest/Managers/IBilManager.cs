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


    }
}
