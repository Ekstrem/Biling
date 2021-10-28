using System;
using Domain.Abstraction;

namespace Domain.Implementation
{
    public class Root : IBillingRoot
    {
        private readonly string _subscriberId;
        private readonly string _partnerCode;

        private Root(string subscriberId, string partnerCode)
        {
            _subscriberId = subscriberId;
            _partnerCode = partnerCode;
        }

        public string SubscriberId => _subscriberId;

        public string PartnerCode => _partnerCode;

        public override string ToString() => $"Id: {_subscriberId}; Code: {_partnerCode}";

        public override bool Equals(object? obj)
            => obj is IBillingRoot root
               && _subscriberId == root.SubscriberId
               && _partnerCode == root.PartnerCode;

        protected bool Equals(Root other)
            => _subscriberId == other._subscriberId
               && _partnerCode == other._partnerCode;

        public override int GetHashCode()
            => HashCode.Combine(_subscriberId, _partnerCode);
        
        public static Root Create(string subscriberId, string partnerCode)
            => new Root(subscriberId, partnerCode);
    }
}