using UnityEngine;

public class TestControlScript : MonoBehaviour
{
    public Camera MyCamera;
    public GameObject Thruster;
    void Start()
    {
    }

    void Update()
    {
        Vector2 mouse = MyCamera.ScreenToWorldPoint(Input.mousePosition);
        Vector2 MousePosition = (new Vector2(transform.position.x, transform.position.y) - mouse) * -1;
        transform.GetChild(0).up = MousePosition;
        if (Input.GetMouseButton(1))
        {
            Rigidbody2D obrb2d = GetComponent<Rigidbody2D>();
            if (obrb2d.velocity.magnitude < 5)
                obrb2d.AddForce(MousePosition);
            var main = Thruster.GetComponent<ParticleSystem>().main;
            main.maxParticles = 100;
            Debug.Log(obrb2d.velocity.magnitude);
        }
        else
        {
            var main = Thruster.GetComponent<ParticleSystem>().main;
            main.maxParticles = 0;
        }
    }
}
