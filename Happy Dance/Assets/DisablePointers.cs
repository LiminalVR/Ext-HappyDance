using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Liminal.SDK;
using Liminal.SDK.Core;
using Liminal.SDK.VR.Pointers;

public class DisablePointers : MonoBehaviour
{
    public List<LaserPointerVisual> Pointers;

    private void Awake()
    {
        ExperienceApp.Initializing += DisableAllPointers;
    }

    private void DisableAllPointers()
    {
        Pointers = GetComponentsInChildren<LaserPointerVisual>(true).ToList();
        
        foreach (var pointer in Pointers)
        {
            pointer.gameObject.SetActive(false);
        }
    }

    public void Update()
    {
        foreach (var pointer in Pointers.Where(pointer => pointer.gameObject.gameObject.activeSelf))
        {
            pointer.gameObject.SetActive(false);
        }
    }
}
