using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using TMPro;

public class usedLetterCollision : MonoBehaviour
{
    public GameObject spaceShip;
    public string answer = "JUPITER";
    public int index;
    private StringBuilder collectedLetters = new StringBuilder();
    public TextMeshProUGUI collectedLettersText;
    public GameObject timer;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        
        BoxCollider2D spaceCollider = spaceShip.GetComponent<BoxCollider2D>();
        if (collision.collider == spaceCollider)
        {
            string letter = this.gameObject.name; // Get the letter's name or identifier
            Debug.Log(letter);
            Debug.Log(answer.Contains(letter));
            if (answer.Contains(letter))
            {
                index = answer.IndexOf(letter);
                collectedLettersText.text = collectedLettersText.text.Remove(index * 2, 1).Insert(index * 2, letter);
                Destroy(gameObject);
                TimeManager script = timer.GetComponent<TimeManager>();
                Debug.Log(script);
                script.addTime();
                

            }
            else
            {
                Destroy(collision.gameObject);
            }
            Debug.Log(collision.collider);
            

            // Pick the letter and fill the blank
            
        }
        else
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        
    }
}
