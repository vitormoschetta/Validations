using Flunt.Notifications;
using Flunt.Validations;

namespace FluntValidations.Models
{
    public class Address : Notifiable<Notification>
    {
        public Address(string street, int number, string city, string state)
        {
            Street = street;
            Number = number;
            City = city;
            State = state;

            Validate();
        }

        public string Street { get; private set; }
        public int Number { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }


        public void Validate()
        {
            AddNotifications(new Contract<Address>()
                .Requires()
                .IsNotNullOrEmpty(Street, "Address.Street", "precisa ser informado")
                .IsGreaterThan(Number, 0, "Addres.Street", "não pode conter valor 0 (zero).")
                .IsNotNullOrEmpty(City, "Address.City", "precisa ser informado")
                .IsNotNullOrEmpty(State, "Address.State", "precisa ser informado")
            );
        }
    }
}