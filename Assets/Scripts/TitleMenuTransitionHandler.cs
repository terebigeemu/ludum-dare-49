// title menu animation
// @author: aidswidjaja

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleMenuTransitionHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Animator titleMenuAnimControl;

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(5.25f);
        titleMenuAnimControl.SetTrigger("start_fade_animation");
    }
}