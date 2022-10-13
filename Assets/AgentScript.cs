using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentScript : MonoBehaviour
{
    NavMeshAgent agent;
    [SerializeField] Transform destinationTransform;
    public float RemainingDistance;

    [SerializeField] Transform[] targets;
    [SerializeField] int currentTarget = 0;
    [SerializeField] float arrivingDistance;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.destination = targets[0].position;
    }

    // Update is called once per frame
    void Update()
    {
        Patrullaje();
        agent.destination = targets[currentTarget].position;
    }

    void Patrullaje()
    {
        if(Vector3.Distance(transform.position,targets[currentTarget].position) < arrivingDistance)
        {
            if (currentTarget<targets.Length -1)
            {
                currentTarget++;
            }
            else
            {
                currentTarget = 0;
            }
        }
    }
}
