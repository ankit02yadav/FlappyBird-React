using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logicScript : MonoBehaviour  
{
    public int playerscore;
    public Text scoretext;
    public GameObject gameoverscreen;
    [ContextMenu("Increase Score")]
    public void addScore()
    {
        playerscore = playerscore + 1; 
        scoretext.text = playerscore.ToString();
    } 
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        gameoverscreen.SetActive(true);
    }
}
