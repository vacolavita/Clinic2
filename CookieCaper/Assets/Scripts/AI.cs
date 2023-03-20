using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{

    float timer = 2;

    public NavMeshAgent agent;

    public Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer <= 0)
        {
            pos = (Random.insideUnitSphere * 10 + transform.position)/1.1f;
            agent.SetDestination(pos);
            timer = 10f;
        }
        else {
            timer -= Time.deltaTime;
        }
    }
}
