// background parallax
// woo I didn't look at stack overflow for this one!
// @author: aidswidjaja

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
 * Vector3 takes the form Vector3(x, y, z)
 * where x, y, and z are floats
 * 
 */

public class Background : MonoBehaviour
{

    // public constants of proportionality

    public float kdx = 2;
    public float kdy = 8;

    // original position before delta

    public float ox = 0;
    public float oy = 0;

	void Update()
    {
        // Find Player's position on the plane
        float playerPositionX = GameObject.Find("Player").transform.position.x;
        float playerPositionY = GameObject.Find("Player").transform.position.y;

        // Reduce to a tiny tiny tiny float

        float deltaBackgroundX = playerPositionX / kdx;
        float deltaBackgroundY = playerPositionY / kdy;

        Vector3 deltaBackgroundPosition = new Vector3(deltaBackgroundX, deltaBackgroundY, 0);

        transform.localPosition = new Vector3(ox, oy, 1);
        // as Player x/y-axis approaches infinity
        //    BG     x/y-axis approaches negative infinity

        transform.localPosition -= deltaBackgroundPosition; // negative for invert
    }
}
