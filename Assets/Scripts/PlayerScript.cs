using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    GameObject Enemy;

    // Start is called before the first frame update
    void Start()
    {
        Enemy = GameObject.Find("Enemy");

        float output = Mathf.Sqrt(Mathf.Pow(Enemy.transform.position.x - this.gameObject.transform.position.x, 2.0f) + Mathf.Pow(Enemy.transform.position.y - this.gameObject.transform.position.y, 2.0f));
        print(output);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
