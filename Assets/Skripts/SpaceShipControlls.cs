using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Oculus.Interaction;
using System;
using Unity.VisualScripting;

public class SpaceShipControlls : MonoBehaviour
{
    public GameObject lever;
    public TextMeshPro text;
    public GameObject spaceShip;
    public SpaceShipMove SpaceShipMove;

    private bool start = true;
    private bool stop = false;

    public AudioClip startSound;
    public AudioClip stopSound;
    public AudioClip runningSound;
    public AudioSource audioSource;


    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        float rotation = lever.transform.rotation.eulerAngles.z - 90;
        if (rotation >= 41)
        {
            rotation = rotation - 360;
        }
        //text.text = rotation.ToString();
      /*  if (SpaceShipMove.celestials[SpaceShipMove.index].name.Equals("Saturn") || SpaceShipMove.celestials[SpaceShipMove.index].name.Equals("Jupiter"))
        {
            SpaceShipMove.distance = SpaceShipMove.distance - 50;
        }*/
        if (SpaceShipMove.distance > -7f)
        {
            SpaceShipMove.distance = -7f;
        }else if(SpaceShipMove.distance < -100f)
        {
            SpaceShipMove.distance = -100f;
        }
        //SpaceShipMove.distance = SpaceShipMove.distance + rotation*0.001f ;
        if((rotation<20) && ( rotation > -20))
        {
            rotation = 0;

        }
        else if (start)
        {
            start = false;
            audioSource.PlayOneShot(startSound);
            audioSource.Play();
            stop = true;
        }

        if (rotation == 0 && stop)
        {
            audioSource.Stop();
            audioSource.PlayOneShot(stopSound);
            stop = false;
            start = true;
        }

        SpaceShipMove.distance = SpaceShipMove.distance - rotation * 0.001f;
   
    }
}
