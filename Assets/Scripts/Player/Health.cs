using System.Collections;
using UnityEngine;

/// <summary>
/// Handle hitpoints and damages
/// </summary>
public class Health : MonoBehaviour
{
    /// <summary>
    /// Total hitpoints
    /// </summary>
    public int hp = 3;

	 public bool canLoseHP = true;

    /// <summary>
    /// Inflicts damage and check if the object should be destroyed
    /// </summary>
    /// <param name="damageCount"></param>
    public void Damage(int damageCount)
    {
        hp -= damageCount;
		 Debug.Log("Lose HP");

		 HUDGame.Instance.loseLife();

        if (hp <= 0)
        {
			  GameController.Instance.RestartLevel();
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Spikes" && canLoseHP)
        {
				Damage(1);
			  canLoseHP = false;
			  StartCoroutine( ResetCanLoseHP() );

				return;
        }
    }

	IEnumerator ResetCanLoseHP() {
		yield return new WaitForSeconds(3.0f);
		canLoseHP = true;
	}
}
