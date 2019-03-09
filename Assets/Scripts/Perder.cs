using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perder : MonoBehaviour
{
    public GameObject gameOver;
    GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
        gameOver.SetActive(false);
        gm.Jugando = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (gm.Jugando.Equals(2))
        {
            gameObject.GetComponent<Animator>().SetBool("Muertesito", true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Obs"))
        {
            gm.Jugando = 2;
            gameOver.SetActive(true);
            if (gm.Puntos > gm.BestoPuntos)
            {
                
                PlayerPrefs.SetInt("patata", gm.BestoPuntos);
            }


        }

    }
}
