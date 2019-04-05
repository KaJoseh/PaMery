using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetearNombre : MonoBehaviour
{
    public TextMeshProUGUI nombreTexto;

    public void setName()
    {
        nombreTexto.SetText(PlayerPrefs.GetString("potato").ToString());
    }

}
