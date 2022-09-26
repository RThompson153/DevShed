using DSComponents;
using DSComponents.Input.Models;

namespace DevShed.Services
{
	public class StateContainer : IStateContainer
    {
        public IDSCService DSCService { get; set; }

        public DSCInputConfig EditingConfig { get; set; }

        public StateContainer(IDSCService dscService)
        {
            DSCService = dscService;
        }
    }
}
