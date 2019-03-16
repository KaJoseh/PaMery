using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Perder : MonoBehaviour
{
    public GameObject gameOver;
    GameManager gm;
    SetearPuntaje st;
    
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
        gm.Jugando = 0;
        st = GameObject.FindGameObjectWithTag("seteador").GetComponent<SetearPuntaje>();
    }

    void Update()
    {
        if (gm.Jugando.Equals(2))
        {
            gameObject.GetComponent<Animator>().SetBool("Muertesito", true);
            Debug.Log(PlayerPrefs.GetInt("patata").ToString());
            //gameOver.SetActive
        }
        else
        {
            gameOver.SetActive(false);
            st.setScore();
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
                gm.BestoPuntos = gm.Puntos;
                PlayerPrefs.SetInt("patata", gm.BestoPuntos);
            }
        }
    }
}
