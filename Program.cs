namespace AddressBookProblem
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To AddressBook Program");

            //Contact contact = new Contact();
            //contact.AddressBook();

            //Console.WriteLine("Welcome to Address Book System");
            //NewContact records = new NewContact();
            //Console.WriteLine("1. Add a new Record");

            //Console.WriteLine("Enter your choice : ");
            //int ch = Convert.ToInt32(Console.ReadLine());


            //switch (ch)
            //{
            //    case 1:
            //        records.AddRecords();
            //        records.PrintRecords();
            //        Console.ReadLine();
            //        break;
            //}

            //Records records1 = new Records(); 
            //while (true)
            //{
            //    Console.WriteLine("\n\nWelcome to Address Book System");
            //    Console.WriteLine("1. Add a new Record");
            //    Console.WriteLine("2. Update a Record");
            //    Console.WriteLine("4.Exit");
            //    Console.WriteLine("\nEnter your choice : ");

            //    int choise = Convert.ToInt32(Console.ReadLine());
            //    switch (ch)
            //    {
            //        case 1:
            //            records.AddRecords();
            //            records.PrintRecords();
            //            break;
            //        case 2:
            //            Console.WriteLine("Enter your First Name : ");
            //            string fn = Console.ReadLine(); 
            //            Console.WriteLine("Enter your Last Name : ");
            //            string ln = Console.ReadLine();
            //            records1.UpdateRecords(fn, ln); 
            //            records.PrintRecords(); 
            //            break;
            //        case 4:
            //            System.Environment.Exit(0);
            //            break;
            //    }
            //    Console.ReadLine();


           // }
            DRecords records2 = new DRecords();
            records2.AddRecords();
            records2.PrintRecords();
            while (true)
            {
                Console.WriteLine("\n\nWelcome to Address Book System");
                Console.WriteLine("1. Add a new Record");
                Console.WriteLine("2. Update a Record");
                Console.WriteLine("3. Delete a Record");
                Console.WriteLine("4.Exit");
                Console.WriteLine("\nEnter your choice : ");

                int choise = Convert.ToInt32(Console.ReadLine());
                switch (choise)
                {
                    case 1:
                        records2.AddRecords(); 
                        records2.PrintRecords();
                        break;
                    case 2:
                        Console.WriteLine("\nEnter your First Name : ");
                        string fn = Console.ReadLine(); 
                        Console.WriteLine("Enter your Last Name : ");
                        string ln = Console.ReadLine();
                        records2.UpdateRecords(fn, ln); 
                        records2.PrintRecords(); 
                        break;
                    case 3:
                        Console.WriteLine("\nEnter your first name which you want to delete : ");
                        string f = Console.ReadLine(); 
                        records2.DeleteRecord(f);
                        records2.PrintRecords();
                        break;
                    case 4:
                        System.Environment.Exit(0);
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}