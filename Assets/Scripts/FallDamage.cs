// enemy takes 1 HP
// https://docs.unity3d.com/ScriptReference/Collider.OnTriggerEnter.html
// https://docs.unity3d.com/ScriptReference/AudioSource.Play.html
// @author: aidswidjaja

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDamage : MonoBehaviour
{

    AudioSource damage_sfx;


    void OnTriggerEnter2D(Collider2D col)
    {


        GameObject go = GameObject.Find("Player");
        HealthBar hb = go.GetComponent<HealthBar>();

        hb.health = 0;
        hb.health_cooldown = true;


    }

}
