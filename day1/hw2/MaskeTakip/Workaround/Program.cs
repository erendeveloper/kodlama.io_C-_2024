// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using Entities.Concrete;

Person person1 = new();
person1.FirstName = "Super";
person1.LastName = "Maryo";
person1.DateOfBirthYear = 1989;
person1.NationalIdentity = 12345678910;
PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);

