using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bordere : MonoBehaviour

{
    private GameConroller gameOverPanel;
    private void Start()
    {

        gameOverPanel = GameObject.Find("GameController").GetComponent<GameConroller>();
    }

    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        BoxCollider2D spaceCollider = GameObject.FindGameObjectsWithTag("Player")[0].GetComponent<BoxCollider2D>();
        if(collision.collider == spaceCollider)
        {
            //Time.timeScale = 0;
            Destroy(collision.gameObject);
            gameOverPanel.show();
        }
        Destroy(collision.gameObject);
        
        Debug.Log("Destroyed");
    }
}
