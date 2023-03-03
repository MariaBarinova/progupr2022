//База контрактов

namespace Praktica
{
    public class Contract
    {
        public int Id { get; set; }
        public int ContractCode { get; set; }
        public int ClientId { get; set; }
        public int RentaCode { get; set; }
        public Client? Client { get; set; }

    }
}