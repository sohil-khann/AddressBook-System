using System;
namespace AddressBookSystem
{
    public class Contact //poco class for contact details
    {
    public string FirstName { get; set; }//auto implemented getter and setter
    public string LastName{get;set;}
    public string Address{get; set;}
    public string City{get; set;}
    public string State{get; set;}
    public int Zip{get; set;}
    public int PhoneNumber{get; set;}
    public string Email{get; set;}
    public Contact(string firstname,string lastname,string address,string city,string state,int zip,int phoneNumber,string email)//parameterized constructor
        {
            this.FirstName=firstname;
            this.LastName=lastname;  
            this.Address=address;
            this.City=city;
            this.State=state;
            this.Zip=zip;
            this.PhoneNumber=phoneNumber;
            this.Email=email;
        }
        public override string ToString()//to string method override for displaying contact details
        {
            return $"FirstName: {FirstName}, LastName: {LastName}, Address: {Address}, City: {City}, State: {State}, Zip: {Zip}, PhoneNumber: {PhoneNumber}, Email: {Email}";
        }

        public override bool Equals(object obj)
        {
            // if the object is not a Contact, they can't be equal
            if (obj == null || !(obj is Contact))
                return false;

            // cast to Contact so we can look at its fields
            Contact other = (Contact)obj;

            // compare first names (ignore upper/lower case)
            if (FirstName == null || other.FirstName == null)
            {
                if (FirstName != other.FirstName)
                    return false;
            }
            else
            {
                if (!FirstName.ToLower().Equals(other.FirstName.ToLower()))
                    return false;
            }

            // compare last names (ignore upper/lower case)
            if (LastName == null || other.LastName == null)
            {
                if (LastName != other.LastName)
                    return false;
            }
            else
            {
                if (!LastName.ToLower().Equals(other.LastName.ToLower()))
                    return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            // alternative: use HashCode.Combine for a concise, case-insensitive hash
            return HashCode.Combine(
                FirstName?.ToLowerInvariant(),
                LastName?.ToLowerInvariant());
        }
    }
}