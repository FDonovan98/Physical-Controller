using UnityEngine;

public abstract class BaseEnemyAIObject : ScriptableObject
{
    public virtual void RunOnUpdate(GameObject agent, float timeAlive)
    {
        Movement(agent);
        Movement(agent, timeAlive);
    }

    protected virtual void Movement(GameObject agent){}
    protected virtual void Movement(GameObject agent, float timeAlive){}
}
