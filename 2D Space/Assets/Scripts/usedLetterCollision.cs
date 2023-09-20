using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class usedLetterCollision : MonoBehaviour
{
    public GameObject spaceShip;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        
        BoxCollider2D spaceCollider = spaceShip.GetComponent<BoxCollider2D>();
        if (collision.collider == spaceCollider)
        {
            Destroy(gameObject);
            Debug.Log(collision.collider);
            // Pick the letter and fill the blank
        }
        else
        {
            Destroy(collision.gameObject);
        }
        
    }
}
