using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Perder : MonoBehaviour
{
    public GameObject gameOver;
    GameManager gm;
    SetearPuntaje st;
    SetearNombre sn;
    sceneChangerClick cambiador;
    GameObject boton_back;

    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
        gm.Jugando = 0;
        st = GameObject.FindGameObjectWithTag("seteador").GetComponent<SetearPuntaje>();
        sn = GameObject.FindGameObjectWithTag("seteador").GetComponent<SetearNombre>();
        cambiador = GameObject.FindGameObjectWithTag("canvas").GetComponent<sceneChangerClick>();
        boton_back = GameObject.FindGameObjectWithTag("boton");
    }

    void Update()
    {
        if (gm.Jugando.Equals(2))
        {
            gameObject.GetComponent<Animator>().SetBool("Muertesito", true);
            Debug.Log(PlayerPrefs.GetInt("patata").ToString());
            sn.setName();
            //gameOver.SetActive
        }
        else
        {
            gameOver.SetActive(false);
            st.setScore();
            //sn.setName();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Obs"))
        {
            gm.Jugando = 2;
            gameOver.SetActive(true);
            gm.BestoPuntos = gm.Puntos;
            if (gm.BestoPuntos > PlayerPrefs.GetInt("patata"))
            {
                PlayerPrefs.SetInt("patata", gm.BestoPuntos);
                boton_back.SetActive(false);
                StartCoroutine(cambiarEscena());
                //SceneManager.LoadScene("Felicidades", LoadSceneMode.Single);
            }
        }
    }
    IEnumerator cambiarEscena()
    {
        yield return new WaitForSeconds(2);
        cambiador.irAEscena("Felicidades");
    }
}
