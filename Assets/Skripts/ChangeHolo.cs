using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ChangeHolo : MonoBehaviour
{

    public GameObject[] holos;

    public int index = 0;

    public Renderer cubusLeft;
    public Renderer cubusRight;
    public TextMeshPro text;

    bool pressedLeft = false;

    bool pressedRight = false;

    private void Update()
    {
        if ((cubusLeft.material.color == Color.green) && !pressedLeft)
        {
            pressedLeft = true;
            holos[index].SetActive(false);
            if(index == 0)
            {
                index = holos.Length - 1;
            }
            else 
            {
                index--;
            }
            holos[index].SetActive(true);
            text.text = holos[index].name;
        }
        else if (cubusLeft.material.color != Color.green)
        {
            pressedLeft = false;
        }

        if ((cubusRight.material.color == Color.green) && !pressedRight)
        {
            pressedRight = true;
            holos[index].SetActive(false);
            if (index == holos.Length - 1)
            {
                index = 0;
            }
            else 
            {
                index++;
            }
            holos[index].SetActive(true);
            text.text = holos[index].name;

        }
        else if (cubusRight.material.color != Color.green)
        {
            pressedRight = false;
        }


    }
}
