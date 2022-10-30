using UnityEngine;

public class HealthMovement : MonoBehaviour
{
    public Transform player;
    
    void Update()
    {
        transform.position = new Vector2(player.position.x, player.position.y + 5);
    }
}
