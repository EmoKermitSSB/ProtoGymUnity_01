using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MonsterMove : MonoBehaviour
{

    [SerializeField] float Speed;
    [SerializeField] private Rigidbody2D rb;

    void Start()
    {
        //Réccupère le current point pour savoir le quel suivre 
        rb = GetComponent<Rigidbody2D>();
        currentPoint = P_A.transform;
    }


    void Update()
    {
        // Execute la fonction si dessous 
        Patrolling();
    }









    [SerializeField] public GameObject P_A;
    [SerializeField] public GameObject P_B;
    [SerializeField] private Transform currentPoint;


    //Fonction qui permet au monste de patroll et d'aller d'un point A a un point B 
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
    
       
  
       
   





