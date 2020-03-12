using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Liminal.SDK;
using Liminal.SDK.Core;
using Liminal.SDK.VR.Pointers;

public class DisablePointers : MonoBehaviour
{
    private void Awake()
    {
        ExperienceApp.Initializing += DisableAllPointers;
    }

    private void DisableAllPointers()
    {
        var pointers = GetComponentsInChildren<LaserPointerVisual>(true);
        
        foreach (var pointer in pointers)
        {
            pointer.gameObject.SetActive(false);
        }
    }
}
