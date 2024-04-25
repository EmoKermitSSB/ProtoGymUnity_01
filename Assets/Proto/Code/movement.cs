using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class movement : MonoBehaviour
{
    [SerializeField] SpriteRenderer spriteRenderer;

    private void Awake()
    {
        //DontDestroyOnLoad(gameObject);
    }
    void Start()
    {

    }

    private void FixedUpdate()
    {
        moving();
    }


    void Update()
    {
        GroundCheck();
    }




    [SerializeField] bool isGrounded = false;
    [SerializeField] Transform GroundCheckCollider;
    [SerializeField] const float GroundCheckRadius = 0.2f;
    [SerializeField] LayerMask GroundLayer;

    //Ground Check detecte si un collider est present sous les pied du player pour pouvoir l'empecher de sauter ou d'effectuer d'autre action temps qu'il n'est aps au sol 
    void GroundCheck()
    {
        isGrounded = false;

        Collider2D[] colliders = Physics2D.OverlapCircleAll(GroundCheckCollider.position, GroundCheckRadius, GroundLayer);
        if(colliders.Length > 0)
            isGrounded = true;
    }




    [SerializeField] public static int Speed = 10;

    [SerializeField] int DashSpeed;

    [SerializeField] private Rigidbody2D rb;

    [SerializeField] public static float JumpingPower = 20f;

    //[SerializeField] float NbJump = 2;

    //Tous le code pour les mouvements 
    void moving()
    {

        //Jumping
        if (Input.GetKey(KeyCode.Space) && isGrounded /*|| NbJump > 0*/)
        {
            rb.velocity = new Vector2(rb.velocity.x, JumpingPower);
            //NbJump = NbJump - 1;
        }

        //Move Left
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-Speed * Time.deltaTime, 0, 0);
            GetComponent<SpriteRenderer>().flipX = true;
        }

        //Move Right
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Speed * Time.deltaTime, 0, 0);
            GetComponent<SpriteRenderer>().flipX = false;
        }
    }


    
}











