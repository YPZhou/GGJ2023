using UnityEngine;
using UnityEngine.SceneManagement;

public class Level4Controller : BaseLevelController
{
	protected override void InitializeLevelComponents()
	{
		base.InitializeLevelComponents();

		var input = Instantiate(inputComponent).GetComponent<InputComponent>();
		input.SetCoords(5, 1);
		input.SetLevelBottomLeftPosition(BottomLeftPosition);
		CircuitComponents.Add(input);

		input = Instantiate(inputComponent).GetComponent<InputComponent>();
		input.SetCoords(3, 1);
		input.SetLevelBottomLeftPosition(BottomLeftPosition);
		CircuitComponents.Add(input);

		var output = Instantiate(outputComponent).GetComponent<OutputComponent>();
		output.SetCoords(1, 5);
		output.SetLevelBottomLeftPosition(BottomLeftPosition);
		output.RotateClockwise();
		CircuitComponents.Add(output);

		BaseCircuitComponent wire = Instantiate(turningWireComponent).GetComponent<TurningWireComponent>();
		wire.SetCoords(3, 3);
		wire.SetLevelBottomLeftPosition(BottomLeftPosition);
		wire.RotateClockwise();
		wire.RotateClockwise();
		CircuitComponents.Add(wire);

		wire = Instantiate(turningWireComponent).GetComponent<TurningWireComponent>();
		wire.SetCoords(1, 3);
		wire.SetLevelBottomLeftPosition(BottomLeftPosition);
		CircuitComponents.Add(wire);

		wire = Instantiate(turningWireComponent).GetComponent<TurningWireComponent>();
		wire.SetCoords(1, 4);
		wire.SetLevelBottomLeftPosition(BottomLeftPosition);
		wire.RotateClockwise();
		CircuitComponents.Add(wire);

		wire = Instantiate(wireComponent).GetComponent<WireComponent>();
		wire.SetCoords(5, 2);
		wire.SetLevelBottomLeftPosition(BottomLeftPosition);
		CircuitComponents.Add(wire);

		wire = Instantiate(wireComponent).GetComponent<WireComponent>();
		wire.SetCoords(5, 3);
		wire.SetLevelBottomLeftPosition(BottomLeftPosition);
		CircuitComponents.Add(wire);

		wire = Instantiate(wireComponent).GetComponent<WireComponent>();
		wire.SetCoords(4, 4);
		wire.SetLevelBottomLeftPosition(BottomLeftPosition);
		wire.RotateClockwise();
		CircuitComponents.Add(wire);

		wire = Instantiate(wireComponent).GetComponent<WireComponent>();
		wire.SetCoords(4, 5);
		wire.SetLevelBottomLeftPosition(BottomLeftPosition);
		wire.RotateClockwise();
		CircuitComponents.Add(wire);

		wire = Instantiate(wireComponent).GetComponent<WireComponent>();
		wire.SetCoords(3, 2);
		wire.SetLevelBottomLeftPosition(BottomLeftPosition);
		CircuitComponents.Add(wire);

		wire = Instantiate(wireComponent).GetComponent<WireComponent>();
		wire.SetCoords(2, 3);
		wire.SetLevelBottomLeftPosition(BottomLeftPosition);
		wire.RotateClockwise();
		CircuitComponents.Add(wire);

		wire = Instantiate(wireComponent).GetComponent<WireComponent>();
		wire.SetCoords(2, 4);
		wire.SetLevelBottomLeftPosition(BottomLeftPosition);
		wire.RotateClockwise();
		CircuitComponents.Add(wire);

		wire = Instantiate(wireComponent).GetComponent<WireComponent>();
		wire.SetCoords(2, 5);
		wire.SetLevelBottomLeftPosition(BottomLeftPosition);
		wire.RotateClockwise();
		CircuitComponents.Add(wire);

		BaseCircuitComponent node = Instantiate(nodeComponent).GetComponent<NodeComponent>();
		node.SetCoords(5, 4);
		node.SetLevelBottomLeftPosition(BottomLeftPosition);
		node.RotateClockwise();
		CircuitComponents.Add(node);

		node = Instantiate(nodeComponent).GetComponent<NodeComponent>();
		node.SetCoords(3, 5);
		node.SetLevelBottomLeftPosition(BottomLeftPosition);
		CircuitComponents.Add(node);

		node = Instantiate(threeWayNodeComponent).GetComponent<ThreeWayNodeComponent>();
		node.SetCoords(5, 5);
		node.SetLevelBottomLeftPosition(BottomLeftPosition);
		node.RotateClockwise();
		node.RotateClockwise();
		node.RotateClockwise();
		CircuitComponents.Add(node);

		node = Instantiate(turningNodeComponent).GetComponent<TurningNodeComponent>();
		node.SetCoords(3, 4);
		node.SetLevelBottomLeftPosition(BottomLeftPosition);
		CircuitComponents.Add(node);
	}

	protected override void UpdateCore()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			SceneManager.LoadScene("Level5");
		}
	}

	protected override string NextLevelName => "Level5";
}
