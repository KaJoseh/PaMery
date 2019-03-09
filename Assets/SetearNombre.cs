using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetearNombre : MonoBehaviour
{
    GameManager gm;
    public TextMeshProUGUI nombre;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
        nombre.SetText(PlayerPrefs.GetInt("patata").ToString());
    }

    // Update is called once per frame
    void Update()
    {

    }
}
