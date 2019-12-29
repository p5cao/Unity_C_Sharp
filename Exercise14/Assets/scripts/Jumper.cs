using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper: MonoBehaviour
{
    /// <summary>
    /// Lets make peekaboo jump!
    /// </summary>
    // jump location support
    float minX = -10;
    float maxX =  10;
    float minY = -3;
    float maxY = 3;

    // timer support
    float TotalJumpDelaySeconds = (float)0.1;
    float elapsedJumpDelaySeconds = 0;
    // Update is called once per frame
    void Update()
    {
        //  update  timer  and  check  if  it′s  done 
        elapsedJumpDelaySeconds += Time.deltaTime;
        if (elapsedJumpDelaySeconds >= TotalJumpDelaySeconds) 
        {
            elapsedJumpDelaySeconds = 0;
            float newX = Random.Range(minX, maxX);
            float newY = Random.Range(minY, maxY);
            transform.position = new Vector3(newX, newY);
            Debug.Log(transform.position);
        }
    }
}
