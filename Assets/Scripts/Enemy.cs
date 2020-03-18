using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private BaseEnemyAIObject aI;
    private Bullet.EnemyType type = Bullet.EnemyType.Kill;

    void Update()
    {
        aI.RunOnUpdate(this.gameObject);
    }

    void OnTriggerEnter2D(Collider2D other)
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
