namespace NameDB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?:");
            string name = Console.ReadLine();

            using (var db = new NameDbContext())
            {
                var nameModel = new NameModel { Name = name };
                db.NameModels.Add(nameModel);
                db.SaveChanges();
            }

            Console.WriteLine("Navn er gemt i databasen.");
        }
    }
}
