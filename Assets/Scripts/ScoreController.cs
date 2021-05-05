using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{

    public int score;
    public Text scoreLabel;
    public void increaseScore(int amount)
    {
        score += amount;

    }


    void Start()
    {
        
        scoreLabel.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        scoreLabel.text = "Score: " + score;
        if (score == 100)
        {
                SceneManager.LoadScene(4);
            
        }

    }

}
