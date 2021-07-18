namespace FluntValidations2.Models
{
    public class Address 
    {
        public Address(string street, int number, string city, string state)
        {
            Street = street;
            Number = number;
            City = city;
            State = state;            
        }

        public string Street { get; set; }
        public int Number { get; set; }
        public string City { get; set; }
        public string State { get; set; }       
    }
}