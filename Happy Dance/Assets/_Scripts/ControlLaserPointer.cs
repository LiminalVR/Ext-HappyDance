using UnityEngine;

using Liminal.SDK.VR.Pointers;

/// <summary>
/// ControlLaserPointer controls whether the laser pointer visual is displayed for the player.
/// </summary>
public class ControlLaserPointer 
    : MonoBehaviour
{
    public bool Enabled;

    private void Start()
    {
        var pointer = GetComponentInChildren<LaserPointerVisual>(true);
        var lineRend = GetComponentInChildren<LineRenderer>(true);

        pointer.enabled = Enabled;
        lineRend.enabled = Enabled;
    }
}
