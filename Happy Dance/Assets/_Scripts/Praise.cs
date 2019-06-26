using System;

using UnityEngine;

/// <summary>
/// Praise is used to store the audioclip that will be played and the string that will be displayed when players dance hard enough.
/// </summary>
[Serializable]
public class Praise
{
    public AudioClip PraiseAudioClip;
    [TextArea] public string PraiseText;
}
