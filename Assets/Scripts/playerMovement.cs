using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class playerMovement : MonoBehaviour
{
    public KeyCode leftKey;
    public KeyCode rightKey;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(rightKey))
        {
            transform.Translate( 0.15f, 0, 0);
        }

        if (Input.GetKey(leftKey))
        {
            transform.Translate( -0.15f, 0, 0);
        }

    }
}
