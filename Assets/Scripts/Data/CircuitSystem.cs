using System.Collections.Generic;
using System.Linq;
using static Constants;

public class CircuitSystem
{
	public bool IsConnected
	{
		get
		{
			var result = false;
			var inputComponents = CircuitComponents.Where(component => component.ComponentType == ComponentType.INPUT);
			var outputComponents = CircuitComponents.Where(component => component.ComponentType == ComponentType.OUTPUT);
			if (inputComponents.Any() && outputComponents.Any())
			{

			}

			return result;
		}
	}

	List<BaseCircuitComponent> CircuitComponents => circuitComponents ?? (circuitComponents = new List<BaseCircuitComponent>());
	List<BaseCircuitComponent> circuitComponents;
}
