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
    public float CommentActivationMovementThreshold;
    [Space]
    public List<Praise> PlayerPraiseOptions;
    public List<SpeechBubble> SpeechBubbles;
    public float BasePraiseCooldown;
    public Vector2 CooldownRange;
    public bool Active;

    private Vector3 _cachedPos;
    private Coroutine _praiseRoutine;

    void Start()
    {
        Assert.IsNotNull(HandTransform, "HandTransform must not be null!");
        _cachedPos = HandTransform.position;
    }

    private void Update()
    {
        if (!Active)
            return;

        var handDelta = HandTransform.position - _cachedPos;

        if (handDelta.magnitude > CommentActivationMovementThreshold && _praiseRoutine == null)
        {
            _praiseRoutine = StartCoroutine(PraiseCoro());
        }

        _cachedPos = HandTransform.position;
    }

    private IEnumerator PraiseCoro()
    {
        var praise = PlayerPraiseOptions[Random.Range(0, PlayerPraiseOptions.Count)];
        var praiseDisplay = SpeechBubbles[Random.Range(0, SpeechBubbles.Count)];

        praiseDisplay.DisplayGameObject.SetActive(true);
        praiseDisplay.SetSpeechBubble(praise);

        yield return new WaitForSeconds(praise.PraiseAudioClip.length + 1f);
        praiseDisplay.DisplayGameObject.SetActive(false);

        yield return new WaitForSeconds(BasePraiseCooldown + Random.Range(CooldownRange.x, CooldownRange.y));

        _praiseRoutine = null;

    }
}
