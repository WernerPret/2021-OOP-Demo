using System;
using System.Collections.Generic;


namespace DatingProfile
{ 
  class Profile{
    public string Name {get; set;}
    public int Age {get; set;}
    public string City {get; set;}
    public string Country {get; set;}
    public string Pronouns {get; set;}
    public List<string> Hobbies {get; set;}

    public Profile(string name, int age, string city, string country, string pronouns = "they")
    {
      this.Name = name;
      this.Age = age;
      this.City = city;
      this.Country = country;
      this.Hobbies = new List<string>();
      this.Pronouns = pronouns;
    }

    public string ViewProfile(){
      return $"{this.Name}: {this.Age}, from {this.City}\nGender: {this.Pronouns}\nHobbies: {string.Join(", ", this.Hobbies)}";
    }

    public void SetHobbies(List<string> hobs){
      this.Hobbies = hobs;
    }
  }
}
