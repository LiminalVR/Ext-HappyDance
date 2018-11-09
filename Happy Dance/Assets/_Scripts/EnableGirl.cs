using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class EnableGirl : MonoBehaviour
    {

    public float timer;

    public GameObject objectToActivate;

        private void Start()
        {

        objectToActivate.SetActive(false);
        StartCoroutine(ActivationRoutine());
        }

        public IEnumerator ActivationRoutine()
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
    }
