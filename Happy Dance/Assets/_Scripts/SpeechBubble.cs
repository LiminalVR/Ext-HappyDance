using System;

using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// SpeechBubble is used to store the text component and audiosource of text display object. It also contains a reference to the object itself so <see cref="PraiseController"/> can activate the object.
/// It also contains a method to set the display text and play the praise's audioclip.
/// </summary>
[Serializable]
public class SpeechBubble 
{
    public GameObject DisplayGameObject;
    public Text DisplayText;
    public AudioSource PraiseSource;

    public void SetSpeechBubble(Praise praiseToDisplay)
    {
        DisplayText.text = praiseToDisplay.PraiseText;
        PraiseSource.clip = praiseToDisplay.PraiseAudioClip;
        PraiseSource.Play();
    }
}
