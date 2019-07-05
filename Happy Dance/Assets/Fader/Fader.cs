using UnityEngine;
using UnityEngine.Assertions;

/// <summary>
/// Fader is used to controller the color of a target material. It is driven by an animation clip.
/// </summary>
public class Fader 
    : MonoBehaviour
{
    public Color Color;
    public Material FaderMaterial;

    private void OnValidate()
    {
        Assert.IsNotNull(FaderMaterial, "FaderMaterial must not be null.");
    }

    private void Update()
    {
        FaderMaterial.SetColor("_Tint", Color);
    }
}
