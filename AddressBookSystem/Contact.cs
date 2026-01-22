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
    public string Zip{get; set;}
    public string PhoneNumber{get; set;}
    public string Email{get; set;}
    public Contact(string firstname,string lastname,string address,string city,string state,string zip,string phoneNumber,string email)//parameterized constructor
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

}
}