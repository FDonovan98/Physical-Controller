using UnityEngine;

[CreateAssetMenu(fileName = "DefualtEnemyAI", menuName = "AI/Enemy/Defualt")]
public class DefaultEnemyAI : BaseEnemyAIObject
{
    [SerializeField]
    private float fallSpeed = 1.0f;
    protected override void Movement(GameObject agent)
    {
        float xVel = 0.0f;
        float yVel = agent.GetComponent<Rigidbody2D>().velocity.y;
        yVel += -fallSpeed * Time.deltaTime;
        agent.GetComponent<Rigidbody2D>().velocity = new Vector2(xVel, yVel);
    }
}
