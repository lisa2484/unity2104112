using UnityEngine;

public class PlayerControlScript : MonoBehaviour
{
    public AudioClip PlayShoot;
    private float ShootWait = 0;
    void Start()
    {
        test t = new test("vvv");
        t.bb = "fff";
        Debug.Log(t.bb);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)) GetComponent<Animator>().SetBool("Run", true);
        else GetComponent<Animator>().SetBool("Run", false);
        if (Input.GetKeyDown(KeyCode.Z) && ShootWait <= 0)
        {
            ShootWait = 0.5f;
            GetComponent<Animator>().SetTrigger("Shoot");
            GetComponent<AudioSource>().PlayOneShot(PlayShoot);
        }
        if (ShootWait > 0)
        {
            ShootWait -= Time.deltaTime * 1;
        }
    }
}
