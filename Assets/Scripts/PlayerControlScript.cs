using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)) this.GetComponent<Animator>().SetBool("Run", true);
        else this.GetComponent<Animator>().SetBool("Run", false);
    }
}
