using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner_Target : MonoBehaviour 

{

	public GameObject[] spawnObjectPrefab;

	public Vector3 centre;
	public Vector3 size;


	int randomGameObject;


	// Use this for initialization
	void Start () 

	{

		spawnObject ();

	}
	
	// Update is called once per frame
	void Update () 

	{

		if(Input.GetKey(KeyCode.Q))
				
				spawnObject ();	

	}

	public void spawnObject()

	{
		
		randomGameObject = Random.Range (0, 5);

		Vector3 pos = centre + new Vector3 (Random.Range (- size.x / 2, size.x / 2), Random.Range (- size.y / 2, size.y / 2), Random.Range (- size.z / 2, size.z / 2));

		Instantiate (spawnObjectPrefab[randomGameObject], transform.localPosition + pos, Quaternion.identity);

		//Destroy (spawnObjectPrefab, 2.0f);


	}

	void OnDrawGizmosSelected()

	{
		 
		Gizmos.color = new Color (1,0,0,0.5f);
		Gizmos.DrawCube (transform.localPosition + centre, size);
    }

}
