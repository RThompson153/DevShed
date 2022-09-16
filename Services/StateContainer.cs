using DSComponents;
using DSComponents.Input.Models;
using System;
using System.Collections.Generic;

namespace DevShed.Services
{
    public class StateContainer : IStateContainer
    {
        public IDSCService DSCService { get; set; }

        private IEnumerable<DSCInputConfig> _dscInputConfigs;
        public IEnumerable<DSCInputConfig> DSCInputConfigs
        {
            get => _dscInputConfigs ?? new List<DSCInputConfig>();
            set => _dscInputConfigs = value;
        }

        public StateContainer(IDSCService dscService)
        {
            DSCService = dscService;
        }
    }
}
