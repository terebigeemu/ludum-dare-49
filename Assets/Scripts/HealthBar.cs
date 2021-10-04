// store HP
// this script attaches to GameObject Player
// @author: Duck2033
// @author: aidswidjaja

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    public int max_health = 3;
    public int health = 3;

    public GameObject Heart1;
    public GameObject Heart2;
    public GameObject Heart3;

    private void OnCollisionEnter2D(Collision2D collision)
    {

    }

    void Update()
    {
        if (health < 1)
        {
            Heart1.SetActive(false);
            Heart2.SetActive(false);
            Heart3.SetActive(false);
        }
        else
        {
            Heart1.SetActive(true);
            Heart2.SetActive(true);
            Heart3.SetActive(true);
        }
        if (health < 2)
        {
            Heart2.SetActive(false);
            Heart3.SetActive(false);
        }
        else
        {
            Heart2.SetActive(true);
            Heart3.SetActive(true);
        }
        if (health < 2)
        {
            Heart3.SetActive(false);
        }
        else
        {
            Heart3.SetActive(true);
        }
    }

}
