using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GuardarNombre : MonoBehaviour
{
    public TMP_InputField nombre;
    public TextMeshProUGUI texto01;
    public TextMeshProUGUI texto02;
    GameManager gm;
    sceneChangerClick cambiarEscena;

    private void Start()
    { 
        gm = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
        texto01.SetText("You have dethroned " + PlayerPrefs.GetString("potato").ToString() + ".");
        nombre.characterLimit = 10;
        cambiarEscena = GameObject.Find("Canvas").GetComponent<sceneChangerClick>();
    }
    private void FixedUpdate()
    {
        if (nombre.text.ToUpper() == PlayerPrefs.GetString("potato").ToString().ToUpper())
        {
            texto01.SetText("Ho ho, you again?");
            texto02.SetText("Well, Dear God, you know what to do.");
        }
        else
        {
            texto01.SetText("You have dethroned " + PlayerPrefs.GetString("potato").ToString() + ".");
            texto02.SetText("Now, you are the new god of Pamery.");
        }
    }

    public void Guardar()
    {
        if (nombre.text.Length > 0)
        {
            gm.BestoName = nombre.text;  
        }
        else
        {
            gm.BestoName = "Nameless God";
        }
        StartCoroutine(seteado());
        Debug.Log(PlayerPrefs.GetString("potato").ToString());
        cambiarEscena.irAEscena("Splash");
    } 
    IEnumerator seteado()
    {
        yield return new WaitForSeconds(0.2f);
        PlayerPrefs.SetString("potato", gm.BestoName);
    }
}
