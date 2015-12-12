using UnityEngine;
using System.Collections;

public class ProjectileParabolic : MonoBehaviour {

    public Vector2 speed = new Vector2(10, 10);

	// Use this for initialization
    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(speed, ForceMode2D.Impulse);
    }

}
