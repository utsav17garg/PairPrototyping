using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unusedLetterCollision : MonoBehaviour
{
    public GameObject spaceShip;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        Debug.Log(collision.collider);
        BoxCollider2D spaceCollider = spaceShip.GetComponent<BoxCollider2D>();
        if (collision.collider == spaceCollider)
        {
            Debug.Log("Game Over");
        }
        Destroy(collision.gameObject);
    }
}
