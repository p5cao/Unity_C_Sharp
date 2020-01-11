using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Processes mouse button inputs
/// </summary>
public class MouseButtonProcessor : MonoBehaviour
{
    [SerializeField]
    GameObject prefabExplosion;
    [SerializeField]
    GameObject prefabTeddyBear;

    // first frame input support
    bool spawnInputOnPreviousFrame = false;
	bool explodeInputOnPreviousFrame = false;

    GameObject teddyBear;
    GameObject teddyBearExplode;
	/// <summary>
	/// Update is called once per frame
	/// </summary>
	void Update()
	{
        // spawn teddy bear as appropriate
        // Use left click in input manager to spawn a teddy bear
        if (Input.GetAxis("SpawnTeddyBear") > 0)
        {
            if (!spawnInputOnPreviousFrame)
            {
                spawnInputOnPreviousFrame = true;
                // record mouse position when left-clicking
                Vector3 position = Input.mousePosition;
                position.z = -Camera.main.transform.position.z;
                position = Camera.main.ScreenToWorldPoint(position);
                // instantiate the teddy bear prefab at the mouse location
                teddyBear = Instantiate(prefabTeddyBear, position, Quaternion.identity);

            }
        }
        else
        {
            // no SpawnTeddyBear input
            spawnInputOnPreviousFrame = false;
        }

        // explode teddy bear as appropriate
        // Use right click in input manager to explode a teddy bear
        // Check the value of TeddyBear tags not to be null
        if ((GameObject.FindWithTag("TeddyBear")!= null) && (Input.GetAxis("ExplodeTeddyBear") > 0))
        {
            if (!explodeInputOnPreviousFrame)
            {
                explodeInputOnPreviousFrame = true;
                // select a teddy bear via tag
                if (teddyBearExplode == null)
                {
                    teddyBearExplode = GameObject.FindWithTag("TeddyBear");
                }
                Vector3 position = teddyBearExplode.transform.position;
                // destroy the teddy bear and animate the explosion
                Destroy(teddyBearExplode);
                Instantiate(prefabExplosion, position, Quaternion.identity);
            }
        }
        else
        {
            // no exploeTeddyBear input
            explodeInputOnPreviousFrame = false;
        }
    }
}
