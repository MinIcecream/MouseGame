using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    void Update()
    {
        transform.position += transform.right * Time.deltaTime * 90;
        rb.velocity = new Vector2(0.0f, 0.0f);

        if(transform.position.x < -160 || transform.position.x > 160)
        {
            Destroy(this.gameObject);
        
        }
        if (transform.position.y < -90 || transform.position.y > 90)
        {
            Destroy(this.gameObject);

        }
     



    }
}
