using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSurvivor : MonoBehaviour
{
    public Joystick movJoy;
    public bool crouch;
    public bool walk;

    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(movJoy.Horizontal >= 0.1)
        {
            walk = true;
        }
        else if(movJoy.Vertical >= 0.1)
        {
            walk = true;
        }
        else
        {
            walk = false;
        }

        anim.SetBool("Crouch", crouch);
        anim.SetBool("Walk", walk);
    }

    public void Animations()
    {
        if(crouch == false)
        {
            crouch = true;
        }
        if(crouch == true)
        {
            crouch = false;
        }
    }
}
