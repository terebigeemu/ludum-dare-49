// cross-fade between scenes
// @author: aidswidjaja

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// https://medium.com/c-sharp-progarmming/make-smooth-scene-transitions-in-unity-c-6b7c97e4c7e0

public class SceneTransitionHandler : MonoBehaviour
{
    public Animator crossfadeAnimControl;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(LoadNextScene());
            Debug.Log("Keypress detected... moving to next scene...");
        }
    }

    IEnumerator LoadNextScene()
    {
        //crossfadeAnimControl.SetTrigger("start_animation");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Level1");
    }
}
