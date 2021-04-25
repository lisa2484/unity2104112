using UnityEngine;
using System;

public class TestControlScript : MonoBehaviour
{
    public Camera camera;
    void Start()
    {
    }

    void Update()
    {
        // Vector2 mouse = new Vector2(camera.ScreenToViewportPoint.x, Input.mousePosition.y);
        // Quaternion agin = new Quaternion(0, 0, Vector2.Angle(new Vector2(transform.position.x, transform.position.y), mouse), 0);
        // Debug.Log(mouse);
        // Debug.Log(new Vector2(transform.position.x, transform.position.y));
        // Debug.Log(Vector2.Angle(new Vector2(transform.position.x, transform.position.y), mouse));
        // transform.GetChild(0).rotation = agin;
    }
}
