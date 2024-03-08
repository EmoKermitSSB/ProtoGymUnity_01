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
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GroundCheck();
        moving();
    }

    void GroundCheck()
    {
        isGrounded = false;

        Collider2D[] colliders = Physics2D.OverlapCircleAll(GroundCheckCollider.position, GroundCheckRadius, GroundLayer);
        if(colliders.Length > 0)
            isGrounded = true;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("World"))
        { 
            isGrounded = true;
        }
    }
    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("World"))
        {
            isGrounded = false;
        }
    }




    void moving()
    {
        if (Input.GetKey(KeyCode.Space) && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, JumpingPower);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-Speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.Keypad6))
        {
           //Attack Phisyc
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Speed * Time.deltaTime, 0, 0);
        }
    }
}
    
       
  
       
   





