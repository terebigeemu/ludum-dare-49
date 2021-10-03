using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 15;
    public float jump_height = 100;
    public bool is_grounded = true;
    public bool first_jump_done = false;
    public bool second_jump_done = false;
    public bool jump_cooldown = true;

    void Update()
    {
        float xinput = Input.GetAxis("Horizontal");

        Vector2 movement = new Vector2(speed * xinput, 0);

        movement *= Time.deltaTime;

        if ((Input.GetKeyDown("w") || Input.GetKeyDown("up")) && is_grounded && !first_jump_done)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jump_height), ForceMode2D.Impulse);
            first_jump_done = true;
            print("first jump");

        } else if ((Input.GetKeyDown("w") || Input.GetKeyDown("up")) && first_jump_done & !second_jump_done)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jump_height), ForceMode2D.Impulse);
            second_jump_done = true;
            print("second jump");
        }

        transform.Translate(movement);
    }

    void OnCollisionEnter2D()
    {
        first_jump_done = false;
        second_jump_done = false;
    }


}
