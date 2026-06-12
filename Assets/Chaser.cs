using UnityEngine;

public class Chaser : MonoBehaviour
{

    //how fast the student moves towards the teacher
    private float moveSpeed = 2f;

    //These to instance variables are used to get the teacher positiion and move the character
    private Transform playerTransform;
    private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        //This finds the teacher class/gameobjectand stores it
        GameObject player = GameObject.FindGameObjectWithTag("Enemy");

        if (player != null)
        {   
            //gets the teachers position and stores it
            playerTransform = player.transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(playerTransform != null)
        {
            //calculates the direction from the teacher and the student
            Vector2 direction = (playerTransform.position - transform.position).normalized;

            //Moves the student towards the teacher
            rb.MovePosition(rb.position + direction * moveSpeed * Time.fixedDeltaTime);

        }
        
    }
}
