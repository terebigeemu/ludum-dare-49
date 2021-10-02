// open animation
// @author: aidswidjaja

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneTransitionOpenHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Animator crossfadeAnimControlOpen;

    // Update is called once per frame
    void Update()
    {
        crossfadeAnimControlOpen.SetTrigger("start_open_animation");
    }
}
