using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    /// <summary>
    /// Changes character on left mouse button
    /// </summary>

    // need for location of new character
    // Update is called once per frame
    void Update()
    {
        // Change character on left mouse button
        if(Input.GetMouseButtonDown(0))
        {
            // convert mouse position to world position
            Vector3 position = Input.mousePosition;
            position.z = -Camera.main.transform.position.z;
            position = Camera.main.ScreenToWorldPoint(position);


            // move peekaboo to mouse position
            gameObject.transform.position = position;
        }

    }
}
