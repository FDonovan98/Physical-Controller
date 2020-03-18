using UnityEngine;

[CreateAssetMenu(fileName = "DefaultEnemySpawning", menuName = "AI/Enemy Spawning/Defualt")]
public class DefaultSpawning : EnemySpawningAIObject
{
    [SerializeField]
    private int spawnAreaHeight = 3;
    [SerializeField]
    private float spawnRate = 1.0f;
    private Vector2[] spawnArea;

    private float timeSinceLastSpawn = 0.0f;
    
    public override void RunOnStart(int activeLayers)
    {
        timeSinceLastSpawn = 0.0f;
        layerCount = activeLayers;

        Vector2[] screenCorners = new Vector2[2] ;
        screenCorners[0] = new Vector2(0.0f, Screen.height);
        screenCorners[1] = new Vector2(Screen.width, Screen.height);

        spawnArea = new Vector2[4]
        {
            new Vector2(0.0f, Screen.height),
            new Vector2(Screen.width, Screen.height),
            new Vector2(0.0f, Screen.height + spawnAreaHeight),
            new Vector2(Screen.width, Screen.height + spawnAreaHeight)
        };
    }

    public override void RunOnUpdate()
    {
        if (timeSinceLastSpawn > spawnRate)
        {
            Debug.Log("Enemy spawned");
            timeSinceLastSpawn = 0.0f;
        }
        else
        {
            timeSinceLastSpawn += Time.deltaTime;
        }
    }
}
