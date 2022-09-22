using BilModelLib.model;

namespace BilForhandlerRest.Managers
{
    public interface IForhandlerManager
    {
        public Forhandler Create(Forhandler forhandler);
        public List<Forhandler> Read();

        public Forhandler Update(int id, Forhandler forhandler);
        public Forhandler Delete(int id);

        public List<Forhandler> Read(String navn);
    }
}
