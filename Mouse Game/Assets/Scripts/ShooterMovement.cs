using UnityEngine;

public class ShooterMovement : MonoBehaviour
{
    public Transform Player;
    void Update()
    {
        if (PlayerCollision.isDead == false)
        {
            transform.right = Player.position - transform.position;
            if (Vector2.Distance(Player.position, transform.position) > 65)
            {
                transform.position = Vector2.MoveTowards(transform.position, Player.position, 0.5f);
            }
            else if (Vector2.Distance(Player.position, transform.position) < 65 && Vector2.Distance(Player.position, transform.position) > 35)
            {
                transform.position = transform.position;
            }
            else if (Vector2.Distance(Player.position, transform.position) < 35)
            {
                transform.position = Vector2.MoveTowards(transform.position, Player.position, -0.8f);
            }

        }
        else {
            GetComponent<ShooterMovement>().enabled = false;
        }


    }

}
