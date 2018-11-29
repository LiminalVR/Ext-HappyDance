using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemyWithBalloon : MonoBehaviour 

{

	public AudioClip sound;
	AudioSource audiosource;

	public int timeDelay = 2;

	public bool alreadyPlayed = false;


	// Use this for initialization
	void Start () 

	{

		audiosource = GetComponent<AudioSource> ();

	}
	
	// Update is called once per frame
	void Update () 

	{

		alreadyPlayed = false;

	}



	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Destroy") 
		
		{
			

			StartCoroutine (playAudiowithDelay ());

			Destroy (other.gameObject, 1.0f);

		}

	}

	IEnumerator playAudiowithDelay ()

	{
	
		if(!alreadyPlayed)
		
		{

			yield return new WaitForSeconds(timeDelay);

			audiosource.PlayOneShot (sound, 0.1f);

			alreadyPlayed = true;


			
	    }


    }


}

