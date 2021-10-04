// enemy takes 1 HP
// ty https://answers.unity.com/questions/650983/how-to-get-variable-from-another-object.html
// @author: aidswidjaja

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    private bool health_cooldown = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject go = GameObject.Find("Player");
        HealthBar cs = go.GetComponent<HealthBar>();
        int health = cs.health;
        
    }

    IEnumerator ReduceHealth()
    {

    }
}
