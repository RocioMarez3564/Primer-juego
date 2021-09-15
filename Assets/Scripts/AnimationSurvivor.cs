using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSurvivor : MonoBehaviour
{
    public Joystick movJoy;
    public float run;
    public float runLeft;

    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(movJoy.Vertical >= 0.1)
        {
            run = 1;
        }
        else if(movJoy.Vertical <= -0.1)
        {
            run = -1;
        }
        else
        {
            run = 0;
        }
        if(movJoy.Horizontal >= 0.1)
        {
            runLeft = -1;
        }
        else if(movJoy.Horizontal <= -0.1)
        {
            runLeft = 1;
        }
        else
        {
            runLeft = 0;
        }

        anim.SetFloat("Run", run);
        anim.SetFloat("RunLeft", runLeft);
    }
}