using UnityEngine;

public class ShooterSpawn : MonoBehaviour
{



    float seconds = 3;
    public GameObject Shooter;


    void Update()
    {

        seconds -= Time.deltaTime * 5;
        if (seconds <= 0)
        {
            
            if (PlayerCollision.isDead == false)
            {
                seconds = 3;
                RandomSpawn();
         
            }

            

        }


    }

    void RandomSpawn()
    {

        var whereSpawn = new Vector2(Random.Range(-60, 60), Random.Range(-60, 60));
        var newShooter = (GameObject)Instantiate(Shooter, whereSpawn, Quaternion.identity);

        newShooter.name = "Shooter";
        newShooter.GetComponent<ShooterMovement>().enabled = true;
        newShooter.tag = "Clone";
    }

}
