using DSComponents;
using DSComponents.Input.Models;
using System;

namespace DevShed.Services
{
    public interface IStateContainer
    {
        public IDSCService DSCService { get; set; }
        public DSCInputConfig EditingConfig { get; set; }
    }
}
