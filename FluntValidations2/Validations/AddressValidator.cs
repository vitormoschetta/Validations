using Flunt.Notifications;
using Flunt.Validations;
using FluntValidations2.Models;

namespace FluntValidations2.Validations
{
    public class AddressValidator : Notifiable<Notification>
    {
        public AddressValidator(Address address)
        {
            AddNotifications(new Contract<Address>()
                .Requires()
                .IsNotNullOrEmpty(address.Street, "Address.Street", "precisa ser informado")
                .IsGreaterThan(address.Number, 0, "Addres.Street", "não pode conter valor 0 (zero).")
                .IsNotNullOrEmpty(address.City, "Address.City", "precisa ser informado")
                .IsNotNullOrEmpty(address.State, "Address.State", "precisa ser informado")
            );
        }
    }
}