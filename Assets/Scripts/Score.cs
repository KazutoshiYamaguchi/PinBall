using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score: MonoBehaviour
{
    
    private int score = 0; 
    private GameObject ScoreText;


    void Start()
    {
        this.ScoreText = GameObject.Find("ScoreText");
        score = 0;
        SetScore();   
    }

    
    void OnCollisionEnter(Collision other)
    {
        string Tag = other.gameObject.tag;

        if (Tag == "SmallStarTag")
        {
            score += 10;
        }
        else if (Tag == "LargeStarTag") {
            score += 20;
        }
        else if(Tag == "SmallCloudTag")
        {
            score += 30;
        }
        else if(Tag=="LargeCloudTag")
        {
            score += 40;
        }


        SetScore();
    }

    void SetScore()
    {
        ScoreText.GetComponent<Text>().text = string.Format("Score:{0}", score);
    }
}