using UnityEngine;

[CreateAssetMenu(fileName = "CommNet", menuName = "Physical-Controller/CommNet", order = 0)]
public class CommNet : ScriptableObject 
{
    public delegate void EnemySpotted(Transform enemy);
    public EnemySpotted enemySpotted;
}