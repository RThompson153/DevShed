using DSComponents;
using System;

namespace DevShed.Services
{
    public class StateContainer : IStateContainer
    {
        public IDSCService DSCService { get; set; }
        
        public StateContainer(IDSCService dscService)
        {
            DSCService = dscService;
        }
    }
}
