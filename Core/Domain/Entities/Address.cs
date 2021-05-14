namespace Domain
{
    public class Address
    {
        public string PostalCode { get; set; }
        public string AddressLine { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public Address(string postalCode, string addressLine, string number, string complement, string neighborhood, string city, string state)
        {
            PostalCode = postalCode;
            AddressLine = addressLine;
            Number = number;
            Complement = complement;
            Neighborhood = neighborhood;
            City = city;
            State = state;
        }
    }
}
