using UnityEngine;

public class TestControlScript : MonoBehaviour
{
    public Camera MyCamera;
    void Start()
    {
    }

    void Update()
    {
        Vector2 mouse = MyCamera.ScreenToWorldPoint(Input.mousePosition);
        Vector2 MousePosition = (new Vector2(transform.position.x, transform.position.y) - mouse) * -1;
        if (Input.GetMouseButton(1))
        {
            GetComponent<Rigidbody2D>().AddForce(MousePosition);
        }
    }
}
