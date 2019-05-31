using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerThrows : MonoBehaviour
{
    public GameObject texMexProjecc;
    public bool proteccProjecc;
    public float throwHeight;
    public float throwDistance;
    public KeyCode throwKey;
    public float throwDelay;
    float throwDelayLeft = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //still cooling down
        if (throwDelayLeft > 0.0f)
            { throwDelayLeft -= Time.deltaTime; }

        if (Input.GetKeyDown(throwKey) && throwDelayLeft <= 0.0f)
        {
            throwDelayLeft = throwDelay;
            //creates projectile in center of player and throws
            GameObject projecc = Instantiate(texMexProjecc, transform.position - new Vector3(GetComponent<SpriteRenderer>().bounds.size.x / 2, 0, 0), Quaternion.identity);
            projecc.GetComponent<Rigidbody2D>().velocity = new Vector3(throwDistance,throwHeight,0.0f);

            if (!proteccProjecc)
            {
                Destroy(projecc, throwDelay);
            }
        }
    }
}
