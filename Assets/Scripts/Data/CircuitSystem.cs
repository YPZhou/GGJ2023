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
				result = outputComponents.All(outputComponent => inputComponents.Any(inputComponent => HasPath(inputComponent, outputComponent)));
			}

			return result;
		}
	}

	bool HasPath(BaseCircuitComponent originComponent, BaseCircuitComponent targetComponent)
	{
		var openComponents = new List<BaseCircuitComponent>() { originComponent };
		var visitedComponents = new List<BaseCircuitComponent>();

		while (openComponents.Count > 0)
		{
			// Take first open component
			var currentComponent = openComponents[0];

			// Add non-visited connected component to open list
			foreach (var component in CircuitComponents)
			{
				if (component != currentComponent && !visitedComponents.Contains(component))
				{
					if (currentComponent.IsConnected(component))
					{
						openComponents.Add(component);
					}
				}
			}

			// Move current open component to visited list
			visitedComponents.Add(currentComponent);
			openComponents.Remove(currentComponent);
		}

		return visitedComponents.Any(component => component.TileCoords.Item1 == targetComponent.TileCoords.Item1 && component.TileCoords.Item2 == targetComponent.TileCoords.Item2);
	}

	public List<BaseCircuitComponent> CircuitComponents => circuitComponents ?? (circuitComponents = new List<BaseCircuitComponent>());
	List<BaseCircuitComponent> circuitComponents;
}
