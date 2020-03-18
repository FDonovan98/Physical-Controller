using UnityEngine;

public class FallingEnemy : MonoBehaviour
{
    [SerializeField]
    protected BaseEnemyAIObject aI;
    protected Bullet.EnemyType type = Bullet.EnemyType.Kill;

    private float timeAlive = 0.0f;

    void Update()
    {
        aI.RunOnUpdate(this.gameObject, timeAlive);
        timeAlive += Time.deltaTime;
    }

    protected void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == this.gameObject.layer && other.gameObject.tag == "Bullet")
        {
            if (other.GetComponent<Bullet>().type == type)
            {
                SendMessageUpwards("ChangeScore", 1);
                Debug.Log("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
                Destroy(this.gameObject);
            }
            else
            {
                Debug.Log("I laugh at your puny attempts to defeat me");
            }
        }   
    }
}
