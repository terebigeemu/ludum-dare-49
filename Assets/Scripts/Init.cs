// this is the first code that the game will run on startup - to init everything
// @author: aidswidjaja

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Init : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public AudioSource TitleAudio;

    void Update()
    {
        // for scene transitions see SceneTransitionCloseHandler

        if (Input.GetKeyDown("space"))
        {
            StartCoroutine(TitleAudioFader.FadeOut(TitleAudio, 1f));
        }
    }

}
