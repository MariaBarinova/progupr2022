//База клиентов

using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Praktica
{
    public class Client
    {
        internal Contract? Contract;

        public int Id { get; set; }
        public int Inn { get; set; }
        public string? Telephon { get; set; }
        public LinkedList<Contract> Contracts { get; set; } = new();
       

    }


}
