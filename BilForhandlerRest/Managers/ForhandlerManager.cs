using BilModelLib.model;

namespace BilForhandlerRest.Managers
{
    public class ForhandlerManager : IForhandlerManager
    {
        private static List<Forhandler> data = new List<Forhandler>()
        {
            new Forhandler(4, "peters biler", "roskilde xxx", "22334455"),
new Forhandler(5, "martins biler", "roskilde xxx", "22334455"),
new Forhandler(6, "Georg Martin SuperBiler", "roskilde xxx", "22334455"),
        };

        public Forhandler Create(Forhandler forhandler)
        {
            throw new NotImplementedException();
        }

        public Forhandler Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Forhandler> Read()
        {
            throw new NotImplementedException();
        }

        public List<Forhandler> Read(string navn)
        {
            if (navn is null)
            {
                return new List<Forhandler>();
            }
            return data.Where(f => f.Name.ToLower().Contains(navn.ToLower())).ToList();

        }

        public Forhandler Update(int id, Forhandler forhandler)
        {
            throw new NotImplementedException();
        }
    }
}
