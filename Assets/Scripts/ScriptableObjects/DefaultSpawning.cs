using UnityEngine;

public class DefaultSpawning : EnemySpawningAIObject
{
    [SerializeField]
    private int spawnAreaHeight = 3;
    [SerializeField]
    private float spawnRate = 1.0f;
    private Vector2[] spawnArea;

    private MonoBehaviour monoBehaviour;
    private int layerCount;
    
    public void StartSpawning(int activeLayers)
    {
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

        monoBehaviour.InvokeRepeating("SpawnEnemy", 0.0f, spawnRate);
    }

    void OnDisable()
    {
        monoBehaviour.CancelInvoke();
    }

    public void ChangeLayerCount(int value)
    {
        layerCount = (int)Mathf.Clamp(layerCount + value, 0.0f, layerCount + value);
    }

    protected override void SpawnEnemy()
    {

    }
}
