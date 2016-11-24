using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour
{
    //Christopher Gelinas 300844877 COMP305 Assignment 3 Part 2

    public NavMeshAgent Agent;
    public Transform SightStart;
    public Transform SightEnd;
    
    //private instance variables
    private Transform Player;
    public BoxCollider _boxCollider;

    // Use this for initialization
    void Start()
    {
        this.Player = GameObject.FindWithTag("Player").transform;
        this._boxCollider = GetComponent<BoxCollider>();

    }

    // Update is called once per frame
    void Update()
    {

        





    }

    
    private void OnCollisionEnter(Collision BoxCollider)
    {
        

        if (BoxCollider.gameObject.CompareTag("Player"))
        {
           


                this.Agent.SetDestination(this.Player.position);
            

        }
    }
}
