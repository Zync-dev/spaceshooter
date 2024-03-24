using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = 2f * Mathf.Cos(1.5f * Time.deltaTime);
        float y = 2f * Mathf.Sin(1.5f * Time.deltaTime);

        //print(x + " - " + y);

        this.transform.position += new Vector3(x, y);
    }
}
