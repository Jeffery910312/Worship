using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int currentRound = 0;
    public int currentScore = 0;

    public string currentAction = "a";
    public GameObject buttonCandle;
    public GameObject textCandle;
    public GameObject buttonBurn;
    public GameObject textBurn;
    public GameObject buttonWorship;
    public GameObject textWorship;
    public GameObject buttonIncense;
    public GameObject textIncense;
    public GameObject buttonPaper;
    public GameObject textPaper;
    public GameObject buttonToast;
    public GameObject textToast;
    public GameObject buttonPineapple;
    public GameObject textPineapple;
    public GameObject buttonTea;
    public GameObject textTea;
    public GameObject buttonPlainFruit;
    public GameObject textPlainFruit;

    StartEnd startEnd;
    private void Awake()
    {
        GameObject startEndManager = GameObject.Find("StartEndManager");
        startEnd = startEndManager.GetComponent<StartEnd>();

    }

    public void ChangeCurrentActionText(GameObject buttonText)
    {
        currentAction = buttonText.name;
    }

    // 各種動作按鈕
    public void OnButtonCandleClick()
    {
        ChangeCurrentActionText(textCandle);
        if (currentAction == startEnd.correctActions[currentRound])
        {
            currentScore += 10;
        }
        else
        {
            currentScore += 1;
        }
        buttonCandle.SetActive(false);
        currentRound += 1;
        if (currentRound >= startEnd.totalRounds)
        {
            startEnd.EndGame();
        }
    }

    public void OnButtonBurnClick()
    {
        ChangeCurrentActionText(textBurn);
        if (currentAction == startEnd.correctActions[currentRound])
        {
            currentScore += 10;
        }
        else
        {
            currentScore += 1;
        }
        buttonBurn.SetActive(false);
        currentRound += 1;
        if (currentRound >= startEnd.totalRounds)
        {
            startEnd.EndGame();
        }
    }

    public void OnButtonWorshipClick()
    {
        ChangeCurrentActionText(textWorship);
        if (currentAction == startEnd.correctActions[currentRound])
        {
            currentScore += 10;
        }
        else
        {
            currentScore += 1;
        }
        buttonWorship.SetActive(false);
        currentRound += 1;
        if (currentRound >= startEnd.totalRounds)
        {
            startEnd.EndGame();
        }
    }

    public void OnButtonIncenseClick()
    {
        ChangeCurrentActionText(textIncense);
        if (currentAction == startEnd.correctActions[currentRound])
        {
            currentScore += 10;
        }
        else
        {
            currentScore += 1;
        }
        buttonIncense.SetActive(false);
        currentRound += 1;
        if (currentRound >= startEnd.totalRounds)
        {
            startEnd.EndGame();
        }
    }

    public void OnButtonPaperClick()
    {
        ChangeCurrentActionText(textPaper);
        if (currentAction == startEnd.correctActions[currentRound])
        {
            currentScore += 10;
        }
        else
        {
            currentScore += 1;
        }
        buttonPaper.SetActive(false);
        currentRound += 1;
        if (currentRound >= startEnd.totalRounds)
        {
            startEnd.EndGame();
        }
    }

    public void OnButtonToastClick()
    {
        ChangeCurrentActionText(textToast);
        if (currentAction == startEnd.correctActions[currentRound])
        {
            currentScore += 10;
        }
        else
        {
            currentScore += 1;
        }
        buttonToast.SetActive(false);
        currentRound += 1;
        if (currentRound >= startEnd.totalRounds)
        {
            startEnd.EndGame();
        }
    }

    public void OnButtonPineappleClick()
    {
        ChangeCurrentActionText(textPineapple);
        if (currentAction == startEnd.correctActions[currentRound])
        {
            currentScore += 10;
        }
        else
        {
            currentScore += 1;
        }
        buttonPineapple.SetActive(false);
        currentRound += 1;
        if (currentRound >= startEnd.totalRounds)
        {
            startEnd.EndGame();
        }
    }

    public void OnButtonTeaClick()
    {
        ChangeCurrentActionText(textTea);
        if (currentAction == startEnd.correctActions[currentRound])
        {
            currentScore += 10;
        }
        else
        {
            currentScore += 1;
        }
        buttonTea.SetActive(false);
        currentRound += 1;
        if (currentRound >= startEnd.totalRounds)
        {
            startEnd.EndGame();
        }
    }

    public void OnButtonPlainFruitClick()
    {
        ChangeCurrentActionText(textPlainFruit);
        if (currentAction == startEnd.correctActions[currentRound])
        {
            currentScore += 10;
        }
        else
        {
            currentScore += 1;
        }
        buttonPlainFruit.SetActive(false);
        currentRound += 1;
        if (currentRound >= startEnd.totalRounds)
        {
            startEnd.EndGame();
        }
    }


    // 分數條
    // public float GetScoreRatio()
    // {
    //     return currentScore / startEnd.maxScore;
    // }





}