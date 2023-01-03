using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GoIntoHyperspace : MonoBehaviour
{
    public TextMeshPro text;
    public Renderer cubus;
    public GameObject hyperspace;
    private bool pressed = false;
    public SpaceShipMove ssm;

    private void Update()
    {
        text.text = cubus.material.color.ToString();
        if ((cubus.material.color == Color.green) && !pressed)
        {
            hyperspace.SetActive(true);
            ssm.changePlanet();
            pressed = true;
            text.text = pressed.ToString();
        } else
        {
            pressed = false;
        }

        if (hyperspace.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).normalizedTime >= 0.98f)
        {
            hyperspace.SetActive(false);
        }
    }
}
