using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class SpaceShipMove : MonoBehaviour
{
    public GameObject[] celestials;
    int index = 0;

    // Update is called once per frame
    void FixedUpdate()
    {
        gameObject.transform.LookAt(2 * transform.position - celestials[index].transform.position);

        gameObject.transform.position = celestials[index].transform.position + new Vector3(0.1f,0,0); 
    }

    void rotateAround()
    { 

            
    
    }

    public void changePlanet()
    {
        if(index != 1)
        {
            index = 1;
        }
        else
        {
            index = 0;
        }
    }
    
}
