using UnityEngine;

/// <summary>
/// Projectile behavior
/// </summary>
public class ShotScript : MonoBehaviour
{
    // 1 - Designer variables

    /// <summary>
    /// Damage inflicted
    /// </summary>
    public int damage = 1;

    /// <summary>
    /// Projectile damage player or enemies?
    /// </summary>
    public bool isEnemyShot = true;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag != "Enemy")
        {
            Destroy(gameObject);
        }       
    }
}
