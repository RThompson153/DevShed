using DevShed.Models;
using DSComponents;
using System.Collections.Generic;

namespace DevShed.Services
{
    public interface IStateContainer
    {
        public IDSCService DSCService { get; set; }
        public DSCConfig EditingConfig { get; set; }

        public List<TableRow> BuildAPITable<T>() where T : class, new();
    }
}
