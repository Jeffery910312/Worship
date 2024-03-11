using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartEnd : MonoBehaviour
{
    [SerializeField] GameObject startScreen;
    [SerializeField] GameObject endScreen;
    [SerializeField] GameObject gamingScreen;

    public int TuDiGongMaxScore = 50;
    public int TuDiGongTotalRound = 5;
    public string[] TuDiGongCorrectActions = { "Candle", "Burn", "Worship", "Incense", "Paper" };
    public int BaoShengMaxScore = 80;
    public int BaoShengTotalRound = 8;
    public string[] BaoShengCorrectActions = { "PlainFruit", "Candle", "Tea", "Toast", "Burn", "Worship", "Incense", "Paper" };

    public int maxScore = 0;
    public int totalRounds = 0;
    public string[] correctActions = { "a" };


    void Start()
    {
        startScreen.SetActive(true);
        endScreen.SetActive(false);
        gamingScreen.SetActive(false);

    }

    public void OnButtonTuDiGongClick()
    {
        StartGame();
        totalRounds = TuDiGongTotalRound;
        maxScore = TuDiGongMaxScore;
        correctActions = TuDiGongCorrectActions;
    }

    public void OnButtonBaoShengClick()
    {
        StartGame();
        totalRounds = BaoShengTotalRound;
        maxScore = BaoShengMaxScore;
        correctActions = BaoShengCorrectActions;
    }

    public void StartGame()
    {
        startScreen.SetActive(false);
        gamingScreen.SetActive(true);
    }

    public void EndGame()
    {
        endScreen.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
