using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetearPuntaje : MonoBehaviour
{
    public TextMeshProUGUI puntuacion;

    public void setScore()
    {
        puntuacion.SetText(PlayerPrefs.GetInt("patata").ToString());
    }
}
