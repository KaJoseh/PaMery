using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlesController : MonoBehaviour
{
    public GameObject player;
    ParticleSystem ps;
    GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
        ps = gameObject.GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector2(gameObject.transform.position.x, player.transform.position.y);
        if (gm.Jugando == 1)
        {
            ps.enableEmission = true;
            //Debug.Log("jugando");
        }
        else 
        {
            ps.enableEmission = false;
        }
    }
}
