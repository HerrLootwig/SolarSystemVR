using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;

public class RobotVoice : MonoBehaviour
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

            switch (currentPlanet.name)
            {
                case "Earth":
                    robot.clip = earth[index];
                    robot.Play();
                    if(index + 1 == earth.Length)
                    {
                        index = 0;
                    }
                    else
                    {
                        index++;
                    }
                    break;

                case "Jupiter":
                    robot.clip = jupiter[index];
                    robot.Play();
                    if (index + 1 == jupiter.Length)
                    {
                        index = 0;
                    }
                    else
                    {
                        index++;
                    }
                    break;

                case "Mars":
                    robot.clip = mars[index];
                    robot.Play();
                    if (index + 1 == mars.Length)
                    {
                        index = 0;
                    }
                    else
                    {
                        index++;
                    }
                    break;

                case "Mercury":
                    robot.clip = mercury[index];
                    robot.Play();
                    if (index + 1 == mercury.Length)
                    {
                        index = 0;
                    }
                    else
                    {
                        index++;
                    }
                    break;

                case "Neptune":
                    robot.clip = neptune[index];
                    robot.Play();
                    if (index + 1 == neptune.Length)
                    {
                        index = 0;
                    }
                    else
                    {
                        index++;
                    }
                    break;

                case "Saturn":
                    robot.clip = saturn[index];
                    robot.Play();
                    if (index + 1 == saturn.Length)
                    {
                        index = 0;
                    }
                    else
                    {
                        index++;
                    }
                    break;

                case "Uranus":
                    robot.clip = uranus[index];
                    robot.Play();
                    if (index + 1 == uranus.Length)
                    {
                        index = 0;
                    }
                    else
                    {
                        index++;
                    }
                    break;

                case "Venus":
                    robot.clip = venus[index];
                    robot.Play();
                    if (index + 1 == venus.Length)
                    {
                        index = 0;
                    }
                    else
                    {
                        index++;
                    }
                    break;
            } 
        }
        else if (button.material.color != Color.green)
        {
            pressed = false;
        }

    }
}
