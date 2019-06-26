using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Assertions;

/// <summary>
/// PraiseController measures how much the player is moving their controller around and then plays a random praise track when it exceeds a certain value.
/// PraiseController then waits a random amount of time before being able to play another praise track.
/// </summary>
public class PraiseController 
    : MonoBehaviour
{
    public Transform HandTransform;
    public float CommentActivationTrigger;
    [Space]
    public List<Praise> PlayerPraiseOptions;
    public List<SpeechBubble> SpeechBubbles;
    public float BasePraiseCooldown;
    public Vector2 CooldownRange;
    public bool Active;

    private Vector3 _cachedPos;
    void Start()
    {
        Assert.IsNotNull(HandTransform, "HandTransform must not be null!");
        _cachedPos = HandTransform.position;

        StartCoroutine(PraiseCoro());
    }

    private IEnumerator PraiseCoro()
    {
        while(Active)
        {
            var position = HandTransform.position;
            var handDelta = position - _cachedPos;

            _cachedPos = position;

            if (handDelta.magnitude > CommentActivationTrigger)
            {
                var praise = PlayerPraiseOptions[Random.Range(0, PlayerPraiseOptions.Count)];
                var praiseDisplay = SpeechBubbles[Random.Range(0, SpeechBubbles.Count)];

                praiseDisplay.DisplayGameObject.SetActive(true);
                praiseDisplay.SetSpeechBubble(praise);

                yield return new WaitForSeconds(praise.PraiseAudioClip.length + 1f);
                praiseDisplay.DisplayGameObject.SetActive(false);

                yield return new WaitForSeconds(BasePraiseCooldown + Random.Range(CooldownRange.x, CooldownRange.y));
            }

            yield return new WaitForEndOfFrame();
        }
    }
}
