using UnityEngine;

[CreateAssetMenu(fileName = "SpiralEnemyAI", menuName = "AI/Enemy/Spiral")]
public class SpiralFallEnemyAI : DefaultEnemyAI
{
    [SerializeField]
    protected float xSpeed = 1.0f;
    protected override void Movement(GameObject agent, float timeAlive = 0)
    {
        Movement(agent);
        float xVel = Mathf.Sin(timeAlive * Mathf.PI) * Time.deltaTime * xSpeed;
        float yVel = agent.GetComponent<Rigidbody2D>().velocity.y;
        agent.GetComponent<Rigidbody2D>().velocity = new Vector2(xVel, yVel);
    }
}
