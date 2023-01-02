using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class SpaceShipMove : MonoBehaviour
{
    public GameObject celestial;

    // Update is called once per frame
    void FixedUpdate()
    {
        gameObject.transform.LookAt(2 * transform.position - celestial.transform.position);

        gameObject.transform.position = celestial.transform.position + new Vector3(10,0,0); 
    }

    void rotateAround()
    { 

            
    
    }
    
}
