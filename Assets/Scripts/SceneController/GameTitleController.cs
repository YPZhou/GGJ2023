using UnityEngine;
using UnityEngine.SceneManagement;

public class GameTitleController : MonoBehaviour
{
	void Start()
	{
		var circuitSystem = new CircuitSystem();
		var inputComponent = new InputComponent(0, 0);
		var outputComponent = new OutputComponent(0, 2);
		var wireComponent = new WireComponent(0, 1);
		outputComponent.RotateClockwise();
		outputComponent.RotateClockwise();
		circuitSystem.CircuitComponents.Add(inputComponent);
		circuitSystem.CircuitComponents.Add(outputComponent);
		circuitSystem.CircuitComponents.Add(wireComponent);

		Debug.Log(string.Format("电路连通： {0}", circuitSystem.IsConnected));
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Alpha1))
		{
			SceneManager.LoadScene("Level1");
		}
	}
}
