using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    

    public static int numEnemies = 1;
    float seconds = 3;
    public GameObject Enemy;


    void Update()
    {
      
        seconds -= Time.deltaTime* 5;
        if (seconds <= 0)
        {
            if (numEnemies < 21)
            {
                if (PlayerCollision.isDead == false)
                {
                    seconds = 3;
                    RandomSpawn();
                    numEnemies += 1;
                }
                
            }
            
        }
        
        
    }

    void RandomSpawn()
    {
        
        var whereSpawn = new Vector2(Random.Range(-60, 60), Random.Range(-60, 60));
        var newEnemy = Instantiate(Enemy, whereSpawn, Quaternion.identity);
        
        newEnemy.name = "Enemy";
        newEnemy.GetComponent < EnemyMovement>().enabled = true;
        newEnemy.tag = "Clone";
    }

}
