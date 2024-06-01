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

    [SerializeField]public  bool isGrounded = false;

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

    [SerializeField]public static int Speed = 15;

    [SerializeField] public Rigidbody2D rb;

    [SerializeField] public static float JumpingPower = 21.5f;
     
    [SerializeField] PlayerDamage Playerdamage;

    [SerializeField] public float XAxis;

    [SerializeField] Animator PlayerAnimator;

    
    void moving()
    {
        
        XAxis = Input.GetAxis("Horizontal");
        

        //Move Left
        rb.velocity = new Vector2(Speed * -XAxis , rb.velocity.y);

        if (XAxis < -0.01f)
        {
            PlayerAnimator.SetBool("IsRunning", true);
            GetComponent<SpriteRenderer>().flipX = true;
        }

        if (XAxis > 0.01f)
        {
            PlayerAnimator.SetBool("IsRunning", true);
            GetComponent<SpriteRenderer>().flipX = false;
        }
      
        if (XAxis == 0)
        {
            PlayerAnimator.SetBool("IsRunning", false);
        }



        //Move Right
        rb.velocity = new Vector2(Speed * XAxis, rb.velocity.y);

        
        if (isGrounded)
        {
            PlayerAnimator.SetBool("IsJumping", false);
        }
        if (!isGrounded)
        {
            PlayerAnimator.SetBool("IsJumping", true);
        }
        if (XAxis == 0 && !isGrounded)
        {
            PlayerAnimator.speed = 2f;
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











