using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public GameObject lever;
    public GameObject spaceShip;
    public Animator doorsAnimator;
    public GameObject holotexts;
    private Animator spaceShipAnimator;
    public GameObject transition;
    public GameObject cockpit;
    public GameObject robot;

    private void Awake()
    {
        spaceShipAnimator = spaceShip.GetComponent<Animator>();
    }
    void Update()
    {

        float rotation = lever.transform.rotation.eulerAngles.z - 90;

        if (rotation >= 41)
        {
            rotation = rotation - 360;
        }
      
        if ((rotation < 20) && (rotation > -20))
        {
            rotation = 0;
        }
        else {
            doorsAnimator.SetTrigger("Start");
            spaceShipAnimator.SetTrigger("Start");
            holotexts.SetActive(false);
        }


        if (spaceShipAnimator.GetCurrentAnimatorStateInfo(0).IsName("Spaceship_start") && spaceShipAnimator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 0.99f)
        {
            cockpit.SetActive(false);
            robot.SetActive(false);
            SceneManager.LoadScene("Main");
        }

    }
}

