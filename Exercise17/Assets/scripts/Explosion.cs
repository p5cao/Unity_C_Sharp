using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// An explosion
/// </summary>
public class Explosion : MonoBehaviour
{
    // cached for efficiency
    Animator anim;

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start()
    {
        anim = GetComponent<Animator>();
    }
        
    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {
        // destroy the game object if the explosion has finished its animation
        
        //When entering the Jump state in the Animator, output the message in the console
        if (anim.GetCurrentAnimatorStateInfo(0).normalizedTime >= 2)
        {
            Destroy(gameObject);
            Debug.Log(anim.GetCurrentAnimatorStateInfo(0).normalizedTime);
        }
    }
}
