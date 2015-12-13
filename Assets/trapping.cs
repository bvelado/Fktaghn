using UnityEngine;
using System.Collections;
using DG.Tweening;

public class trapping : MonoBehaviour
{


    public string trapName = string.Empty;
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag != "Player")
        {
            GameObject gameObjectTrap = GameObject.Find("Trap");
            gameObjectTrap.transform.DOMove(new Vector3(0, -9, 0), 1).SetRelative();
        }

    }
}
