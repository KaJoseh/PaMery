using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
/*
public class DataController : MonoBehaviour
{
    private string gameDataFileName = "data.json";

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);

        LoadGameData();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void LoadGameData()
    {
        // Path.Combine combines strings into a file path
        // Application.StreamingAssets points to Assets/StreamingAssets in the Editor, and the StreamingAssets folder in a build
        string filePath = Path.Combine(Application.streamingAssetsPath, gameDataFileName);

        if (File.Exists(filePath))
        {
            // Read the json from the file into a string
            string dataAsJson = File.ReadAllText(filePath);
            // Pass the json to JsonUtility, and tell it to create a GameData object from it
            //GameData loadedData = JsonUtility.FromJson<GameData>(dataAsJson);

            // Retrieve the allRoundData property of loadedData
            //allRoundData = loadedData.allRoundData;
        }
        else
        {
            Debug.LogError("Cannot load game data!");
        }
    }
    private void LoadPlayerProgress()
    {
        // Create a new PlayerProgress object
        mejorPuntaje = new MejorPuntaje();

        // If PlayerPrefs contains a key called "highestScore", set the value of playerProgress.highestScore using the value associated with that key
        if (PlayerPrefs.HasKey("highestScore"))
        {
            MejorPuntaje. = PlayerPrefs.GetInt("highestScore");
        }
    }

} */
