using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Text scoreText;
    public static int killedEnemies = 0;

    void Update()
    {
        scoreText.text = System.Convert.ToString(killedEnemies);
    }
}
