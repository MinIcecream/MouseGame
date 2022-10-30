using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject Bullet;
    public Transform Player;
    float seconds = 5;
    void Update()
    {
        seconds -= Time.deltaTime * 5;
        if (seconds <= 0)
        {
            if (PlayerCollision.isDead == false)
            {
                seconds = 5;

                DoShoot();

            }

        }
    }
    void DoShoot()
    {
        
        Vector2 bulletLocation = new Vector2(transform.position.x, transform.position.y);
        var newBullet = Instantiate(Bullet, bulletLocation, Quaternion.identity);
        newBullet.transform.right = Player.position - newBullet.transform.position;
        newBullet.GetComponent<BulletMovement>().enabled = true;
        newBullet.name = "Bullet";
        newBullet.transform.position += transform.right * 20;
    }
}

