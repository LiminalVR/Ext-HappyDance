﻿using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Assertions;

/// <summary>
/// DanceDetector measures how much the player is moving their controller around and then plays a random praise track when it exceeds a certain value.
/// DanceDetector then waits a random amount of time before being able to play another praise track.
/// </summary>
public class DanceDetector 
    : MonoBehaviour
{
    public Transform HandTransform;
    public float CommentActivationMovementThreshold;
    public float TimeBeforeEncouragement;
    [Space]
    public List<Speech> PlayerPraiseOptions;
    public List<Speech> PlayerEncouragementOptions;
    public List<SpeechBubble> SpeechBubbles;
    [Space]
    public float BaseTalkCooldown;
    public Vector2 CooldownRange;
    public bool Active;

    private Vector3 _cachedPos;
    private Coroutine _talkRoutine;
    private float _timeSinceGrossMovement;
    private Speech _lastSpeechItem;

    void Start()
    {
        Assert.IsNotNull(HandTransform, "HandTransform must not be null!");
        _cachedPos = HandTransform.position;
        Active = true;
    }

    private void Update()
    {
        if (!Active)
            return;

        var handDelta = HandTransform.position - _cachedPos;

        if (_talkRoutine == null)
        {
            _timeSinceGrossMovement += Time.deltaTime;

            if (handDelta.magnitude > CommentActivationMovementThreshold)
            {
                _talkRoutine = StartCoroutine(TalkRoutine(PlayerPraiseOptions));
                _timeSinceGrossMovement = 0;
            }

            if (_timeSinceGrossMovement > TimeBeforeEncouragement)
            {
                _talkRoutine = StartCoroutine(TalkRoutine(PlayerEncouragementOptions));
                    _timeSinceGrossMovement = 0;
            }
        }

        _cachedPos = HandTransform.position;
    }

    private IEnumerator TalkRoutine(List<Speech> talkList)
    {
        var speechIndex = Random.Range(0, talkList.Count);
        var loopCount = 0;

        do
        {
            speechIndex = Random.Range(0, talkList.Count);
            loopCount++;

            if (loopCount > 100)
                break;

        } while (talkList[speechIndex] == _lastSpeechItem);

        var speechItem = talkList[speechIndex];
        _lastSpeechItem = speechItem;

        var praiseDisplay = SpeechBubbles[Random.Range(0, SpeechBubbles.Count)];

        praiseDisplay.DisplayGameObject.SetActive(true);
        praiseDisplay.SetSpeechBubble(speechItem);

        yield return new WaitForSeconds(speechItem.SpeechAudioClip.length + 0.1f);
        praiseDisplay.DisplayGameObject.SetActive(false);

        yield return new WaitForSeconds(BaseTalkCooldown + Random.Range(CooldownRange.x, CooldownRange.y));

        _talkRoutine = null;

    }
}