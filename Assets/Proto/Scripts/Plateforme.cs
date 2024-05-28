using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plateforme : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Moov());
        
    }

    IEnumerator Moov()
    {
        new Vector2(5 * Time.deltaTime, 0);
        yield return new WaitForSeconds(5);
        new Vector2(-5 * Time.deltaTime, 0);

    }
}
