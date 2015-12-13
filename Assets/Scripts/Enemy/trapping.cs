using UnityEngine;
using System.Collections;
using DG.Tweening;

public class trapping : MonoBehaviour
{

    public GameObject trap;
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag != "Player")
        {
            trap.transform.DOMove(new Vector3(0, -9, 0), 1).SetRelative();
        }

    }
}
