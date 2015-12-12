using UnityEngine;
using System.Collections;

public class DetectEnemy : MonoBehaviour
{

    public LayerMask playerMask;
    private Weapon[] weapons;

    void Awake()
    {
        // Retrieve the weapon only once
        weapons = GetComponentsInChildren<Weapon>();
    }

    void Update()
    {

        var worldTouch = Camera.main.ScreenToWorldPoint(gameObject.transform.position);
        RaycastHit2D hit = Physics2D.Raycast(new Vector2(transform.position.x, transform.position.y), transform.right, Mathf.Infinity, playerMask);
     
        if (hit != null && hit.collider != null)
        {
            foreach (Weapon weapon in weapons)
            {
                // Auto-fire
                if (weapon != null && weapon.CanAttack)
                {
                    weapon.Attack(true);
                }
            }
        }
    }
}
