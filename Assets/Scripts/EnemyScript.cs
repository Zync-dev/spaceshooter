using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{

    public GameObject player;

    void Update()
    {
        float answer = -Mathf.Atan2(player.transform.position.x-this.transform.position.x, player.transform.position.y-this.transform.position.y) * 180 / Mathf.PI;

        this.transform.GetChild(0).transform.rotation = Quaternion.Euler(Vector3.forward * answer);
    }
}
