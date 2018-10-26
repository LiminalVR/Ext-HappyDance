using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnable : MonoBehaviour
{

    public float timer;

    public GameObject hand;

    public GameObject objectToActivate;
    public GameObject objectToActivate2;
    public GameObject objectToActivate3;

    private void Start()
{


        objectToActivate.SetActive(false);
        objectToActivate2.SetActive(false);
        objectToActivate3.SetActive(false);

    }

    private void OnTriggerEnter(Collider hand)


    {

        StartCoroutine(ActivationRoutine());

    }

    private IEnumerator ActivationRoutine()
{
    //Wait for 14 secs.
    yield return new WaitForSeconds(timer);

        //Turn My game object that is set to false(off) to True(on).
        objectToActivate.SetActive(true);
        objectToActivate2.SetActive(true);
        objectToActivate3.SetActive(true);

        //Turn the Game Oject back off after 1 sec.
        // yield return new WaitForSeconds(1);

        //Game object will turn off
        //objectToActivate.SetActive(false);
    }
    }
