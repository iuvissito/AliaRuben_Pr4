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
    bool Atrapado = false;
    float RangoVs = 10f;
    float ConeVs = 60f;
    NavMeshAgent agent;
    Animator animator;

    [SerializeField] Transform emptyGoal, survivor;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        survivor = GameObject.Find("Survivor").transform;
       
       
        

        /* emptyGoal.transform.position.x = new Vector3(Random.Range(-5, 5));
         emptyGoal.transform.position. = new Vector3(Random.Range(-5, 5));*/
        //distance = Vector3.Distance(transform.position,goal);
        
       // goal = GameObject.Find("Survivor").transform.position;
       StartCoroutine("Ronda");
    }

    // Update is called once per frame
    void Update()
    {
        Detectar();
        if(detected)

        {
            print("hola");
            StopCoroutine("Ronda");
            animator.SetBool("attack", true);
        
            animator.SetBool("walk",false);
            goal = survivor.position;
        }
        else
        {
            goal = emptyGoal.position;
            animator.SetBool("attack", false);
            animator.SetBool("walk",true);
            StartCoroutine("Ronda");
        }
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
    IEnumerator Ronda()
    {

        while(!detected)
        {
            print("no detectado");
            animator.SetBool("walk",true);
            
            float RandomX = Random.Range(-5f, 5f);
            float RandomZ = Random.Range(-5f, 5f);
            Vector3 randomPos = new Vector3(RandomX, 0, RandomZ);
            Vector3 destPos = transform.position + randomPos;

            yield return new WaitForSeconds(Random.Range(5f,10f));

           
            emptyGoal.transform.position = destPos;

            
        }
    }
    void Detectar()
    {
        Vector3 playerPosition = survivor.position;
        Vector3 vectorToPlayer = playerPosition - transform.position;
        float distanceToPlayer = Vector3.Distance(transform.position, playerPosition);
        float angleToPlayer = Vector3.Angle(transform.forward, vectorToPlayer);
          if (distanceToPlayer <= RangoVs && angleToPlayer <= ConeVs )
        {
            if(!Atrapado)
            {
                StopCoroutine("Ronda");
                detected = true;
                Atrapado = true;
                
            }
            
        }
        else
        {
            if(Atrapado)
            {
                detected = false;
                StartCoroutine("Ronda");
                Atrapado = false;
            }

    }
    //goal = GameObject.Find("Survivor").transform.position;
    //goal = emptyGoal.position;
    //agent.SetDestination(goal);
}

  }
