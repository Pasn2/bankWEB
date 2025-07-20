

using TestBlazor;

namespace BankApi
{
    public class TransactionResponse
    {
        public List<TransactionDTO> Sent { get; set; }
        public List<TransactionDTO> Received { get; set; }
    }
}
