using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    [SerializeField] movement move;
    [SerializeField] GameObject Cam;
    [SerializeField] GameObject P;
    [SerializeField] float PPos;
    // Update is called once per frame
    void Update()
    {
        if (move.isGrounded)
        {
            Cam.transform.position = new Vector2(0, 0);
        }
    }
}
