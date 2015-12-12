using UnityEngine;
using System.Collections;

public class trapping : MonoBehaviour {


    public string trapName = string.Empty;
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag != "Player")
        {
           GameObject gameObjectTrap = GameObject.Find("Trap");
           gameObjectTrap.transform.position = new Vector3(transform.position.x + 0.02f, transform.position.y);       
        }

    }
}
