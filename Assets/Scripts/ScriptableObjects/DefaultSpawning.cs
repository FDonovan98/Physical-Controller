using UnityEngine;

[CreateAssetMenu(fileName = "DefaultEnemySpawning", menuName = "AI/Enemy Spawning/Defualt")]
public class DefaultSpawning : EnemySpawningAIObject
{
    [SerializeField]
    private int spawnAreaHeight = 3;
    private float screenWidthInWorld;
    private float screenHeightInWorld;
    
    public override void RunOnStart(int activeLayers)
    {
        timeSinceLastSpawn = 0.0f;
        layerCount = activeLayers;

        Vector3 topOfScreen = new Vector3(Screen.width, Screen.height, 0.0f);
        Vector3 screenTopInWorld = Camera.main.ScreenToWorldPoint(topOfScreen);
        screenWidthInWorld = screenTopInWorld.x;
        screenHeightInWorld = screenTopInWorld.y;
    }

    protected override void SpawnEnemy()
    {
        float randomX = Random.Range(-screenWidthInWorld, screenWidthInWorld);
        float randomY = Random.Range(screenHeightInWorld, screenHeightInWorld + spawnAreaHeight);

        GameObject enemy = Instantiate(enemyTemplate, new Vector3(randomX, randomY, 1.0f), new Quaternion());
    }
}
