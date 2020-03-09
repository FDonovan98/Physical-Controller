using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public enum EnemyType
    {
        Shit,
        Awful,
        Kill,
        Me
    }

    public EnemyType type;
    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}