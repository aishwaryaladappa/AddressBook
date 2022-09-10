using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AddressBook
{

    class Adressbook1
    {


        public List<Contact> people = new List<Contact>();

        public void Addperson()
        {

            Contact person = new Contact();

            Console.WriteLine("Enter the First Name: ");
            person.Firstname = Console.ReadLine();
            foreach (var contact in people)
            {
                if (contact.Firstname.ToLower() == person.Firstname.ToLower())
                {
                    Console.WriteLine("Contact Alredy exists");
                    return;
                }
            }
            Console.WriteLine("Enter the Last Name: ");
            person.Lastname = Console.ReadLine();
            Console.WriteLine("Enter the city Name: ");
            person.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter the PhoneNumber: ");
            person.city = Console.ReadLine();
            Console.WriteLine("Enter the Zip: ");
            person.Zip = Console.ReadLine();
            Console.WriteLine("Enter the Email: ");
            person.Email = Console.ReadLine();
            Console.WriteLine("Enter the Adress: ");
            person.Adress = Console.ReadLine();

            people.Add(person);
        }

        public void Display()
        {
            foreach (var contact in people)
            {
                Console.WriteLine($"Firstname : {contact.Firstname}\t Lastname : {contact.Lastname}\t PhoneNumber : {contact.PhoneNumber}\t city : {contact.city}\t Zip : {contact.Zip}\t Email : {contact.Email}\t Adress : {contact.Adress}\n ");

            }
            Console.ReadLine();
        }

        public void EditContact()
        {
            Console.WriteLine("Enter the first name you want to edit");
            string Firstname = Console.ReadLine();
            foreach (Contact contact in people)
            {
                if (contact.Firstname.ToLower() == Firstname.ToLower())
                {
                    Console.WriteLine("Enter which information you want to change ");
                    Console.WriteLine("Enter 1 To edit last nam \n 2 to change the city \n  3 to change the phonenumber \n 4 to change the zip \n 5 to change the Email \n 6to change the address");
                    int option = Convert.ToInt32((Console.ReadLine()));
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter the Lastname");
                            contact.Lastname = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Enter the city");
                            contact.city = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Enter the Phonenumber");
                            contact.PhoneNumber = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Enter the Zip");
                            contact.Zip = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Enter the Email");
                            contact.Email = Console.ReadLine();
                            break;
                        case 6:
                            Console.WriteLine("Enter the Adress");
                            contact.Adress = Console.ReadLine();
                            break;
                    }

                }
            }
        }

        public void DeleteContact()
        {
            Console.WriteLine("Enter the first name you want to edit");
            string Firstname = Console.ReadLine();

            //int index = people.IndexOf(Firstname);
            int index = -1;
            for (int i = 0; i < people.Count; i++)
            {
                if (people[i].Firstname.ToLower() == Firstname.ToLower())
                {
                    index = i;
                    break;
                }
            }

            if (index >= 0)
            {
                people.RemoveAt(index);
                Console.WriteLine("Person deleted successfully");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("No such person exist in database.");
                Console.ReadLine();
            }
        }
    }
}