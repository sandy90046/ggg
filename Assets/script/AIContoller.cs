using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIContoller : MonoBehaviour {
    NavMeshAgent agent;
    Player character;
    Transform player;

    void Start()
    {
        character = GetComponent<Player>();
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }


    void Update()
    {
        agent.destination = player.position;
   

    }
}
