using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoker : MonoBehaviour
{
    public CommNet commNet;

    private void Start()
    {
        EnemySpotted(this.transform);
    }

    private void EnemySpotted(Transform enemy)
    {
        Debug.Log(gameObject.name + " spotted an enemy");
        commNet.enemySpotted(enemy);
    }
}
