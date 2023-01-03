using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeHolo : MonoBehaviour
{

    public GameObject[] holos;

    public int index = 0;

    public Renderer cubusLeft;
    public Renderer cubusRight;

    bool pressedLeft = false;

    bool pressedRight = false;

    private void Update()
    {
        if ((cubusLeft.material.color == Color.green) && !pressedLeft)
        {
            holos[index].SetActive(false);
            if(index == 0)
            {
                index = holos.Length - 1;
            }
            else
            {
                index--;
            }
            pressedLeft = true;
            holos[index].SetActive(true);
        }
        else
        {
            pressedLeft = false;
        }

        if ((cubusRight.material.color == Color.green) && !pressedRight)
        {
            holos[index].SetActive(false);
            if (index == holos.Length - 1)
            {
                index = 0;
            }
            else
            {
                index++;
            }
            pressedRight = true;
            holos[index].SetActive(true);

        }
        else
        {
            pressedRight = false;
        }


    }
}
