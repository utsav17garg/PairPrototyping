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
   

    public float speed = 10.0f;
    private Rigidbody2D rb;

    //private void Start()
    //{
    //    rb = this.GetComponent<Rigidbody2D>();
    //    rb.velocity = new Vector2(-speed, 0);
    //}

    private void OnCollisionEnter2D(Collision2D collision)
    {


        //BoxCollider2D spaceCollider = spaceShip.GetComponent<BoxCollider2D>();
        BoxCollider2D spaceCollider = GameObject.FindGameObjectsWithTag("Player")[0].GetComponent<BoxCollider2D>();
        GameObject timer = GameObject.FindGameObjectsWithTag("timer")[0];
        TextMeshProUGUI collectedLettersText = GameObject.FindGameObjectsWithTag("emptySpaces")[0].GetComponent<TextMeshProUGUI>();
        TimeManager script = timer.GetComponent<TimeManager>();
        char letter = this.gameObject.name[0]; // Get the letter's name or identifier
        if (collision.collider == spaceCollider)
        {
            
            Debug.Log(letter);
            Debug.Log(answer.Contains(letter));
            if (answer.Contains(letter))
            {
                index = answer.IndexOf(letter);
                collectedLettersText.text = collectedLettersText.text.Remove(index * 2, 1).Insert(index * 2, "" + letter);
                Destroy(gameObject);
                
                script.addTime();
                

            }
            else
            {
                Destroy(gameObject);
                Destroy(collision.gameObject);
                Debug.Log("GameOver");
            }
            
        }
        else
        {
            if (answer.Contains(letter))
            {
                script.penaltyTime();
                Destroy(collision.gameObject);
            }
            else
            {
                Destroy(gameObject);
                Destroy(collision.gameObject);
            }
            
            
        }
        
    }
}
