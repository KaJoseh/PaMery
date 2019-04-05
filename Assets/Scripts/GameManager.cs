using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;


    private int bestoPuntos;
    public int BestoPuntos
    {
        get
        {
            return bestoPuntos;
        }

        set
        {
            bestoPuntos = value; 
        }
    }
    
    private string bestoName;
    public string BestoName
    {
        get
        {
            return bestoName;
        }

        set
        {
            bestoName = value;
        }
    }

    // 0 Antes 1 Durante 2 Despues
    private int jugando = 0;
    public int Jugando
    {
        get
        {
            return jugando;
        }
        set
        {
            jugando = value;
        }
    }

    private int puntos;
    public int Puntos
    {
        get
        {
            return puntos;
        }

        set
        {
            puntos = value;
        }
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }
    

}

