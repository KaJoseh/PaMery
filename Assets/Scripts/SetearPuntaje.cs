using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetearPuntaje : MonoBehaviour
{
    GameManager gm;
    TextMeshProUGUI puntuacion;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
        puntuacion = GameObject.FindGameObjectWithTag("score").GetComponent<TextMeshProUGUI>();
        puntuacion.SetText(PlayerPrefs.GetInt("patata").ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
