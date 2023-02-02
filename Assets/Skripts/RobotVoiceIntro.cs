using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;

public class RobotVoiceIntro : MonoBehaviour
{
    public Renderer button;
    public AudioSource robot;
    public AudioClip[] earth;
    public AudioClip[] jupiter;
    public AudioClip[] mars;
    public AudioClip[] mercury;
    public AudioClip[] neptune;
    public AudioClip[] saturn;
    public AudioClip[] uranus;
    public AudioClip[] venus;
    public GameObject currentPlanet;
    private bool pressed = false;
    public int index = 0;
    public TextMeshPro text;
    public Animator anim;
    public AudioSource intro;

    private void Start()
    {
        text.text = "null";
    }

    // Update is called once per frame
    void Update()
    {
        if(button.material.color == Color.green && !pressed)
        {

            pressed = true;
            anim.SetTrigger("rotate");
            anim.SetTrigger("wave");
          
           
           

               
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
