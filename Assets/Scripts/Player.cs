// probably some of the worst physics code ever written
// i hate the unity physics engine


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 15;
    public float jump_height = 8;
    public float gravity = 1;
    public bool is_grounded = true;
    public bool first_jump_done = false;
    public bool second_jump_done = false;
    public bool jump_cooldown = true;
    public bool is_facing_left = false;


    public HealthBar healthBar;

    void Start()
    {
        
    }

    void Update()
    {



        //Movement
        float xinput = Input.GetAxis("Horizontal");
        Vector2 dx = new Vector2(speed * xinput, 0);
        dx *= Time.deltaTime;
        transform.Translate(dx);

        if ((Input.GetKeyDown("w") || Input.GetKeyDown("up")) && is_grounded && !first_jump_done)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jump_height), ForceMode2D.Impulse);
            first_jump_done = true;
            print("first jump");

        }
        else if ((Input.GetKeyDown("w") || Input.GetKeyDown("up")) && first_jump_done & !second_jump_done)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jump_height), ForceMode2D.Impulse);
            second_jump_done = true;
            print("second jump");
        }

<<<<<<< HEAD
        transform.Translate(movement);


=======
        if ((Input.GetKeyDown("a")) || Input.GetKeyDown("left"))
        {
            is_facing_left = true;
        }

        if ((Input.GetKeyDown("d")) || Input.GetKeyDown("right"))
        {
            is_facing_left = false;
        }

        if (is_facing_left)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        } else
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
>>>>>>> 845623230e99d0ce17bbb8f0c6bb82a25473739c

    }

    void OnCollisionEnter2D()
    {
        first_jump_done = false;
        second_jump_done = false;
    }

}
