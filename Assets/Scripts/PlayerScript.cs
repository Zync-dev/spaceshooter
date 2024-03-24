using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    Rigidbody2D rb;
    GameObject Enemy;
    public float movementSpeed;
    float rotation;

    // Start is called before the first frame update
    void Start()
    {
        Enemy = GameObject.Find("Enemy");
        rb = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        // MOVEMENT

        // Get inputs from the Unity Input Manager
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(horizontal, vertical);

        // Add a force to the player.
        rb.AddForce(movement * movementSpeed, ForceMode2D.Force);



        // LUKAS ARBEJDE - PLAYER ROTATION
        var vel = rb.velocity;

        // Make sure the space ship keeps its rotation while stopped.
        if(vel.x != 0 || vel.y != 0)
        {
            // Calculate the rotation of the space ship using tan^-1
            rotation = -Mathf.Atan2(vel.x, vel.y) * 180 / Mathf.PI;
        }

        print(vel.x + " " + vel.y);
        print(rotation);

        // Get the child sprite and set its rotation.
        GameObject child = this.transform.GetChild(0).gameObject;
        child.transform.rotation = Quaternion.Euler(Vector3.forward * rotation);


        // UDREGN DISTANCE TIL ENEMY

        // Use pythgoras to calculate the distance between the enemy and the player.
        float distance = Mathf.Sqrt(Mathf.Pow(Enemy.transform.position.x - this.gameObject.transform.position.x, 2.0f) + Mathf.Pow(Enemy.transform.position.y - this.gameObject.transform.position.y, 2.0f));

        // COLLISION CHECK

        // Check if the distance is less than or equals to the radius of the player + the radius of the enemy.
        if(distance <= (1.3435183+0.5))
        {
            print("COLLISION!");
        } else
        {
            print("INGEN KOLLISION!");
        }
    }
}
