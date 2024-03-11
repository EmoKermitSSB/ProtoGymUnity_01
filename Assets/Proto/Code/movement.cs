using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class movement : MonoBehaviour
{

    [SerializeField] int Speed;

    [SerializeField] int DashSpeed;

    [SerializeField] bool isGrounded = false;

    [SerializeField] private Rigidbody2D rb;

    [SerializeField] int JumpingPower;

    [SerializeField] Transform GroundCheckCollider;

    [SerializeField] const float GroundCheckRadius = 0.2f;

    [SerializeField] LayerMask GroundLayer;

    [SerializeField] float NbJump = 2;


    void Start()
    {

    }


    void Update()
    {
        GroundCheck();
        moving();
    }

    //Ground Check who's detecting with a collider if the player is walking on the ground or flying
    void GroundCheck()
    {
        isGrounded = false;

        Collider2D[] colliders = Physics2D.OverlapCircleAll(GroundCheckCollider.position, GroundCheckRadius, GroundLayer);
        if(colliders.Length > 0)
            isGrounded = true;
    }

    //Here for Checking if the ground is colliding with the player or no
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("World"))
        { 
            isGrounded = true;
            //NbJump = 2;
        }
    }
    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("World"))
        {
            isGrounded = false;
        }
    }



    //All the movement Code
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
        }

        //Physic Attack 
        if (Input.GetKey(KeyCode.Keypad6))
        {
            
        }

        //Move Right
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Speed * Time.deltaTime, 0, 0);
        }
    }
}
    
       
  
       
   





