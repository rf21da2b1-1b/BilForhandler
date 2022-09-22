namespace BilModelLib.model
{
    public class Forhandler
    {
        public int Id{ get; set; }
        public string Name{ get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public Forhandler()
        {
                
        }
        public Forhandler(int id, string name, string adr, string phone)
        {
            Id = id;
            Name = name;
            Address = adr;
            Phone = phone;
                
        }

        public override string ToString()
        {
            return $"ID={Id},Name={Name}, Address={Address}, Phone={Phone}";
        }
    }
}
