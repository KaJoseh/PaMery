using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObstacle : MonoBehaviour
{
    [Range(1f, 5f)]
    public float velocidadMovimiento;

    private GameManager gm;
    
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(gm.Jugando.Equals(1) )
        {
            gameObject.transform.Translate(-velocidadMovimiento * Time.deltaTime, 0.0f, 0.0f);
        }
        else
        {
            //gameObject.transform.Translate(0.0f, 0.0f, 0.0f);
        }
        
    }
}
