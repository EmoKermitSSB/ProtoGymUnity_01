using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class movement : MonoBehaviour
{
    [SerializeField] SpriteRenderer spriteRenderer;
    public bool CanMoov = true;

    private void Awake()
    {
        //DontDestroyOnLoad(gameObject);
    }
    void Start()
    {

    }


    void Update()
    {
        if (CanMoov == true)
        {
            moving();
        }

        GroundCheck();
    }


    //---------------------------------GROUNDCHECK----------------------------------------------//

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









    //---------------------------------MOVEMENT----------------------------------------------//

    [SerializeField]public static int Speed = 1000;

    [SerializeField] public Rigidbody2D rb;

    [SerializeField] public static float JumpingPower = 21.5f;
     
    [SerializeField] PlayerDamage Playerdamage;

    [SerializeField] public float XAxis;

    
    void moving()
    {
        
        XAxis = Input.GetAxis("Horizontal");
        

        //Move Left
        rb.velocity = new Vector2(Speed * -XAxis * Time.deltaTime, rb.velocity.y);

        if (XAxis < -0.01f)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }



        //Move Right
        rb.velocity = new Vector2(Speed * XAxis * Time.deltaTime, rb.velocity.y);

        if (XAxis > 0.01f){
            GetComponent<SpriteRenderer>().flipX = false;
        }
        
        

        //Jumping
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, JumpingPower);
        }
        

        /*if (Input.GetKey(KeyCode.Space) && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, JumpingPower);
        }

       
        
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-Speed * Time.deltaTime, 0, 0);
            GetComponent<SpriteRenderer>().flipX = true;
            
        }

        
        

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Speed * Time.deltaTime, 0, 0);
            GetComponent<SpriteRenderer>().flipX = false;
            
        }*/







    }


    
}











