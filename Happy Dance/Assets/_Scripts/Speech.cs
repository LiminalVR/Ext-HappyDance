using System;

using UnityEngine;

/// <summary>
/// Speech is used to store the audioclip that will be played and the string that will be displayed when the system wants to talk to the player
/// </summary>
[Serializable]
public class Speech
{
    public AudioClip SpeechAudioClip;
    [TextArea] public string SpeechText;
}
