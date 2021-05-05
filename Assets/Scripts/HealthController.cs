using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    public int health;
    public int maxHealth;
    public Text livesLabel;
    public void damage(int amount)
    {
        health -= amount;

        if (health <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void increase(int amountValue)
    {

        if (health < maxHealth)
        {
            health += amountValue;
        }

        else if (health < maxHealth)
        {
            health = maxHealth;
        }
    }
    void Start()
    {
        livesLabel.text = "Health: " + health;

    }

    // Update is called once per frame
    void Update()
    {
        livesLabel.text = "Health: " + health;

    }

}
