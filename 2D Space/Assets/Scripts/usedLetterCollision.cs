using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using TMPro;

public class usedLetterCollision : MonoBehaviour
{
    
    public string answer = "JUPITER";
    public int index;
    private StringBuilder collectedLetters = new StringBuilder();
    public TextMeshProUGUI collectedLettersText;
    private GameConroller gameOverPanel;

    public float speed = 10.0f;
    private Rigidbody2D rb;

    private void Start()
    {

        gameOverPanel = GameObject.Find("GameController").GetComponent<GameConroller>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {


        //BoxCollider2D spaceCollider = spaceShip.GetComponent<BoxCollider2D>();
        BoxCollider2D spaceCollider = GameObject.FindGameObjectsWithTag("Player")[0].GetComponent<BoxCollider2D>();
        GameObject timer = GameObject.FindGameObjectsWithTag("timer")[0];
        TextMeshProUGUI collectedLettersText = GameObject.FindGameObjectsWithTag("emptySpaces")[0].GetComponent<TextMeshProUGUI>();
        TimeManager script = timer.GetComponent<TimeManager>();
        char letter = this.gameObject.name[0]; // Get the letter's name or identifier
        char attack = collision.gameObject.name[0];
       
        if (collision.collider == spaceCollider)
        {
            
            Debug.Log(letter);
            Debug.Log(answer.Contains(letter));
            if (answer.Contains(letter))
            {
                index = answer.IndexOf(letter);
                collectedLettersText.text = collectedLettersText.text.Remove(index * 2, 1).Insert(index * 2, "" + letter);
                if (!collectedLettersText.text.Contains('_')) {
                    //Time.timeScale = 0;
                    Debug.Log("You Won");
                    gameOverPanel.gameWonShow();
                }
                Destroy(this.gameObject);
                script.addTime();
            }
            else
            {
                Destroy(this.gameObject);
                Debug.Log("Destroyed");
                Destroy(collision.gameObject);
                //Time.timeScale = 0;
                Debug.Log(gameOverPanel);
                gameOverPanel.show();
                Debug.Log("GameOver");
            }
            
        }else
        {
            Debug.Log(attack);
            if (answer.Contains(letter))
            {
                if(attack == 'M')
                {
                    Destroy(this.gameObject);
         
                }
                else if(attack == 'W')
                {
                    Debug.Log("PenaltyTime");
                    
                    Destroy(collision.gameObject);
                    script.penaltyTime();
                }
                
               
            }
            else if (attack == 'M')
            {
                Debug.Log("I am hit");
                Destroy(this.gameObject);
            }
            else
            {
                Destroy(gameObject);
                Debug.Log("Destroyed");
                Destroy(collision.gameObject);
            }
            
            
        }
        
    }
}
