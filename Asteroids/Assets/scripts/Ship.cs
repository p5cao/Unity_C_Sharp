using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// This is the Ship script to drive the ship around and make the ship wrap
/// </summary>
public class Ship : MonoBehaviour
{
    // Define the fields
    private Rigidbody2D shipRigidbody2D;
    private CircleCollider2D shipCircleCollider2D;
    float colliderRadius;
    Vector2 thrustDirection;
    const float ThrustForce = 5.0f;
    const float RotateDegreesPerSecond = 8.0f;
    // cached for efficient boundary checking
    static float screenLeft;
    static float screenRight;
    static float screenTop;
    static float screenBottom;

    // first frame input support flag
    bool previousFrameThrustInput = false;
    /// <summary>
	/// Gets the left edge of the screen in world coordinates
	/// </summary>
	/// <value>left edge of the screen</value>
	public static float ScreenLeft
    {
        get { return screenLeft; }
    }

    /// <summary>
    /// Gets the right edge of the screen in world coordinates
    /// </summary>
    /// <value>right edge of the screen</value>
    public static float ScreenRight
    {
        get { return screenRight; }
    }

    /// <summary>
    /// Gets the top edge of the screen in world coordinates
    /// </summary>
    /// <value>top edge of the screen</value>
    public static float ScreenTop
    {
        get { return screenTop; }
    }

    /// <summary>
    /// Gets the bottom edge of the screen in world coordinates
    /// </summary>
    /// <value>bottom edge of the screen</value>
    public static float ScreenBottom
    {
        get { return screenBottom; }
    }

    // Start is called before the first frame update
    void Start()
    {
        // Get the ship's Rigidbody 2D components
        shipRigidbody2D = GetComponent<Rigidbody2D>();
        // Get the ship's Circle Collider 2D components
        shipCircleCollider2D = GetComponent<CircleCollider2D>();
        colliderRadius = shipCircleCollider2D.radius;
        // initialize the thrustDirecrtion vector
        thrustDirection = new Vector2(1.0f, 0.0f);
    }

    // update is called every frame
    void Update()
    {
        if(Input.GetAxis("Rotate") != 0)
        {
            // calculate rotation amount and apply rotation 
            float rotationInput = Input.GetAxis("Rotate");
            float rotationAmount = RotateDegreesPerSecond * Time.deltaTime;
            if (rotationInput < 0)
            {
                rotationAmount *= -1;
            }
            transform.Rotate(Vector3.forward, rotationAmount);
            // Change the thrust direction according to rotation angles
            float rotationAngle = transform.eulerAngles.z;
            float angleInRad = Mathf.Deg2Rad * rotationAngle;
            thrustDirection = new Vector2(Mathf.Cos(angleInRad), Mathf.Sin(angleInRad));
        }
    }

    // Use FixedUpdate to apply the thrust to the ship
    private void FixedUpdate()
    {
        if (Input.GetAxis("Thrust") > 0)
        {
            if(!previousFrameThrustInput)
            {
                shipRigidbody2D.AddForce(ThrustForce * thrustDirection);
            }
        }
        else
        {
            previousFrameThrustInput = false;
        }
    }
    private void OnBecameInvisible()
    {
        // flip the sign of x component when exceeding the left/right screen limit
        if ((transform.position.x - colliderRadius >= ScreenRight) || (transform.position.x + colliderRadius <= ScreenLeft))
        {
            Vector2 localVec = transform.position;
            localVec.x = -localVec.x;
            transform.position = localVec;
        }
        // flip the sign of y component when exceeding the top/bottom screen limit
        if ((transform.position.y - colliderRadius >= ScreenTop) || (transform.position.y + colliderRadius <= ScreenBottom))
        {
            Vector2 localVec = transform.position;
            localVec.y = -localVec.y;
            transform.position = localVec;
        }
    }

}
