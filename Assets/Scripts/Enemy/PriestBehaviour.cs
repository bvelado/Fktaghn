using UnityEngine;
using DG.Tweening;
using System.Collections;

public class PriestBehaviour : MonoBehaviour
{

    enum PriestState
    {
        Patrol, Attack
    }

    PriestState state;
    public LayerMask playerMask;
    private Weapon[] weapons;
    public Vector3 movement;
    public float patrolSpeed;
    private Vector3 initPosition;
    private float diffVector;
    public int distanceDetec;

	 public Transform avatar;

    public bool convertable = false;

	 private bool readyLaunch = false;

    void Awake()
    {
        // Retrieve the weapon only once
        weapons = GetComponentsInChildren<Weapon>();
    }

    // Use this for initialization
	 void Start () {
		 initPosition = transform.position;
		 Vector3 targetPosition = initPosition + movement;
		 state = PriestState.Patrol;
		 transform.DOMoveX( movement.x, patrolSpeed ).SetRelative().SetLoops( -1, LoopType.Yoyo );
	 }

	 void SwitchFaceDir ( int index ) {
		 transform.DORotate( new Vector3( 0, 0, index * 180 ), 2.0f, RotateMode.Fast );
	 }

    void Update()
    {
		 Debug.DrawLine(transform.position, transform.right*distanceDetec);

        RaycastHit2D hit = Physics2D.Raycast(new Vector2(transform.position.x, transform.position.y), transform.right, distanceDetec, playerMask);

        if (hit != null && hit.collider != null)
        {
            gameObject.transform.DOPause();
            StartCoroutine(Example());
        }
        else
        {
            gameObject.transform.DOPlay();
        }

		  hit = Physics2D.Raycast( new Vector2( transform.position.x, transform.position.y ), -transform.right, distanceDetec, playerMask );

		  if (hit != null && hit.collider != null) {
			  gameObject.transform.DOPause();
			  StartCoroutine( Example() );
		  } else {
			  gameObject.transform.DOPlay();
		  }
    }

    IEnumerator Example()
    {
        if (readyLaunch == false)
        {
            readyLaunch = true;
            foreach (Weapon weapon in weapons)
            {
                // Auto-fire
                if (weapon != null && weapon.CanAttack)
                {
                    weapon.Attack(true);
                    yield return new WaitForSeconds(1);
                    weapon.Attack(true);
                    yield return new WaitForSeconds(1);
                    weapon.Attack(true);
                    convertable = true;
                    yield return new WaitForSeconds(3);
                    convertable = false;
                }
            }
            readyLaunch = false;
        }
    }

}
