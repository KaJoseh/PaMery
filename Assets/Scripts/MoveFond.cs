using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFond : MonoBehaviour
{
    [Range(0.1f, 5.0f)]
    public float velocidad;

    private GameManager gm;
    //private Vector2 vector2;



    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
        //gameObject.transform.position = vector2;
    }

    // Update is called once per frame
    void Update()
    {
        if (gm.Jugando.Equals(1))
        {
            
            if (gameObject.transform.position.x <= -11.1f)
            {
                transform.position = Vector2.zero;

            }
            else
            {
                gameObject.transform.Translate(-1.0f * Time.deltaTime * velocidad, 0.0f, 0.0f);

            }
        }
        else
        {
            gameObject.transform.Translate(0.0f, 0.0f, 0.0f);
        }
        
    }
}
