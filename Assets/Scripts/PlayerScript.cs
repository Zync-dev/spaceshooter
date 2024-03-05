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

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(horizontal, vertical);

        rb.AddForce(movement * movementSpeed, ForceMode2D.Force);





        // LUKAS ARBEJDE
        var vel = rb.velocity;

        float answer = Mathf.Atan2(vel.x, vel.y) * 57.295779513f;

        GameObject child = this.transform.GetChild(0).gameObject;
        child.transform.rotation = Quaternion.Euler(Vector3.forward * answer);

        print(answer);
    }
}
