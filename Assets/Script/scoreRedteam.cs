using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scoreRedteam : MonoBehaviour
{
    public Text scoretext;
    public static int scorecount;
    void Start()
    {
        
    }

    void Update()
    {
        scoretext.text = "score: " + Mathf.Round(scorecount);
    }

    public void WinRedTeam()
    {
        if (scorecount >= 7)
        {
            scorecount = 0;
            Debug.Log("Joueur Rouge � gagn� !");
            SceneManager.LoadScene("Menu");
        }
    }
}
