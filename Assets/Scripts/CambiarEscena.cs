using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarEscena : MonoBehaviour
{
    sceneChangerClick cambiador;

    //public GameObject pressSpace;

    // Start is called before the first frame update
    void Start()
    {
        cambiador = GetComponent<sceneChangerClick>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //pressSpace.GetComponent<RectTransform>().rect.width = pressSpace.GetComponent<RectTransform>().rect.width + 1;
            cambiador.irAEscena("Game");
        }
    }
}
