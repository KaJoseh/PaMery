using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarEscenaGM : MonoBehaviour
{
    sceneChangerClick cambiador;
    GameManager gm;

    //public GameObject pressSpace;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
        cambiador = GetComponent<sceneChangerClick>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gm.Jugando.Equals(2) && gm.BestoPuntos < PlayerPrefs.GetInt("patata"))
        {
            StartCoroutine(esperar());
        }
    }

    IEnumerator esperar()
    {
        yield return new WaitForSeconds(0.5f);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //pressSpace.GetComponent<RectTransform>().rect.width = pressSpace.GetComponent<RectTransform>().rect.width + 1;
            cambiador.irAEscena("Start");
        }

    }

}