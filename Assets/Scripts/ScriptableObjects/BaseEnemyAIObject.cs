using UnityEngine;

public abstract class BaseEnemyAIObject : ScriptableObject
{
    public virtual void RunOnUpdate(GameObject agent)
    {
        Movement(agent);
    }
    protected abstract void Movement(GameObject agent);
}
