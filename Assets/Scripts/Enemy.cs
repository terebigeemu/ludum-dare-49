// enemy takes 1 HP
// and https://docs.unity3d.com/ScriptReference/AudioSource.Play.html
// @author: aidswidjaja

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    AudioSource damage_sfx;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        GameObject go = GameObject.Find("Player");
        HealthBar hb = go.GetComponent<HealthBar>();

        bool health_cooldown = hb.health_cooldown;

        damage_sfx = GetComponent<AudioSource>();

        if (!health_cooldown)
        {
            damage_sfx.Play(0);
            hb.health -= 1;
            hb.health_cooldown = true;
        }

    }

}
