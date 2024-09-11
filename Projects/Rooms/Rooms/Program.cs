namespace Rooms
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());

            Student[] s = new Student[10]; 

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Rent #" + (i+1) + ":");
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());

                Console.WriteLine();

                s[room] = new Student { Name = name, Email = email, Room = room }; 
            }

            Console.WriteLine();
            Console.WriteLine("Busy rooms: ");

            for (int i = 0; i < 10; i++)
            {
                if (s[i] != null ) {
                    Console.WriteLine(i + ": " + s[i]);

                }
            }

            Console.WriteLine();
        }
    }
}