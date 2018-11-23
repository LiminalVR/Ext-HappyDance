using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemyWithBalloon : MonoBehaviour 

{

	public AudioClip sound;
	AudioSource audiosource;


	// Use this for initialization
	void Start () 

	{

		audiosource = GetComponent<AudioSource> ();

	}
	
	// Update is called once per frame
	void Update () 

	{



	}



	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Destroy") 
		
		{

			audiosource.PlayOneShot (sound, 0.1f);

			Destroy (other.gameObject, 3.0f);
		}

	}
}

