using UnityEngine;

public class Turret : MonoBehaviour
{
    public GameObject bullet;
    public float rotationBound = 10.0f;
    void FixedUpdate()
    {
        float XY = -Input.GetAxis("Horizontal");
        transform.Rotate(0.0f, 0.0f, XY);

        if (Input.GetButtonDown("Fire1"))
        {
            GameObject newBullet = Instantiate(bullet, transform.position, transform.rotation);
            newBullet.GetComponent<Rigidbody2D>().velocity = 10 * transform.up;
            newBullet.GetComponent<Bullet>().type = Bullet.EnemyType.Kill;
        }

        if (Input.GetButtonDown("Fire2"))
        {
            GameObject newBullet = Instantiate(bullet, transform.position, transform.rotation);
            newBullet.GetComponent<Rigidbody2D>().velocity = 10 * transform.up;
            newBullet.GetComponent<Bullet>().type = Bullet.EnemyType.Me;
        }
    }
}
