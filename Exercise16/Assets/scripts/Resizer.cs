using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resizer : MonoBehaviour
{
    /// <summary>
    /// The Resizer class (script) will shrink and grow the game object over time.
    /// </summary>
    /// 
    // timer support constants
    float TotalResizeSeconds = (float)0.1;
    float elapsedResizeSeconds = 0;

    // resizing control constants
    float ScaleFactorPerSecond = 1;
    // Setting this constant to 1 will make the game object double in size in the first second, 
    // triple in size over the first 2 seconds, and so on. 
    int scaleFactorSignMultiplier = 1;
    // This variable to determine either grow (when it's 1) and shrink (when it's -1)

    // Update is called once per frame
    void Update()
    {
        elapsedResizeSeconds += Time.deltaTime;
        if (elapsedResizeSeconds >= TotalResizeSeconds)
        {
            Vector3 newScale = transform.localScale;
            if (scaleFactorSignMultiplier == 1)
            {
                newScale.x *= 1 + ScaleFactorPerSecond;
                newScale.y *= 1 + ScaleFactorPerSecond;
            }
            else if(scaleFactorSignMultiplier == -1)
            {
                newScale.x *= 1 / (1 + ScaleFactorPerSecond);
                newScale.y *= 1 / (1 + ScaleFactorPerSecond);
            }
            transform.localScale = newScale;
            scaleFactorSignMultiplier *= -1;
            elapsedResizeSeconds = 0;
        }
    }
}
