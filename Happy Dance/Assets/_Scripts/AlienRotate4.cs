using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienRotate4 : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(5, 0, 0) * Time.deltaTime);
    }
}

