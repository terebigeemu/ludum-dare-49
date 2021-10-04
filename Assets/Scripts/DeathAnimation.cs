// fade out when player switches scene (e.g death)
// @author: aidswidjaja

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Animator crossfadeAnimControlClose;

    // Update is called once per frame
    void Update()
    {
        GameObject go = GameObject.Find("Player");
        HealthBar hb = go.GetComponent<HealthBar>();

        if (hb.health == 0)
        {
            crossfadeAnimControlClose.SetTrigger("start_close_animation");
        }
    }
}
