using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.SOLID
{
    public class ForecedInterfacePayment : IPayment
    {
        public Task EPay()
        {
            throw new NotImplementedException();
        }
    }
    public class FlexibileInterfacePayment : IPayment, ICryptoPayment
    {
        public Task EPay()
        {
            throw new NotImplementedException();
        }

        public Task payWithCrypto()
        {
            throw new NotImplementedException();
        }
    }
    public interface IPayment
    {
        Task EPay();
    }
    public interface ICryptoPayment 
    {
        Task payWithCrypto();
    }
}
