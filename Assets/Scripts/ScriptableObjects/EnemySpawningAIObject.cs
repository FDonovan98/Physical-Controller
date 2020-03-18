using UnityEngine;

public abstract class EnemySpawningAIObject : ScriptableObject
{
    [SerializeField]
    protected MonoBehaviour enemyTemplate;
    protected int layerCount;

    public abstract void RunOnStart(int activeLayers);
    public abstract void RunOnUpdate();
    public virtual void EndSpawning()
    {
        enemyTemplate.CancelInvoke();
        Debug.Log("OnDisable");
    }

    public virtual void ChangeLayerCount(int value)
    {
        layerCount = (int)Mathf.Clamp(layerCount + value, 0.0f, layerCount + value);
    }
}
