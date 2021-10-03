// cross-fade between scenes
// @author: aidswidjaja

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// https://medium.com/c-sharp-progarmming/make-smooth-scene-transitions-in-unity-c-6b7c97e4c7e0

public class SceneTransitionCloseHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Animator crossfadeAnimControlClose;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(Transition());
        }

        // REMOVE CHEAT CODES IN FINAL GAME //
        else if (Input.GetKeyDown("l") && Input.GetKeyDown("0"))
        {
            StartCoroutine(DebugTransition());
        }

        else if (Input.GetKeyDown("l") && Input.GetKeyDown("1"))
        {
            StartCoroutine(Level1());
        }

        else if (Input.GetKeyDown("l") && Input.GetKeyDown("2"))
        {
            StartCoroutine(Level2());
        }

        else if (Input.GetKeyDown("l") && Input.GetKeyDown("3"))
        {
            StartCoroutine(Level3());
        }

        else if (Input.GetKeyDown("l") && Input.GetKeyDown("4"))
        {
            StartCoroutine(Level3());
        }

        else if (Input.GetKeyDown("l") && Input.GetKeyDown("5"))
        {
            StartCoroutine(Level3());
        }
    }

    IEnumerator Transition()
    {
        crossfadeAnimControlClose.SetTrigger("start_close_animation");
        yield return new WaitForSeconds(0.75f);
        SceneManager.LoadScene("Level1");
    }

    IEnumerator DebugTransition()
    {
        crossfadeAnimControlClose.SetTrigger("start_close_animation");
        yield return new WaitForSeconds(0.75f);
        SceneManager.LoadScene("Level0");
    }

    IEnumerator Level1()
    {
        crossfadeAnimControlClose.SetTrigger("start_close_animation");
        yield return new WaitForSeconds(0.75f);
        SceneManager.LoadScene("Level1");
    }

    IEnumerator Level2()
    {
        crossfadeAnimControlClose.SetTrigger("start_close_animation");
        yield return new WaitForSeconds(0.75f);
        SceneManager.LoadScene("Level2");
    }

    IEnumerator Level3()
    {
        crossfadeAnimControlClose.SetTrigger("start_close_animation");
        yield return new WaitForSeconds(0.75f);
        SceneManager.LoadScene("Level3");
    }

    IEnumerator Level4()
    {
        crossfadeAnimControlClose.SetTrigger("start_close_animation");
        yield return new WaitForSeconds(0.75f);
        SceneManager.LoadScene("Level4");
    }

    IEnumerator Level5()
    {
        crossfadeAnimControlClose.SetTrigger("start_close_animation");
        yield return new WaitForSeconds(0.75f);
        SceneManager.LoadScene("Level5");
    }

}