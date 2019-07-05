using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class EnableGirl : MonoBehaviour
    {

    public float timer;

    public GameObject objectToActivate;

	public AudioClip beam;
	AudioSource audioSource;

        private void Start()
        {

        objectToActivate.SetActive(false);
        StartCoroutine(ActivationRoutine());

		//audioSource = mainCamera.Find.GetComponent<AudioSource>();

		//AudioSource.PlayClipAtPoint(beam, new Vector3(5, 1, 2));

        }

        public IEnumerator ActivationRoutine()
        {
            //Wait for 14 secs.
            yield return new WaitForSeconds(timer);

            //Turn My game object that is set to false(off) to True(on).
            objectToActivate.SetActive(true);

		    //audioSource.PlayOneShot(beam, 1.0f);

		    AudioSource.PlayClipAtPoint(beam, new Vector3(5, 1, 2));

            //Turn the Game Oject back off after 1 sec.
           // yield return new WaitForSeconds(1);

            //Game object will turn off
            //objectToActivate.SetActive(false);
        }
    }
