using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Oculus.Interaction;

public class SpaceShipControlls : MonoBehaviour
{
    public GameObject lever;
    public TextMeshPro text;
    public GameObject spaceShip;
    public SpaceShipMove SpaceShipMove;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        float rotation = lever.transform.rotation.eulerAngles.z;
        if (rotation >= 41)
        {
            rotation = rotation - 360;
        }
        //text.text = rotation.ToString();
        SpaceShipMove.distance = SpaceShipMove.distance + rotation*0.01f ;
        text.text = SpaceShipMove.distance.ToString();
   
    }
}
