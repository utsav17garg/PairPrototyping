using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerMovement : MonoBehaviour

{
    private Transform m_transform;
    public float horizontalInput;
    public float speed = 1.0f;
    private float Horizontalspeed = 10.0f;
    private Rigidbody2D rb;
 

    // Start is called before the first frame update
    private void Start()
    {
        m_transform = this.transform;
        rb = GetComponent<Rigidbody2D>();


    }

    private void LAMouse()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - m_transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward); //Vector 3. forward is Z a› (a localvariable float angle
        m_transform.rotation = rotation;
        transform.Translate(Vector2.up * speed * Time.deltaTime);
        transform.Translate(Vector2.up * Horizontalspeed * Time.deltaTime * horizontalInput);
    }


    
    // Update is called once per frame
    void Update()
    {
        LAMouse();
       
    }

}
