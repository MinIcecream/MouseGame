using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterCollision : MonoBehaviour
{

    public GameObject explosion;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var whereSpawn = new Vector2(transform.position.x, transform.position.y);
        if (collision.gameObject.name == "Enemy")
        {
            Destroy(collision.gameObject);
            EnemySpawn.numEnemies -= 1;
            Score.killedEnemies++;
            Instantiate(explosion, whereSpawn, Quaternion.identity);
        }
        if (collision.gameObject.name == "Bullet")
        {
            Destroy(collision.gameObject);
            Score.killedEnemies++;
            var newExplosion = Instantiate(explosion, whereSpawn, Quaternion.identity);
            newExplosion.GetComponent<SelfDestruct>().enabled = false;
            Destroy(this.gameObject);
        }
        if (collision.gameObject.name == "Shooter")
        {
    

            var magnitude = 2;

            var force = transform.position - collision.gameObject.transform.position;

            force.Normalize();
            GetComponent<Rigidbody2D>().AddForce(-force * magnitude);


        }




    }
}
