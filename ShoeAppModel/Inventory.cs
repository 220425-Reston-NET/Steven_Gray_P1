namespace ShoeAppModel
{
    public class Inventory
    {
       
        public string Name { get; set; }
        public string Type { get; set; }

        public string Brand { get; set; }
        private int _Custnumber;
        public int Custnumber
        {
            get { return _Custnumber; }
            set 
            {
                if (value > 0)
                {
                   _Custnumber = value; 
                }
                else
                {
                    Console.WriteLine("Shoe number can only hold positive numbers");
                } 
            }
        }

        
        
    }
}