using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Bullet.EnemyType type = Bullet.EnemyType.Kill;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == this.gameObject.layer)
        {
            if (other.GetComponent<Bullet>().type == type)
            {
                Debug.Log("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            }
            else
            {
                Debug.Log("I laugh at your puny attempts to defeat me");
            }
        }   
    }
}
