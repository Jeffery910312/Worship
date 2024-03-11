using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] Image ScoreImage;
    StartEnd startEnd;
    Score score;

    public float transitionTime = 0.5f; // 變化的時間長度
    private float targetFillAmount;
    private float initialFillAmount;

    private void Start()
    {
        GameObject startEndManager = GameObject.Find("StartEndManager");
        startEnd = startEndManager.GetComponent<StartEnd>();

        GameObject player = GameObject.Find("Player");
        score = player.GetComponent<Score>();

        initialFillAmount = ScoreImage.fillAmount;

    }

    void Update()
    {
        // float fillScoreRatio = (float)score.currentScore / startEnd.maxScore;
        // Debug.Log("fillScoreRatio 的值为：" + score.currentScore + "除以" + startEnd.maxScore + "等於" + fillScoreRatio);
        // float targetFillAmount = Mathf.Lerp(0f, fillScoreRatio, 1);
        // ScoreImage.fillAmount = targetFillAmount;

        float fillScoreRatio = (float)score.currentScore / startEnd.maxScore;
        targetFillAmount = fillScoreRatio;

        // 停止之前的協程
        StopCoroutine("SmoothFill");

        // 開始新的協程
        StartCoroutine("SmoothFill");
    }

    private IEnumerator SmoothFill()
    {
        float elapsedTime = 0f;
        float currentFillAmount = ScoreImage.fillAmount;

        while (elapsedTime < transitionTime)
        {
            elapsedTime += Time.fixedDeltaTime;
            float t = Mathf.Clamp01(elapsedTime / transitionTime);
            ScoreImage.fillAmount = Mathf.Lerp(currentFillAmount, targetFillAmount, t);
            yield return null;
        }

        ScoreImage.fillAmount = targetFillAmount;
    }
}
