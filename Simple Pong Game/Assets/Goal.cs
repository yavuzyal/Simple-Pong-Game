using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool isPlayer1Goal;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!isPlayer1Goal)
        {
            Debug.Log("Player 1 Scored");
            GameObject.Find("GameManager").GetComponent<GameManager1>().Player1Scored();
        }
        else
        {
            Debug.Log("Player 2 Scored");
            GameObject.Find("GameManager").GetComponent<GameManager1>().Player2Scored();
        }
    }  
}
