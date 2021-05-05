using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthController : MonoBehaviour
{
    public int enemyHealth;
    public int maxHealth;
   
   
    public void damagetoEnemy(int amount)
    {
        enemyHealth -= amount;

        if (enemyHealth <= 0)
        {
            Destroy(gameObject);
        }
            
            
        }
    }
  

