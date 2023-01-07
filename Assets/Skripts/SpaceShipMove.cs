using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class SpaceShipMove : MonoBehaviour
{
    public GameObject[] celestials;
    public int index = 0;
    public float distance = -8;
    //private int lastIndex = 0;

    // Update is called once per frame
    void FixedUpdate()
    {
        gameObject.transform.LookAt( (2 * transform.position)- celestials[index].transform.position  );

        if (celestials[index].name.Equals("Saturn") || celestials[index].name.Equals("Jupiter"))
        {
            distance = -50;
            gameObject.transform.position = celestials[index].transform.position + new Vector3(distance - (celestials[index].transform.localScale.x / 2), 0, 0);
        }
        else
        {
            distance = -8;
            gameObject.transform.position = celestials[index].transform.position + new Vector3(distance - (celestials[index].transform.localScale.x / 2), 0, 0);
        }
       
    }

    public void changePlanet(int index)
    {
        this.index = index;
    }
    
}
