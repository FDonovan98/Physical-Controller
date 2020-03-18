using UnityEngine;

[CreateAssetMenu(fileName = "DefualtEnemyAI", menuName = "AI/Enemy/Defualt")]
public class DefaultEnemyAI : BaseEnemyAIObject
{
    [SerializeField]
    private float fallSpeed = 1.0f;
    protected override void Movement(UnityEngine.GameObject agent)
    {
        agent.GetComponent<Rigidbody2D>().velocity += new Vector2(0.0f, -fallSpeed * Time.deltaTime);
    }
}
