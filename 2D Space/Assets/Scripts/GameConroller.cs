using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameConroller : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject gameWon;
    // Start is called before the first frame update
    void Start()
    {

        gameOverPanel.SetActive(false);
        gameWon.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void show()
    {
        gameOverPanel.SetActive(true);
    }

    public void gameWonShow()
    {
        gameWon.SetActive(true);
    }

    public void reload()
    {
        Debug.Log("reload");
        SceneManager.LoadScene("Game");
    }
}
