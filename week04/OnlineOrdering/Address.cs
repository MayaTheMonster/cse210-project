public class Address
    {
        public Address()
        {
           _street = "";
            _city = "";
            _estate = "";
            _country = ""; 
        }
        public Address(string street, string city, string estate, string country)
        {
            _street = street;
            _city = city;
            _estate = estate;
            _country = country;
        }
        private string _street;
        private string _city;
        private string _estate;
        private string _country;
    
        public bool ReturnIfCountryIsUS()
        {
            bool isUS = false;
            if (_country == "US" || _country == "United States" || _country == "EUA")
            {
                isUS = true;
            }
            return isUS;
        }
        public string StringAdress()
        {
            string bigString = $"{_street}\n{_city}\n{_estate}\n{_country}";
            return bigString;
        }
    }