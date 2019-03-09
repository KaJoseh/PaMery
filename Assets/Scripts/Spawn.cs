using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    GameObject[] obstaculo;
    public GameObject respawn;
    public GameObject killer;

    // Start is called before the first frame update
    void Start()
    {
        obstaculo = GameObject.FindGameObjectsWithTag("Obstacle");
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < obstaculo.Length;i++)
        {
            if (obstaculo != null && obstaculo[i].transform.position.x <= killer.transform.position.x)
            {
                obstaculo[i].transform.position = new Vector2(respawn.transform.position.x, Random.Range(-4.5f, -0.5f));

            }
        }
        
    }


}
