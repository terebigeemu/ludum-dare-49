// kills title-screen background after 6 secs
// @author: Duck2033

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OriginalTitle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject,5f); 
    }
}
