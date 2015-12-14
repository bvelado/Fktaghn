using UnityEngine;
using System.Collections;

public class ProjectileParabolic : MonoBehaviour {

    public Vector2 DirectionTirRight = new Vector2(3, 3);
    public bool directionShootIsRight = true;


	// Use this for initialization
    void Start()
    {
        if (!directionShootIsRight)
        {
            DirectionTirRight.x = 0 - DirectionTirRight.x;
        }
        GetComponent<Rigidbody2D>().AddForce(DirectionTirRight, ForceMode2D.Impulse);
    }

}
