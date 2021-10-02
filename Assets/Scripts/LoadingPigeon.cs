using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingPigeon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //public bool movement == true;

        //sle

    }

    // Update is called once per frame
    void Update()
    {
        // LoadingPigeon

        //while (movement == true) {
            float speed = 8.0f;

            transform.Translate(Vector2.right * speed * Time.deltaTime);
        //}

    }
}
