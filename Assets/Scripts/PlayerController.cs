using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f; 
    public float xrange = 15.0f;

     public GameObject projectilePrefab; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void    Update()
    {


        //handling player going off the game space
        if(transform.position.x < -xrange ){
            transform.position = new Vector3(-xrange,transform.position.y,transform.position.z);
            //now whenever player tried to go off screen he would just be repositioned at -10 on x axis!yayy! 
        }
        if(transform.position.x > xrange){
            transform.position = new Vector3(xrange,transform.position.y,transform.position.z);
            //now whenever player tried to go off screen he would just be repositioned at -10 on x axis!yayy! 
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);

        if (Input.GetKeyDown(KeyCode.Space)) {
         //whenevr spacebar is pressed we'll launch a projectile
         Instantiate(projectilePrefab, transform.position,projectilePrefab.transform.rotation); //Instantiate makes copies of alr5eady existing objects
        }
        
    }
}
