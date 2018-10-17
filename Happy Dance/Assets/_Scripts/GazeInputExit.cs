using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GazeInputExit : MonoBehaviour
{

    public float timer;

    public GameObject objectToActivate;


    // Use this for initialization
    void Start()
    {

        objectToActivate.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {

    }


    public void GazeEnter()

    {

        //Debug.Log("Enter");


        StartCoroutine(ActivationRoutine());

        StartCoroutine("Quit");

    }


    public void GazeExit()

    {

        //Debug.Log("Exit");

    }



    private IEnumerator ActivationRoutine()
    {
        //Wait for 14 secs.
        yield return new WaitForSeconds(timer);

        //Turn My game object that is set to false(off) to True(on).
        objectToActivate.SetActive(true);

        //Turn the Game Oject back off after 1 sec.
        // yield return new WaitForSeconds(1);

        //Game object will turn off
        //objectToActivate.SetActive(false);
    }


    IEnumerator Quit()
    {
        yield return new WaitForSeconds(3);
        Application.Quit();

    }

}


