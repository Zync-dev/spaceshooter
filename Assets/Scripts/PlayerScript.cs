using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    float movementSpeed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        print("Hello World");
    }

    // Update is called once per frame
    void Update()
    {

        this.gameObject.transform.Translate(Vector3.left * movementSpeed * Time.deltaTime);
    }
}
