using System.Collections;

using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.Playables;

using Liminal.Core.Fader;
using Liminal.SDK.Core;

/// <summary>
/// GameTimer is sued to control the ending of the happy dance experience.
/// </summary>
public class GameTimer 
    : MonoBehaviour
{
    public float SecondsLeft;
    public DanceDetector PlayerDanceDetector;
    public PlayableDirector Director;

    void Start()
    {
        Assert.IsNotNull(PlayerDanceDetector, "PlayerDanceDetector must not be null");
		StartCoroutine(TimerCoro());
	}

	IEnumerator TimerCoro()
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
        yield return new WaitForSeconds(2f);

        ExperienceApp.End(true);
	}

	void OnGUI()
	{
        GUI.Label(new Rect(0, 0, 100, 20), SecondsLeft.ToString("0"));
	}
}
