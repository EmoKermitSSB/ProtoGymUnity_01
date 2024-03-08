using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    [SerializeField] int Speed = 5;
    [SerializeField]bool isGrounded= false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        moving();
    }


    //Moove Mechanics
/*private void OnCollisionEnter2D(Collision2D collision)
{
    if(collision)
    {

    }
}*/
void moving()
{
    //if (isGrounded)
    {


     if (Input.GetKey(KeyCode.A))
    {
        transform.Translate(-Speed * Time.deltaTime, 0, 0);
    }
    if (Input.GetKey(KeyCode.S))
    {
        transform.Translate(0 * Time.deltaTime, 0, 0);
    }
    if (Input.GetKey(KeyCode.D))
    {
        transform.Translate(Speed * Time.deltaTime, 0, 0);

    }

    }
}

}
