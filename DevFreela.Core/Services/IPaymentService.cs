using DevFreela.Core.DTOs;
using System.Threading.Tasks;

namespace DevFreela.Core.Services
{
    public interface IPaymentService
    {
        public Task<bool> ProcessPayment(PaymentInfoDTO paymentInfoDTO);
    }
}
