using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class windblow : MonoBehaviour
{
    private Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            anim.speed = 5f;
        }
        else
        {
            anim.speed = 0.1f;

        }
    }
}
