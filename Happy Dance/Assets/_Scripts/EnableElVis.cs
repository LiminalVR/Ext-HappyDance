using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableElVis : MonoBehaviour

{

    public float timer;

    public GameObject objectToActivate1;
    public GameObject objectToActivate2;
    public GameObject objectToActivate3;
    public GameObject objectToActivate4;

    private void Start()
    {

        objectToActivate1.SetActive(false);
        objectToActivate2.SetActive(false);
        objectToActivate3.SetActive(false);
        objectToActivate4.SetActive(false);
        StartCoroutine(ActivationRoutine());
    }

    private IEnumerator ActivationRoutine()
    {
        //Wait for 14 secs.
        yield return new WaitForSeconds(timer);

        //Turn My game object that is set to false(off) to True(on).
        objectToActivate1.SetActive(true);
        objectToActivate2.SetActive(true);
        objectToActivate3.SetActive(true);
        objectToActivate4.SetActive(true);

        //Turn the Game Oject back off after 1 sec.
        // yield return new WaitForSeconds(1);

        //Game object will turn off
        //objectToActivate.SetActive(false);
    }
}
