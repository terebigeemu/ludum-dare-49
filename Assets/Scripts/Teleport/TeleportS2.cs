// teleport to Skyscraper2
// frick iteration array zero-indexing things

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportS2 : MonoBehaviour
{

    public AudioSource BackgroundAudio;

    public Animator crossfadeAnimControlClose;

    void OnTriggerEnter2D(Collider2D col)
    {
        StartCoroutine(Transition());
    }
    IEnumerator Transition()
    {
        StartCoroutine(TitleAudioFader.FadeOut(BackgroundAudio, 2f));
        crossfadeAnimControlClose.SetTrigger("start_close_animation");
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Skyscraper2");
    }
}

