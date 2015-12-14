using UnityEngine;

/// <summary>
/// Simply moves the current game object
/// </summary>
public class ProjectileLine : MonoBehaviour
{
    public Vector2 DirectionTirRight = new Vector2(10, -5);
    public bool directionShootIsRight = true;


    void Start()
    {
        if (!directionShootIsRight)
        {
            DirectionTirRight.x = 0 - DirectionTirRight.x;
        }
        GetComponent<Rigidbody2D>().AddForce(DirectionTirRight, ForceMode2D.Impulse);
    }
}

