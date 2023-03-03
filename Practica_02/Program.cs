//CRUD

using Praktica;

namespace Practica_02
{
    class Program
    {
        static void Main(string[] args)
        {

            //Вывод таблицы
            using (ApplicationContext db = new ApplicationContext())
            {
                var clients = db.Client.ToArray();
                Console.WriteLine("Список объектов");
                foreach (Client u in clients)
                {
                    Console.WriteLine(u.Inn + " - " + u.Telephon);
                }
            }

            //Read
            using (ApplicationContext db = new ApplicationContext())
            {
                Client test = new Client { Id = 5, Inn = 1234567890, Telephon = "8910832741" };
                db.Client.Add(test);
                db.SaveChanges();
                var сlients = db.Client.ToArray();
                Console.WriteLine("Список объектов");
                foreach (Client u in сlients)
                {
                    Console.WriteLine(u.Inn + " - " + u.Telephon);
                }
            }

            //Update
            using (ApplicationContext db = new ApplicationContext())
            {
                Client? upduser = (from client in db.Client where client.Id == 5 select client).First();
                if (upduser != null)
                {
                    upduser.Inn = upduser.Inn * 2;
                    db.SaveChanges();
                }
                var users = db.Client.ToArray();
                Console.WriteLine("Список объектов");
                foreach (Client u in users)
                {
                    Console.WriteLine(u.Inn + " - " + u.Telephon);
                }

            }

            //Delete
            using (ApplicationContext db = new ApplicationContext())
            {
                Client? deluser = (from client in db.Client where client.Id == 5 select client).First();
                if (deluser != null)
                {
                    db.Client.Remove(deluser);
                    db.SaveChanges();
                }
                var clients = db.Client.ToArray();
                Console.WriteLine("Список объектов");
                foreach (Client u in clients)
                {
                    Console.WriteLine(u.Inn + " - " + u.Telephon);
                }

            }

            //Create
            using (ApplicationContext db = new ApplicationContext())
            {
                var clients = db.Client.ToArray();

                var contract = db.Contracts.Where(c => c.Id == 1).FirstOrDefault();

                Client client = new Client { Id = 9, Inn = 1235476980, Telephon = "890065871", Contract = contract };


                db.Client.Add(client);

                db.SaveChanges();


            }

        }
    }
}
