using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class MonsterMovement : MonoBehaviour
{

    [SerializeField] float Speed;
    [SerializeField] private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentPoint = P_A.transform;
    }


    void Update()
    {
        Patrolling();
    }









    [SerializeField] public GameObject P_A;
    [SerializeField] public GameObject P_B;
    [SerializeField] private Transform currentPoint;


    //All the movement Code
    void Patrolling()
    {
        Vector2 point = currentPoint.position - transform.position;
        if (currentPoint == P_B.transform)
        {
            rb.velocity = new Vector2(Speed, 0);
        }
        else
        {
            rb.velocity = new Vector2(-Speed, 0);
        }

        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == P_B.transform)
        {
            currentPoint = P_A.transform;
        }
        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == P_A.transform)
        {
            currentPoint = P_B.transform;
        }
    }
}
    
       
  
       
   





