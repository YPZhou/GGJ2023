using UnityEngine;
using UnityEngine.SceneManagement;

public class Level5Controller : BaseLevelController
{
	protected override void InitializeLevelComponents()
	{
		base.InitializeLevelComponents();

		var input = Instantiate(inputComponent).GetComponent<InputComponent>();
		input.SetCoords(10, 1);
		input.SetLevelBottomLeftPosition(BottomLeftPosition);
		input.RotateClockwise();
		CircuitComponents.Add(input);

		input = Instantiate(inputComponent).GetComponent<InputComponent>();
		input.SetCoords(9, 1);
		input.SetLevelBottomLeftPosition(BottomLeftPosition);
		CircuitComponents.Add(input);

		input = Instantiate(inputComponent).GetComponent<InputComponent>();
		input.SetCoords(11, 5);
		input.SetLevelBottomLeftPosition(BottomLeftPosition);
		input.RotateClockwise();
		input.RotateClockwise();
		input.RotateClockwise();
		CircuitComponents.Add(input);

		var output = Instantiate(outputComponent).GetComponent<OutputComponent>();
		output.SetCoords(2, 1);
		output.SetLevelBottomLeftPosition(BottomLeftPosition);
		CircuitComponents.Add(output);

		output = Instantiate(outputComponent).GetComponent<OutputComponent>();
		output.SetCoords(1, 1);
		output.SetLevelBottomLeftPosition(BottomLeftPosition);
		CircuitComponents.Add(output);

		BaseCircuitComponent wire = Instantiate(turningWireComponent).GetComponent<TurningWireComponent>();
		wire.SetCoords(11, 1);
		wire.SetLevelBottomLeftPosition(BottomLeftPosition);
		wire.RotateClockwise();
		wire.RotateClockwise();
		wire.RotateClockwise();
		CircuitComponents.Add(wire);

		wire = Instantiate(turningWireComponent).GetComponent<TurningWireComponent>();
		wire.SetCoords(11, 3);
		wire.SetLevelBottomLeftPosition(BottomLeftPosition);
		wire.RotateClockwise();
		wire.RotateClockwise();
		CircuitComponents.Add(wire);

		wire = Instantiate(turningWireComponent).GetComponent<TurningWireComponent>();
		wire.SetCoords(7, 5);
		wire.SetLevelBottomLeftPosition(BottomLeftPosition);
		wire.RotateClockwise();
		CircuitComponents.Add(wire);

		wire = Instantiate(turningWireComponent).GetComponent<TurningWireComponent>();
		wire.SetCoords(5, 5);
		wire.SetLevelBottomLeftPosition(BottomLeftPosition);
		wire.RotateClockwise();
		wire.RotateClockwise();
		CircuitComponents.Add(wire);

		wire = Instantiate(turningWireComponent).GetComponent<TurningWireComponent>();
		wire.SetCoords(4, 1);
		wire.SetLevelBottomLeftPosition(BottomLeftPosition);
		CircuitComponents.Add(wire);

		wire = Instantiate(threeWayWireComponent).GetComponent<ThreeWayWireComponent>();
		wire.SetCoords(7, 1);
		wire.SetLevelBottomLeftPosition(BottomLeftPosition);
		CircuitComponents.Add(wire);

		wire = Instantiate(threeWayWireComponent).GetComponent<ThreeWayWireComponent>();
		wire.SetCoords(3, 5);
		wire.SetLevelBottomLeftPosition(BottomLeftPosition);
		wire.RotateClockwise();
		wire.RotateClockwise();
		CircuitComponents.Add(wire);

		wire = Instantiate(threeWayWireComponent).GetComponent<ThreeWayWireComponent>();
		wire.SetCoords(1, 3);
		wire.SetLevelBottomLeftPosition(BottomLeftPosition);
		wire.RotateClockwise();
		CircuitComponents.Add(wire);

		wire = Instantiate(wireComponent).GetComponent<WireComponent>();
		wire.SetCoords(11, 2);
		wire.SetLevelBottomLeftPosition(BottomLeftPosition);
		CircuitComponents.Add(wire);

		wire = Instantiate(wireComponent).GetComponent<WireComponent>();
		wire.SetCoords(10, 4);
		wire.SetLevelBottomLeftPosition(BottomLeftPosition);
		CircuitComponents.Add(wire);

		wire = Instantiate(wireComponent).GetComponent<WireComponent>();
		wire.SetCoords(9, 4);
		wire.SetLevelBottomLeftPosition(BottomLeftPosition);
		CircuitComponents.Add(wire);

		wire = Instantiate(wireComponent).GetComponent<WireComponent>();
		wire.SetCoords(9, 2);
		wire.SetLevelBottomLeftPosition(BottomLeftPosition);
		CircuitComponents.Add(wire);

		wire = Instantiate(wireComponent).GetComponent<WireComponent>();
		wire.SetCoords(8, 4);
		wire.SetLevelBottomLeftPosition(BottomLeftPosition);
		CircuitComponents.Add(wire);

		wire = Instantiate(wireComponent).GetComponent<WireComponent>();
		wire.SetCoords(8, 3);
		wire.SetLevelBottomLeftPosition(BottomLeftPosition);
		CircuitComponents.Add(wire);

		wire = Instantiate(wireComponent).GetComponent<WireComponent>();
		wire.SetCoords(8, 2);
		wire.SetLevelBottomLeftPosition(BottomLeftPosition);
		CircuitComponents.Add(wire);

		wire = Instantiate(wireComponent).GetComponent<WireComponent>();
		wire.SetCoords(7, 4);
		wire.SetLevelBottomLeftPosition(BottomLeftPosition);
		CircuitComponents.Add(wire);

		wire = Instantiate(wireComponent).GetComponent<WireComponent>();
		wire.SetCoords(7, 3);
		wire.SetLevelBottomLeftPosition(BottomLeftPosition);
		CircuitComponents.Add(wire);

		wire = Instantiate(wireComponent).GetComponent<WireComponent>();
		wire.SetCoords(7, 2);
		wire.SetLevelBottomLeftPosition(BottomLeftPosition);
		CircuitComponents.Add(wire);

		wire = Instantiate(wireComponent).GetComponent<WireComponent>();
		wire.SetCoords(6, 1);
		wire.SetLevelBottomLeftPosition(BottomLeftPosition);
		wire.RotateClockwise();
		CircuitComponents.Add(wire);

		wire = Instantiate(wireComponent).GetComponent<WireComponent>();
		wire.SetCoords(5, 4);
		wire.SetLevelBottomLeftPosition(BottomLeftPosition);
		CircuitComponents.Add(wire);

		wire = Instantiate(wireComponent).GetComponent<WireComponent>();
		wire.SetCoords(5, 3);
		wire.SetLevelBottomLeftPosition(BottomLeftPosition);
		CircuitComponents.Add(wire);

		wire = Instantiate(wireComponent).GetComponent<WireComponent>();
		wire.SetCoords(5, 2);
		wire.SetLevelBottomLeftPosition(BottomLeftPosition);
		CircuitComponents.Add(wire);

		wire = Instantiate(wireComponent).GetComponent<WireComponent>();
		wire.SetCoords(4, 4);
		wire.SetLevelBottomLeftPosition(BottomLeftPosition);
		CircuitComponents.Add(wire);

		wire = Instantiate(wireComponent).GetComponent<WireComponent>();
		wire.SetCoords(4, 3);
		wire.SetLevelBottomLeftPosition(BottomLeftPosition);
		CircuitComponents.Add(wire);

		wire = Instantiate(wireComponent).GetComponent<WireComponent>();
		wire.SetCoords(4, 2);
		wire.SetLevelBottomLeftPosition(BottomLeftPosition);
		CircuitComponents.Add(wire);

		wire = Instantiate(wireComponent).GetComponent<WireComponent>();
		wire.SetCoords(3, 4);
		wire.SetLevelBottomLeftPosition(BottomLeftPosition);
		CircuitComponents.Add(wire);

		wire = Instantiate(wireComponent).GetComponent<WireComponent>();
		wire.SetCoords(2, 5);
		wire.SetLevelBottomLeftPosition(BottomLeftPosition);
		wire.RotateClockwise();
		CircuitComponents.Add(wire);

		wire = Instantiate(wireComponent).GetComponent<WireComponent>();
		wire.SetCoords(2, 2);
		wire.SetLevelBottomLeftPosition(BottomLeftPosition);
		CircuitComponents.Add(wire);

		wire = Instantiate(wireComponent).GetComponent<WireComponent>();
		wire.SetCoords(1, 2);
		wire.SetLevelBottomLeftPosition(BottomLeftPosition);
		CircuitComponents.Add(wire);

		wire = Instantiate(wireComponent).GetComponent<WireComponent>();
		wire.SetCoords(1, 4);
		wire.SetLevelBottomLeftPosition(BottomLeftPosition);
		CircuitComponents.Add(wire);

		BaseCircuitComponent node = Instantiate(nodeComponent).GetComponent<NodeComponent>();
		node.SetCoords(2, 3);
		node.SetLevelBottomLeftPosition(BottomLeftPosition);
		CircuitComponents.Add(node);

		node = Instantiate(threeWayNodeComponent).GetComponent<ThreeWayNodeComponent>();
		node.SetCoords(10, 5);
		node.SetLevelBottomLeftPosition(BottomLeftPosition);
		node.RotateClockwise();
		node.RotateClockwise();
		node.RotateClockwise();
		CircuitComponents.Add(node);

		node = Instantiate(threeWayNodeComponent).GetComponent<ThreeWayNodeComponent>();
		node.SetCoords(10, 3);
		node.SetLevelBottomLeftPosition(BottomLeftPosition);
		CircuitComponents.Add(node);

		node = Instantiate(threeWayNodeComponent).GetComponent<ThreeWayNodeComponent>();
		node.SetCoords(5, 1);
		node.SetLevelBottomLeftPosition(BottomLeftPosition);
		node.RotateClockwise();
		node.RotateClockwise();
		CircuitComponents.Add(node);

		node = Instantiate(threeWayNodeComponent).GetComponent<ThreeWayNodeComponent>();
		node.SetCoords(4, 5);
		node.SetLevelBottomLeftPosition(BottomLeftPosition);
		node.RotateClockwise();
		node.RotateClockwise();
		node.RotateClockwise();
		CircuitComponents.Add(node);

		node = Instantiate(threeWayNodeComponent).GetComponent<ThreeWayNodeComponent>();
		node.SetCoords(3, 3);
		node.SetLevelBottomLeftPosition(BottomLeftPosition);
		node.RotateClockwise();
		node.RotateClockwise();
		node.RotateClockwise();
		CircuitComponents.Add(node);

		node = Instantiate(threeWayNodeComponent).GetComponent<ThreeWayNodeComponent>();
		node.SetCoords(1, 5);
		node.SetLevelBottomLeftPosition(BottomLeftPosition);
		node.RotateClockwise();
		node.RotateClockwise();
		CircuitComponents.Add(node);

		node = Instantiate(turningNodeComponent).GetComponent<TurningNodeComponent>();
		node.SetCoords(9, 5);
		node.SetLevelBottomLeftPosition(BottomLeftPosition);
		node.RotateClockwise();
		node.RotateClockwise();
		node.RotateClockwise();
		CircuitComponents.Add(node);

		node = Instantiate(turningNodeComponent).GetComponent<TurningNodeComponent>();
		node.SetCoords(9, 3);
		node.SetLevelBottomLeftPosition(BottomLeftPosition);
		node.RotateClockwise();
		node.RotateClockwise();
		node.RotateClockwise();
		CircuitComponents.Add(node);

		node = Instantiate(turningNodeComponent).GetComponent<TurningNodeComponent>();
		node.SetCoords(8, 5);
		node.SetLevelBottomLeftPosition(BottomLeftPosition);
		CircuitComponents.Add(node);

		node = Instantiate(turningNodeComponent).GetComponent<TurningNodeComponent>();
		node.SetCoords(8, 1);
		node.SetLevelBottomLeftPosition(BottomLeftPosition);
		node.RotateClockwise();
		CircuitComponents.Add(node);
	}

	protected override void UpdateCore()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			SceneManager.LoadScene("GameTitle");
		}
	}

	protected override string NextLevelName => "GameTitle";
}
