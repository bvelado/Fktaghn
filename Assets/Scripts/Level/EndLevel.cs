using UnityEngine;

public class EndLevel : MonoBehaviour {
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.name == "Player")
        {
            GameController.Instance.Next();
        }
    }
}
