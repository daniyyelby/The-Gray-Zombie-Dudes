using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float lifetime = 5.0f;
    float timeLeft;
    ScoreController scoreController;
    // ScoreController scoreController;
    // Start is called before the first frame update
    void Start()
    {
        timeLeft = lifetime;
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.tag == "Ethan")
        {
            other.gameObject.SendMessage("damagetoEnemy", 1);
            Destroy(gameObject);
        }
        else if(other.gameObject.tag == "Water")
        {
            Destroy(gameObject);
        }
        else if (other.gameObject.tag == "Terrain")
        {
            Destroy(gameObject);
        }
        else if (other.gameObject.tag == "Cube")
        {
            Destroy(gameObject);
        }

    }
}
