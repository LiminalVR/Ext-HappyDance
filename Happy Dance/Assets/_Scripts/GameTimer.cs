using System.Collections;

using UnityEngine;

using Liminal.Core.Fader;
using Liminal.SDK.Core;

public class GameTimer 
    : MonoBehaviour
{
    public float SecondsLeft = 0;
    bool loadingStarted = false;

    void Start()
	{
		StartCoroutine(DelayLoadLevel(320));
	}

	IEnumerator DelayLoadLevel(float seconds)
	{
		SecondsLeft = seconds;
		loadingStarted = true;
		do
		{
			yield return new WaitForSeconds(1);
		} while (--SecondsLeft > 0);

        ScreenFader.Instance.FadeToBlack(2);
        yield return new WaitForSeconds(2f);

        ExperienceApp.End(true);
	}

	void OnGUI()
	{
		if (loadingStarted)
			GUI.Label(new Rect(0, 0, 100, 20), SecondsLeft.ToString());
	}
}
