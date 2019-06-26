using System.Collections;

using UnityEngine;

using Liminal.Core.Fader;
using Liminal.SDK.Core;

public class GameTimer 
    : MonoBehaviour
{
    public float SecondsLeft = 0;

    void Start()
	{
		StartCoroutine(TimerCoro());
	}

	IEnumerator TimerCoro()
	{
        while (SecondsLeft > 0)
        {
            SecondsLeft -= Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }

        ScreenFader.Instance.FadeToBlack(2);
        yield return new WaitForSeconds(2f);

        ExperienceApp.End(true);
	}

	void OnGUI()
	{
        GUI.Label(new Rect(0, 0, 100, 20), SecondsLeft.ToString("0"));
	}
}
