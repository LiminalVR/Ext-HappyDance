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
    private static readonly int _tint = Shader.PropertyToID("_Tint");

    private void OnValidate()
    {
        Assert.IsNotNull(FaderMaterial, "FaderMaterial must not be null.");
        Assert.IsTrue(FaderMaterial.HasProperty(_tint), "The Fader Material must have a _Tint property");
    }

    private void Update()
    {
        FaderMaterial.SetColor(_tint, Color);
    }
}
