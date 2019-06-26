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
            if (objectToActivate != null)
            {
                objectToActivate.SetActive(false);
            }
        
            StartCoroutine(ActivationRoutine());

            //audioSource = mainCamera.Find.GetComponent<AudioSource>();

            //AudioSource.PlayClipAtPoint(beam, new Vector3(5, 1, 2));

        }

        public IEnumerator ActivationRoutine()
        {
            //Wait for 14 secs.
            yield return new WaitForSeconds(timer);

            if (objectToActivate != null)
            {
                objectToActivate.SetActive(true);
            }

            //Turn My game object that is set to false(off) to True(on).
            

		    //audioSource.PlayOneShot(beam, 1.0f);

            if (beam != null)
            {
                AudioSource.PlayClipAtPoint(beam, new Vector3(5, 1, 2));
            }
            
            //Turn the Game Oject back off after 1 sec.
           // yield return new WaitForSeconds(1);

            //Game object will turn off
            //objectToActivate.SetActive(false);
        }
    }
