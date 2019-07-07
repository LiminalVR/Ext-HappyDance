using System.Collections;

using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.Playables;

using Liminal.Core.Fader;
using Liminal.SDK.Core;

/// <summary>
/// AppController is used to control the ending of the happy dance experience.
/// </summary>
public class AppController 
    : MonoBehaviour
{
    public float SecondsLeft;
    public float VolumeFadeSpeed;
    public DanceDetector PlayerDanceDetector;
    public PlayableDirector Director;

    void Start()
    {
        Assert.IsNotNull(PlayerDanceDetector, "PlayerDanceDetector must not be null");
        StartCoroutine(TimerCoro());
    }

    private IEnumerator TimerCoro()
    {
        while (SecondsLeft > 0)
        {
            SecondsLeft -= Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }

        PlayerDanceDetector.Active = false;

        yield return new WaitForSeconds(5f);
        Director.gameObject.SetActive(true);

        yield return new WaitForSeconds((float) Director.duration + 0.1f);

        ScreenFader.Instance.FadeToBlack(2);

        // Used because the fade to black speed is always 2 seconds and the audio fade time may not be
        var timeElapsed = 0f;
        while (AudioListener.volume > 0f)
        {
            AudioListener.volume -= Time.deltaTime * VolumeFadeSpeed;
            timeElapsed += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }

        yield return new WaitForSeconds(2f - timeElapsed);

        ExperienceApp.End(true);
    }
}
