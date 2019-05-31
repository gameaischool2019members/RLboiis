using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TexMexRemoval : MonoBehaviour
{

    void Start() { print("Projectile Spawned"); }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //avoids hitting self by only checking on the way down
        //avoids middle wall because middle wall is like, an inch off the ground.
        //(Player rigidbodies can't rotate for this reason)
        if (this.GetComponent<Rigidbody2D>().velocity.y <= 0)
        {
            //if thing that was hit has a "life" component
            if (collision.gameObject.GetComponent<PlayerLife>())
            { collision.gameObject.GetComponent<PlayerLife>().decrementHealth(); }

            Destroy(gameObject);
        }
    }
}
