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
            Debug.Log("Keypress detected... moving to next scene...");
        }
    }

    IEnumerator Transition()
    {
        crossfadeAnimControlClose.SetTrigger("start_close_animation");
        yield return new WaitForSeconds(0.75f);
        SceneManager.LoadScene("Level1");
    }
}