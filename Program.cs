namespace AddressBook
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Adressbook");
            string command = " ";
            int option;
            Adressbook1 adressbook1 = new Adressbook1();

            while (command != "Exit")
            {
                Console.Clear();
                Console.WriteLine("Please Enter a Command:  ");
                Console.WriteLine("1- Add contact \n 2 - Display Contact \n 3- Edit Contact \n 4- Delete Contact");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        adressbook1.Addperson();
                        break;

                    case 2:
                        adressbook1.Display();
                        break;
                    case 3:
                        adressbook1.EditContact();
                        break;
                    case 4:
                        adressbook1.DeleteContact();
                        break;
                    default:
                        Console.WriteLine("Entered invalid output");
                        command = "Exit";
                        break;

                }
            }

        }
    }

}
