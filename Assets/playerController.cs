using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class playerController : MonoBehaviour
{
   public float speed = 5f;
   private Vector2 movement;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
       // movementDirection.Normalize();
       float inputHoriz = Input.GetAxis("Horizontal");
       float inputvert = Input.GetAxis("Vertical");



       movement.x = inputHoriz * speed * Time.deltaTime;
       movement.y = inputvert * speed * Time.deltaTime;
       transform.Translate(movement);
   
    }

   
}
