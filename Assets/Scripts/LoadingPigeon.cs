using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingPigeon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // LoadingPigeon

        float speed = 5.0f;

        transform.Translate(Vector2.right * speed * Time.deltaTime);
        Destroy(gameObject, 5f);
    }
}
