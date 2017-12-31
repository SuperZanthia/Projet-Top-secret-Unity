using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI_tree : MonoBehaviour
{
    //l'arbre suit le joueur

    private Transform _Player;

    public float _UpdateAI = 0.0f;

    public float _UpdateAIPeriod = 0.3f;

    void Start()
    {
        _Player = GameObject.FindWithTag("Player").transform;

        _UpdateAI = Random.value;
    }

    void Update()
    {

        _UpdateAI += Time.deltaTime;

        if (_UpdateAI > _UpdateAIPeriod)
        {
            _UpdateAI = 0.0f;

            NavMeshAgent na = GetComponent<NavMeshAgent>();

            na.SetDestination(_Player.position);


        }



    }

    
}
