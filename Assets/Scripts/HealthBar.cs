// store HP
// this script attaches to GameObject Player
// @author: Duck2033
// @author: aidswidjaja

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthBar : MonoBehaviour
{

    public int max_health = 3;
    public int health = 3;
    public bool health_cooldown = false;

    public GameObject Heart1;
    public GameObject Heart2;
    public GameObject Heart3;

    public Animator crossfadeAnimControlClose;

    private void OnCollisionEnter2D(Collision2D collision)
    {

    }

    void Update()
    {

        if (health == 0)
        {
            Heart1.SetActive(false);
            Heart2.SetActive(false);
            Heart3.SetActive(false);
        }
        else if (health == 1)
        {
            Heart1.SetActive(true);
            Heart2.SetActive(false);
            Heart3.SetActive(false);
        } else if (health == 2)
        {
            Heart1.SetActive(true);
            Heart2.SetActive(true);
            Heart3.SetActive(false);
        } else if (health == 3)
        {
            Heart1.SetActive(true);
            Heart2.SetActive(true);
            Heart3.SetActive(true);
        }

        if (health_cooldown)
        {
            StartCoroutine(HealthCooldownReset());
        }

        if (health == 0)
        {
            StartCoroutine(Death());
        }

    }

    IEnumerator HealthCooldownReset()
    {
        yield return new WaitForSeconds(3f);
        health_cooldown = false;
    }

    public AudioSource BackgroundAudio;

    IEnumerator Death()
    {
        StartCoroutine(TitleAudioFader.FadeOut(BackgroundAudio, 2f));
        yield return new WaitForSeconds(2f);
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }

}
