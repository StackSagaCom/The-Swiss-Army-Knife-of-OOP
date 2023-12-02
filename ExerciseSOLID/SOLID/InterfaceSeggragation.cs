using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.SOLID
{
    //public class ForecedInterfacePayment : IPaymentAll
    //{
    //    public Task EPay()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Task PayWithCrypto()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    //public interface IPaymentAll
    //{
    //    Task EPay();
    //    Task PayWithCrypto();
    //}

    public class SimpleFlexibileInterfacePayment : IPayment
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

        public Task PayWithCrypto()
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
        Task PayWithCrypto();
    }
}
