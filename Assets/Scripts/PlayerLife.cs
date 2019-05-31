using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    public int maxHealth;
    private int health;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    public int getHealth() { return health; }
    public void decrementHealth(int damage = 1)
    {
        health -= damage;
        if (health <= 0) { this.gameObject.SetActive(false); }
    }


}
