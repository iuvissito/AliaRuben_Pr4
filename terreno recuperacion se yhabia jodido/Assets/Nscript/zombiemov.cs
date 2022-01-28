using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class zombiemov : MonoBehaviour
{

    Vector3 goal;
    float speed;
    float distance;
    bool detected;
    NavMeshAgent agent;

    [SerializeField] Transform emptyGoal, survivor;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        float RandomX = Random.Range(-5, 5);
        float RandomZ = Random.Range(-5, 5);
        Vector3 randomPos = new Vector3(RandomX, 0, RandomZ);
        Vector3 destPos = transform.position + randomPos;

        emptyGoal.transform.position = destPos;

        /* emptyGoal.transform.position.x = new Vector3(Random.Range(-5, 5));
         emptyGoal.transform.position. = new Vector3(Random.Range(-5, 5));*/
        //distance = Vector3.Distance(transform.position,goal);
        agent.speed = 4f;
       // goal = GameObject.Find("Survivor").transform.position;
        goal = survivor.position;
        agent.SetDestination(goal);
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(transform.position, goal);
        //print(distance);
        //Si la distancia al objetivo es menor 
        if (distance > 1f)
        {
            agent.speed = 3f;
        }
        else
        {
            agent.speed = 0f;
        }
        agent.SetDestination(goal);
    }
    //goal = GameObject.Find("Survivor").transform.position;
    //goal = emptyGoal.position;
    //agent.SetDestination(goal);
}


