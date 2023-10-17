using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BallController : MonoBehaviour
{
    [SerializeField] TextMeshPro scoreText;

    [SerializeField] int easyReachObjPoint = 2;
    [SerializeField] int normalReachObjPoint = 4;
    [SerializeField] int hardReachObjPoint = 9;
    [SerializeField] int bigCirclePoint = 17;

    int increaseScoreAmount;
    int scoreAmount = 0;

    void Awake() 
    {
        scoreText.text = scoreAmount.ToString();    
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.CompareTag("Small")) { increaseScoreAmount = easyReachObjPoint; }
        else if(other.gameObject.CompareTag("Medium")) { increaseScoreAmount = normalReachObjPoint; }
        else if(other.gameObject.CompareTag("Big")) { increaseScoreAmount = hardReachObjPoint; }
        else if(other.gameObject.CompareTag("BigBall")) { increaseScoreAmount = bigCirclePoint; }

        scoreAmount += increaseScoreAmount;
        scoreText.text = scoreAmount.ToString();

        if(other.gameObject.CompareTag("Died"))
        {
            //GameOverPhase
            Destroy(gameObject);
        }
    }

}