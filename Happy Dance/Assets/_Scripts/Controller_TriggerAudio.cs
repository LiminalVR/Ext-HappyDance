using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Controller_TriggerAudio : MonoBehaviour



{   

	public GameObject Camera;

	public GameObject controller;

	//public float DelayAudio;

	public AudioClip[] audioArray;

	AudioSource audioSource;

	AudioClip currentAudio;

	int index;


	//private IEnumerator coroutine;



	void Start()

	{

		
		audioSource = Camera.transform.Find("EGO_ControllerTrigger").GetComponent<AudioSource> ();
	

		index = Random.Range (0, audioArray.Length);
		currentAudio = audioArray[index];
		print (currentAudio.name);

		//coroutine = PlayAudioWithDelay (3.0f);

	}


	void OnTriggerExit(Collider controller)

	{
		//StartCoroutine (PlayAudioWithDelay(1));
		audioSource.PlayOneShot(currentAudio);

	}
		

	//private IEnumerator PlayAudioWithDelay (float Delay)

	//{
		//if (currentAudio == null)
			//yield break;
		//yield return new WaitForSeconds(Delay);

		//audioSource.PlayOneShot(currentAudio);

	//}




}