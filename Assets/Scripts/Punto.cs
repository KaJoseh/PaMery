using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Punto : MonoBehaviour
{
    [Header ("El GameObject de Texto Puntaje")]
    public GameObject pt;
    public TextMeshProUGUI textoPuntaje;
    public TextMeshProUGUI puntuacionFinal;

    //public GameObject puntuacion;
    GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
        gm.Puntos = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (gm.Jugando.Equals(2))
            pt.SetActive(false);

        puntuacionFinal.SetText(gm.Puntos.ToString());
        textoPuntaje.SetText(gm.Puntos.ToString()); 
        //Debug.Log(gm.Puntos.ToString()); 
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        gm.Puntos = 24;
    }



}
