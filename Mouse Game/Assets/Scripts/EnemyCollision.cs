using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
   
        if (collision.gameObject.name == "Enemy")
        {
            Destroy(collision.gameObject);
            EnemySpawn.numEnemies -= 1;
            Score.killedEnemies++;
        }
        if (collision.gameObject.name == "Bullet")
        {
            Destroy(collision.gameObject);
            EnemySpawn.numEnemies -= 1;
            Score.killedEnemies++;
            Destroy(this.gameObject);
        }
        if (collision.gameObject.name == "Shooter")
        {
            Destroy(collision.gameObject);
            Score.killedEnemies++;
        }

    }
}
