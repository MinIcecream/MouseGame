using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public Transform Player;
    void Update()
    {
        if (PlayerCollision.isDead == false)
        {
            transform.right = Player.position - transform.position;
            transform.position = Vector2.MoveTowards(transform.position, Player.position, 0.2f);
        }
        

    }

}
