using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    Rigidbody2D rb;
    GameObject Enemy;
    public float movementSpeed;
    // Start is called before the first frame update
    void Start()
    {
        Enemy = GameObject.Find("Enemy");
        rb = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float output = Mathf.Sqrt(Mathf.Pow(Enemy.transform.position.x - this.gameObject.transform.position.x, 2.0f) + Mathf.Pow(Enemy.transform.position.y - this.gameObject.transform.position.y, 2.0f));
        print(output);
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.up*movementSpeed,ForceMode2D.Force);
            
        }
        else if(Input.GetKey(KeyCode.S)){
            rb.AddForce(-transform.up * movementSpeed, ForceMode2D.Force);
            
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-transform.right * movementSpeed, ForceMode2D.Force);
            
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(transform.right * movementSpeed, ForceMode2D.Force);
        
        }
        else if (Input.GetKey(KeyCode.Escape))
        {
            // do thing

        }
    }
}
