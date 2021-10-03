// camera script
// @author: aidswidjaja

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = new Vector3(0, 0, -3);
    }


}
