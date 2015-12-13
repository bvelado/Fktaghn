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
    public Vector3 destination;
    public float patrolSpeed;
    private Vector3 initVector;
    private float diffVector;
    public int distanceDetec;

    public bool convertable = false;

    void Awake()
    {
        // Retrieve the weapon only once
        weapons = GetComponentsInChildren<Weapon>();
    }

    // Use this for initialization
    void Start()
    {
        initVector = gameObject.transform.position;
        Vector3 result = initVector + destination;
        diffVector = result.x / 2;
        state = PriestState.Patrol;
        gameObject.transform.DOMoveX(diffVector, patrolSpeed).SetRelative().SetLoops(-1, LoopType.Yoyo);
    }

    private bool readyLaunch = false;
    // Update is called once per frame
    void Update()
    {
        var worldTouch = Camera.main.ScreenToWorldPoint(gameObject.transform.position);
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
