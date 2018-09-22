using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class GazeInput2 : MonoBehaviour
{


    public float timer;

    public GameObject objectToActivate;

    public GameObject objectToDestroy;

    // Use this for initialization
    void Start()
    {

        objectToActivate.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {



    }


    public void GazeEnter()

    {


        //Debug.Log("Enter2");



        StartCoroutine(ActivationRoutine());

        Destroy(objectToDestroy);

        Invoke("ChangeLevel", 4.0f);



    }


    public void GazeExit()

    {

        //Debug.Log("Exit2");

    }

    private IEnumerator ActivationRoutine()
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

    void ChangeLevel()
    {
        SceneManager.LoadScene("HappyDance_002");
    }

}