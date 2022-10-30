using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerCollision : MonoBehaviour
{
    private Shake shake;
    public GameObject player;
    public GameObject explosion;
    public static bool isDead = false;
    public Behaviour halo;
    public static int health = 3;
    public GameObject Health1;
    public GameObject Health2;
    public GameObject Health3;
    public float cooldown = 0.5f;
    public bool isCooldown = false;
    public void loadMenu()
    {
        
        SceneManager.LoadScene("Menu");
     
    }
    private void Update()
    {
        if (isCooldown == true)
        {
            cooldown -= Time.deltaTime;
        }if (cooldown <= 0) 
        {
            isCooldown = false;
            cooldown = 0.5f;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<Shake>();
        var whereSpawn = new Vector2(transform.position.x, transform.position.y);
        if (collision.gameObject.name == "Bullet")
        {
            if (isCooldown == false)
            {
                Destroy(collision.gameObject);
                health--;
                drawHealth();
                shake.CamShake();
                isCooldown = true;
            }
            
        }
        else if (collision.gameObject.name == "Heal")
        {
            Destroy(collision.gameObject);
            HealSpawn.numHeals = 0;
            if(health < 3)
            {
                health++;
    
            }
            drawHealth();
        }

    }


    void drawHealth()
    {
        var whereSpawn = new Vector2(transform.position.x, transform.position.y);
        if (health == 3)
        {
            Health1.SetActive(true);
            Health2.SetActive(true);
            Health3.SetActive(true);
        }else if (health == 2)
        {
            Health2.SetActive(true);
            Health1.SetActive(false);
            Health3.SetActive(true);
        }
        else if (health == 1)
        {
            Health1.SetActive(false);
            Health2.SetActive(false);
            Health3.SetActive(true);
        }else if (health <= 0)

        {
            Health1.SetActive(false);
            Health2.SetActive(false);
            Health3.SetActive(false);
            player.GetComponent<MeshRenderer>().enabled = false;
            halo.enabled = false;
            player.GetComponent<Movement>().enabled = false;
            isDead = true;
            var newExplosion = Instantiate(explosion, whereSpawn, Quaternion.identity);
            newExplosion.GetComponent<SelfDestruct>().enabled = false;
            Invoke("loadMenu", 2f);
        }
    }
}

