using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reciever : MonoBehaviour
{
    public CommNet commNet;
    // Start is called before the first frame update
    void Start()
    {
        commNet.enemySpotted += EnemySpotted;
    }

    void EnemySpotted(Transform enemy)
    {
        Debug.Log(gameObject.name + " didn't spot an enemy, but heard about it");
    }

}
