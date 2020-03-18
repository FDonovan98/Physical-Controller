using UnityEngine;

public abstract class EnemySpawningAIObject : ScriptableObject
{
    [SerializeField]
    protected MonoBehaviour enemyTemplate;
    [SerializeField]
    protected float spawnRate = 1.0f;
    protected int layerCount;
    protected float timeSinceLastSpawn = 0.0f;

    public abstract void RunOnStart(int activeLayers);
    public virtual void RunOnUpdate()
    {
        if (timeSinceLastSpawn > spawnRate)
        {
            SpawnEnemy();
        }
        else
        {
            timeSinceLastSpawn += Time.deltaTime;
        }
    }

    protected virtual void SpawnEnemy()
    {
        Debug.Log("Enemy spawned");
        timeSinceLastSpawn = 0.0f;
    }
    
    public virtual void ChangeLayerCount(int value)
    {
        layerCount = (int)Mathf.Clamp(layerCount + value, 0.0f, layerCount + value);
    }
}
