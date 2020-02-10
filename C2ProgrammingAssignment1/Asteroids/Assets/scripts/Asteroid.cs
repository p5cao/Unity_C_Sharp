using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{

    public GameObject[] Sprites;
    //public GameObject[] RocksInCamera;
    [SerializeField]
    GameObject Sprite1;

    [SerializeField]
    GameObject Sprite2;

    [SerializeField]
    GameObject Sprite3;

    // Start is called before the first frame update
    void Start()
    {
        // randomly pick one of the three asteroid sprites\
        Sprites = new GameObject[3];
        Sprites[0] = Sprite1;
        Sprites[1] = Sprite2;
        Sprites[2] = Sprite3;

        GameObject Asteroid = Sprites[UnityEngine.Random.Range(0, 3)];

        // apply impulse force to get game object moving
        const float MinImpulseForce = 3f;
        const float MaxImpulseForce = 5f;
        float angle = Random.Range(0, 2 * Mathf.PI);
        Vector2 direction = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
        float mag = Random.Range(MinImpulseForce, MaxImpulseForce);
        Asteroid.GetComponent<Rigidbody2D>().AddForce(direction * mag, ForceMode2D.Impulse);
        
    }

    
}
