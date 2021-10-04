using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleJump : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject go = GameObject.Find("Player");
        Player pl = go.GetComponent<Player>();

        if (pl.first_jump_done)
        {
            pl.second_jump_done = true;
        }
    }
}
