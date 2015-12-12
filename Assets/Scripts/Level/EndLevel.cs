using UnityEngine;
using System.Collections;

public class EndLevel : MonoBehaviour {
    void OnTriggerEnter(Collider col)
    {
        if (col.name == "Player")
        {
            GameController.Instance.Next();
        }
    }
}
