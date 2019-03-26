using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleActivate_Deactivate : MonoBehaviour
	{

		public float timer;

		public GameObject objectToActivate;

		private void Start()
		{

			objectToActivate.SetActive(false);
			StartCoroutine(ActivationRoutine());
		}

		private IEnumerator ActivationRoutine()
		{
			//Wait for 14 secs.
			yield return new WaitForSeconds(timer);

			//Turn My game object that is set to false(off) to True(on).
			objectToActivate.SetActive(true);

			//Turn the Game Oject back off after 1 sec.
			yield return new WaitForSeconds(2.0f);

			//Game object will turn off
			objectToActivate.SetActive(false);
		}
	}
