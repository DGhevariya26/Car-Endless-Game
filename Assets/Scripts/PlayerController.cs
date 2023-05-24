using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{    
    private float horizontalInput;
    public float speed = 20;
    public bool isGroundOn = true;
    public bool gameOver = false;
    
    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal"); 
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
       
        if(transform.position.x < -8)
        {
            transform.position = new Vector3(-8, transform.position.y, transform.position.z);
        }
        
        if(transform.position.x > 28)
        {
            transform.position = new Vector3(28, transform.position.y, transform.position.z);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            isGroundOn = true;
        }

        else if(collision.gameObject.CompareTag("Obstacle1"))
        {
            gameOver = true;
            Debug.Log("Game Over !!");
        }
           
    }
}

