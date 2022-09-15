using DSComponents;
using System;

namespace DevShed.Services
{
    public interface IStateContainer
    {
        public IDSCService DSCService {get;set;}
    }
}
