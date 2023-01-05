using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class SpaceShipMove : MonoBehaviour
{
    public GameObject[] celestials;
    public int index = 0;
    //private int lastIndex = 0;

    // Update is called once per frame
    void FixedUpdate()
    {
        gameObject.transform.LookAt( (2 * transform.position)- celestials[index].transform.position  );

        if (celestials[index].name.Equals("Saturn") || celestials[index].name.Equals("Jupiter"))
        {
            gameObject.transform.position = celestials[index].transform.position + new Vector3(-50 - (celestials[index].transform.localScale.x / 2), 0, 0);
        }
        else
        {
            gameObject.transform.position = celestials[index].transform.position + new Vector3(-8 - (celestials[index].transform.localScale.x / 2), 0, 0);
        }
       
    }

    public void changePlanet(int index)
    {
        this.index = index;
    }
    
}
