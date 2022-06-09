using System.ComponentModel.DataAnnotations;

namespace ShoeAppModel
{
    public class Customer
    {
        private int _custID;

        public int CustomerID
        {

            get { return _custID;}
            set
            {
                if (value > 0)
                {
                    _custID = value;
                }
                else
                {
                    throw new ValidationException("CustomerID needs to be above 0.");
                }
            }
        }
        
        
        

        
        
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phonenumber { get; set; }

        public List<Inventory> Inventories { get; set; }

        public Customer()
        {
             CustomerID = 1;
            Name = "Steven F";
            Email = "Steven@gmail.com";
            Address = "4565 North C St";
            Phonenumber = "7033456666";
             Inventories = new List<Inventory>();

        }

    }   
}



