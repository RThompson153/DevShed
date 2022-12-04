using DevShed.Models;
using DSComponents;
using DSComponents.Input.Models;
using System.Collections.Generic;
using System.Linq;

namespace DevShed.Services
{
	public class StateContainer : IStateContainer
    {
        public IDSCService DSCService { get; set; }

        public DSCConfig EditingConfig { get; set; }

        public StateContainer(IDSCService dscService)
        {
            DSCService = dscService;
        }

        public List<TableRow> BuildAPITable<T>() where T : class, new()
		{
			var model = new T();
			var properties = model.GetType().GetProperties();

			var rows = new List<TableRow>();

			foreach(var prop in properties)
			{
				var attr = prop.GetCustomAttributes(true).FirstOrDefault() as DSCConfigAttribute;

				if (attr is null)
					continue;

				var row = new TableRow
				{
					Property = prop.Name,
					Type = $"{((attr?.Required == true) ? "Required" : "Optional")} - {attr?.Type}",
					Description = attr?.Description ?? "",
					DefaultValue = prop.GetValue(model)?.ToString() ?? "null"
				};

				rows.Add(row);
			}

			return rows;
		}
    }
}
