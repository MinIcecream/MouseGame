using UnityEngine;

public class HealSpawn : MonoBehaviour
{
    float seconds = 12;
    public GameObject heal;
    public static int numHeals = 0;


    void Update()
    {
        if (numHeals < 1)
        {
            seconds -= Time.deltaTime * 5;
            if (seconds <= 0)
            {


                if (PlayerCollision.isDead == false)
                {
                    seconds = Random.Range(10, 25);
                    RandomSpawn();
                    numHeals++;
                }

            }
        }
        


    }

    void RandomSpawn()
    {

        var whereSpawn = new Vector2(Random.Range(-60, 60), Random.Range(-60, 60));
        var newHeal = Instantiate(heal, whereSpawn, Quaternion.identity);

        newHeal.name = "Heal";
        newHeal.tag = "Clone";
    }
}
