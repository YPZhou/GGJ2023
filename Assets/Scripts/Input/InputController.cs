using System;
using UnityEngine;

public class InputController : MonoBehaviour
{

    private BaseCircuitComponent selectedNode;

    private Color originColor;


    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        ClickNodeUpdate();
        SwapNodeUpdate();
    }

    /// <summary>
    /// 单击元件旋转。
    /// </summary>
    void ClickNodeUpdate()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            var node = GetNodeByMousePosition();
            if (node == null)
            {
                return;
            }
            node.RotateClockwise();
            UnSelectNode();
        }
        
    }

    /// <summary>
    /// 元件交换位置。
    /// </summary>
    void SwapNodeUpdate()
    {

        if (Input.GetMouseButtonDown(1))
        {
            var node = GetNodeByMousePosition();
            if (node == null)
            {
                return;
            }

            if (selectedNode == null)
            {
                SelectNode(node);
            }
            else if (selectedNode.Equals(node))
            {
                UnSelectNode();
            }
            else
            {
                selectedNode.Swap(node);
            }
        }

    }

    void SelectNode(BaseCircuitComponent node)
    {
        selectedNode = node;
        var sr = selectedNode.GetComponent<SpriteRenderer>();
        originColor = sr.color;
        sr.color = Color.gray;
    }


    void UnSelectNode()
    {
        if (selectedNode == null)
        {
            return;
        }

        var sr = selectedNode.GetComponent<SpriteRenderer>();
        sr.color = originColor;
        selectedNode = null;
    }

    BaseCircuitComponent GetNodeByMousePosition()
    {
        // 获取鼠标位置。
        var mp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        var c = Physics2D.OverlapPoint(mp);
        if (c != null)
        {
            var circuit = c.GetComponent<BaseCircuitComponent>();
            if (circuit.ComponentType == Constants.ComponentType.NODE)
            {
                return circuit;
            }
        }
        return null;
    }

}