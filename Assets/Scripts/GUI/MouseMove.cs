using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMove : MonoBehaviour
{
    public Transform backgound;
    public Transform forwardGround;

    public Vector2 delta;

    // Update is called once per frame
    void Update()
    {
        Vector3 screenSize = new Vector3(Screen.width, Screen.height);
        Vector2 mousePos = Input.mousePosition - screenSize / 2;
        mousePos.x = mousePos.x / screenSize.x;
        mousePos.y = mousePos.y / screenSize.y;

        backgound.position = mousePos * delta;
        forwardGround.position = -mousePos * delta;
    }
}
