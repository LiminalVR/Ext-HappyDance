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


	private bool canPlay = true;

	//private IEnumerator coroutine;



	void Start()

	{


		//audioSource = Camera.transform.Find("EGO_ControllerTrigger").GetComponent<AudioSource> ();


		index = Random.Range (0, audioArray.Length);
		currentAudio = audioArray[index];
		print (currentAudio.name);

		//coroutine = PlayAudioWithDelay (3.0f);

	}

	private void Update()
	{
		var forward = transform.TransformDirection(Vector3.forward);
		var toOther = Vector3.up;

		//gets the angle between the controller's forward vector and the upwards vector (0,1,0) and returns it as a value between -1 and 1.
		//-1 means you're pointing directly away from the target and 1 means you're pointing directly at it
		var dotProduct = Vector3.Dot(forward, toOther);

		//fires the sound and makes it so that canPlay=false preventing it from firing again
		if (dotProduct > 0.95f && canPlay)
		{
			canPlay = false;

			currentAudio = audioArray[Random.Range(0, audioArray.Length)];

			//audioSource.PlayOneShot(currentAudio);

			AudioSource.PlayClipAtPoint(currentAudio, new Vector3(5, 1, 2));


		}
		else if (dotProduct < 0.35f && canPlay == false)
		{
			canPlay = true;
		}
	}



	//void OnTriggerExit(Collider controller)

	//{
		//StartCoroutine (PlayAudioWithDelay(1));


	//}


	//private IEnumerator PlayAudioWithDelay (float Delay)

	//{
	//if (currentAudio == null)
	//yield break;
	//yield return new WaitForSeconds(Delay);

	//audioSource.PlayOneShot(currentAudio);

	//}




}