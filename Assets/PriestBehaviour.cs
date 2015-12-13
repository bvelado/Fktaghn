using UnityEngine;
using DG.Tweening;

public class PriestBehaviour : MonoBehaviour {

    enum PriestState
    {
        Patrol, Attack
    }

    PriestState state;

    public Transform[] patrolWaypoints;
    Vector3[] waypointsPositions;
    public float patrolSpeed;
    int waypointIndex;

	// Use this for initialization
	void Start () {

        state = PriestState.Patrol;
        waypointIndex = 0;
        waypointsPositions = new Vector3[patrolWaypoints.Length];
        for(int i = 0; i < patrolWaypoints.Length; i++)
        {
            waypointsPositions[i] = patrolWaypoints[i].position;
        }
    }
	
	// Update is called once per frame
	void Update () {
	    if(state == PriestState.Patrol)
        {
            Debug.Log(waypointIndex);
            transform.DOMove(new Vector3(3, 0, 0), patrolSpeed);
            if (Vector3.SqrMagnitude(waypointsPositions[waypointIndex] - transform.position) < 0.0001)
            {
                waypointIndex++;
                if(waypointIndex-1 > waypointsPositions.Length)
                {
                    waypointIndex = 0;
                }
            }
        }
	}
}
