using UnityEngine;
using System.Collections;

/// <summary>
/// Simply moves the current game object
/// </summary>
public class MoveScript : MonoBehaviour
{
    // 1 - Designer variables

    /// <summary>
    /// Object speed
    /// </summary>
    public Vector2 speed = new Vector2(10, 10);

    /// <summary>
    /// Moving direction
    /// </summary>
    public Vector2 direction = new Vector2(-1, 0);

    private Vector2 movement;

    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(speed, ForceMode2D.Impulse);
    }

    void Update()
    {
       
    }
    
    void FixedUpdate()
    {
        // Apply movement to the rigidbody
        //GetComponent<Rigidbody2D>().velocity = movement;
    }
}
