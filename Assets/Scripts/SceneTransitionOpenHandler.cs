// open scene animation
// @author: aidswidjaja

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneTransitionOpenHandler : MonoBehaviour
{
    public Animator crossfadeAnimControlOpen;

    public bool loadingSceneOpen = true;

    void Awake()
    {
        StartCoroutine(Transition());
    }

    IEnumerator Transition()
    {
        crossfadeAnimControlOpen.SetTrigger("start_open_animation");
        yield return new WaitForSeconds(2f);
        loadingSceneOpen = false;
    }
}
