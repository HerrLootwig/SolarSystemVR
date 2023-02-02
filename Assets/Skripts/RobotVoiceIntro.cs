using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;

public class RobotVoiceIntro : MonoBehaviour
{
    public Renderer button;
    private bool pressed = false;
    public Animator anim;
    public AudioSource intro;

   

    // Update is called once per frame
    void Update()
    {
        //anim.SetTrigger("rotate");
    
        if (button.material.color == Color.green && !pressed)
        {

            pressed = true;
            anim.Play("robotWave");
          
           
           

               
        }
        else if (button.material.color != Color.green)
        {
            pressed = false;
        }

        if(anim.GetCurrentAnimatorStateInfo(0).IsName("robotWave") && anim.GetCurrentAnimatorStateInfo(0).normalizedTime >= 0.5f)
        {
            intro.Play();
        }

    }
}
