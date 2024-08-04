using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    NavMeshAgent nma;
    float newPositionTimer = 0;
    private int minRange = 5;
    private int maxRange = 10;

    // Start is called before the first frame update
    void Start()
    {
        // Grab the reference to the NavMeshAgent on this gameObject.
        nma = gameObject.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        // This is an example of using float variables and Time.deltaTime
        // to track how much time has passed (i.e. it is a timer).
        newPositionTimer = newPositionTimer - Time.deltaTime;
        if (newPositionTimer < 0)
        {
            newPositionTimer = Random.Range(1, 15);
            // Compute a random position and assign it to the NavMeshAgent.
            Vector3 randomPosition = RandomNavmeshLocation(Random.Range(minRange, maxRange)); // this changes jaguar pace
            nma.SetDestination(randomPosition);
        }
    }

    // This function will find a random position located on the NavMesh
    public Vector3 RandomNavmeshLocation(float radius)
    {
        Vector3 randomDirection = Random.insideUnitSphere * radius;
        randomDirection += transform.position;
        NavMeshHit hit;
        Vector3 finalPosition = Vector3.zero;
        if (NavMesh.SamplePosition(randomDirection, out hit, radius, 1))
        {
            finalPosition = hit.position;
        }
        return finalPosition;
    }
}