using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class JoystickControll : MonoBehaviour
{
    public Transform joystickTop;
    public TextMeshPro text;
    [SerializeField] private float forwardBackwardTilt;

    // Update is called once per frame
    void Update()
    {
        forwardBackwardTilt = joystickTop.rotation.eulerAngles.x;
        if (forwardBackwardTilt < 355 && forwardBackwardTilt > 290)
        {
            forwardBackwardTilt = Mathf.Abs(forwardBackwardTilt - 360);

        }
        else if (forwardBackwardTilt > 5 && forwardBackwardTilt < 74)
        {
            Debug.Log("Forward");
        }

    }

    private void OnCollisionStay(Collision collision)
    {
        text.text = collision.collider.gameObject.name;

        
        transform.LookAt(collision.collider.transform.position, transform.up);
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        text.text = collision.gameObject.name;
    }

}
