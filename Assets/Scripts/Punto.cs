using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Punto : MonoBehaviour
{
    public GameObject pt;
    public TextMeshProUGUI texto;
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
        texto.SetText(gm.Puntos.ToString()); //Esta es la mala >:'v
        //Debug.Log(gm.Puntos.ToString()); // diosito ayuda :'v
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        gm.Puntos++;

    }



}
