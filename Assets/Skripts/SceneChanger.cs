using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SceneChanger : MonoBehaviour
{
    public GameObject lever;
    public GameObject spaceShip;
    public TextMeshPro text;

    // Update is called once per frame
    void Update()
    {

        float rotation = lever.transform.rotation.eulerAngles.z - 90;

        text.text = rotation.ToString();
        if (rotation >= 41)
        {
            rotation = rotation - 360;
        }
      
        if ((rotation < 20) && (rotation > -20))
        {
            rotation = 0;
        }
        else { spaceShip.transform.Translate(new Vector3(0,0.001f, rotation * 0.0005f)); }
        

    }
}

