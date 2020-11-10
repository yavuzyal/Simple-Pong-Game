using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    [Header("Ball")]
    public GameObject ball;

    [Header("Player1")]
    public GameObject player1paddle;
    public GameObject player1goal;

    [Header("Player2")]
    public GameObject player2paddle;
    public GameObject player2goal;


    [Header("ScoreUI")]
    public GameObject player1text;
    public GameObject player2text;
    public GameObject win1text;
    public GameObject win2text;

    private int Player1Score;
    private int Player2Score;

    void Start()
    {
        win1text.SetActive(false);
        win2text.SetActive(false);
    }

    public void Player1Scored()
    {
        Player1Score++;
        player1text.GetComponent<TextMeshProUGUI>().text = Player1Score.ToString();
        if (Player1Score >= 1)
        {
            win1text.SetActive(true);
            Invoke("FinishGame", 2);
        }
        else
            Invoke("ResetPosition", 1);
    }

    public void Player2Scored()
    {
        Player2Score++;
        player2text.GetComponent<TextMeshProUGUI>().text = Player2Score.ToString();
        if(Player2Score >= 1)
        {
            win2text.SetActive(true);
            Invoke("FinishGame", 2);
        }
        else
            Invoke("ResetPosition", 1);
    }

    private void ResetPosition()
    {
        ball.GetComponent<Ball>().Reset();
        player1paddle.GetComponent<Paddle>().Reset();
        player2paddle.GetComponent<Paddle>().Reset();
    }

    private void FinishGame()
    {
        SceneManager.LoadScene(0);
    }

}
