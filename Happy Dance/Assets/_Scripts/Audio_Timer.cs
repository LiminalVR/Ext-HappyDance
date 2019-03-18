using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_Timer : MonoBehaviour 

{

	public AudioClip[] vocalAudio;
	AudioSource voices;

	//Every 0.5 seconds(Change this to your needs)
	const float coolDownTime = 0.5f;
	float startingTime = 0f;

	void Start()
	{
		voices = GetComponent<AudioSource>();
		startingTime = Time.time;

		//We have. Now reset timer
		startingTime = Time.time;

		playAudio();

	}

	//void Update()
	//{
		
		//if (Input.GetKey(KeyCode.Space))
		//{
			//Check if we have reached the cool down timer
			//if (Time.time > startingTime + coolDownTime)
			//{
				//We have. Now reset timer
				//startingTime = Time.time;

				//playAudio();
			//}
		//}
	//}

	void playAudio()
	{
		voices.PlayOneShot(vocalAudio[UnityEngine.Random.Range(0, vocalAudio.Length)]);
		UnityEngine.Debug.Log("Shot");
	}

}
