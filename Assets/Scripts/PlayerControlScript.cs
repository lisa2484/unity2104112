using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlScript : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip PlayShoot;
    private float ShootWait = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
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
        if(ShootWait > 0)
        {
            ShootWait -= Time.deltaTime * 1;
        }
    }
}
