using UnityEngine;
using UnityEngine.SceneManagement;
public class Buttons : MonoBehaviour
{
    public void PlayAgain()
    {
        SceneManager.LoadScene("Game");
        PlayerCollision.isDead = false;
        EnemySpawn.numEnemies = 0;
        Score.killedEnemies = 0;
        PlayerCollision.health = 3;
        HealSpawn.numHeals = 0;
    }
    public void Quit()
    {
        Application.Quit();
    }
}
