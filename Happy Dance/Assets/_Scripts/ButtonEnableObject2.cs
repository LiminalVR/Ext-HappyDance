using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonEnableObject2 : MonoBehaviour
{

    public float timer;

    public GameObject objectToActivate;
    public GameObject objectToActivate2;
    //public GameObject objectToActivate3;


    public GameObject objectToDeactivate;
    public GameObject objectToDeactivate2;



    private void Start()
    {

        //objectToActivate.SetActive(false);
        //objectToActivate2.SetActive(false);
        //StartCoroutine(ActivationRoutine());
    }

    //public IEnumerator ActivationRoutine()
    //{
    //    Wait for 14 secs.
    //    yield return new WaitForSeconds(timer);

    //    Turn My game object that is set to false(off) to True(on).
    //    objectToActivate.SetActive(true);
    //    objectToActivate2.SetActive(true);

    //    Turn the Game Oject back off after 1 sec.
    //    yield return new WaitForSeconds(2);

    //    Game object will turn off
    //    objectToDeactivate.SetActive(false);
    //    Destroy(objectToDeactivate);
    //}

    public void enableGameobjects()

    {

        objectToActivate.SetActive(true);
        objectToActivate2.SetActive(true);
        //objectToActivate3.SetActive(true);


        Destroy(objectToDeactivate, 0.5f);
        Destroy(objectToDeactivate2, 1);


    }
}