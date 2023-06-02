using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bganima : MonoBehaviour
{
    private Animator anim;
    private float distance = 0;
    private float speed = 0;
    private float timer = 0;
    public Text distanceUI;
    

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        windblow.winda = 30  ;
        windblow.windv = 10;  
    }

    
    // Update is called once per frame
    void Update()
    { 
        timer += Time.deltaTime;
        if (Input.GetKeyDown("space"))
        {
            anim.speed = 15f;

            // According to the University of Oklahoma Health Sciences Center,
            // the average step length for women is approximately 26 inches,
            distance += 0.66f;
            speed = (distance / timer)-(windblow.windv * (Mathf.Cos(windblow.winda)));
        }
        else
        {
            anim.speed = 0f;

        }
        distanceUI.text = "Distance: " + distance.ToString("F2") + " m\n" +
                              "Time: " + timer.ToString("F2") + " s\n" +
                              "Velocity(H): " + speed.ToString("F2") + "m/s\n" +
                              "Wind Force: " + windblow.windv.ToString("F2") + " to "+
                              windblow.winda.ToString("F0");

    }
}
