using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class GoIntoHyperspace : MonoBehaviour
{
    public TextMeshPro text;
    public Renderer cubus;
    public GameObject hyperspace;
    private bool pressed = false;
    public SpaceShipMove ssm;
    public ChangeHolo ch;
    public int index;

    private void Update()
    {
        index = ch.index;

        text.text = ssm.celestials[ssm.index].name.ToString() + " " + ssm.index;
        if ((cubus.material.color == Color.green) && !pressed)
        {
            hyperspace.SetActive(true);
            ssm.changePlanet(index);
            pressed = true;
            text.text = ssm.celestials[ssm.index].name.ToString();
        } else if ((cubus.material.color != Color.green))
        {
            pressed = false;
        }

        if (hyperspace.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).normalizedTime >= 0.98f)
        {
            hyperspace.SetActive(false);
        }
    }
}
