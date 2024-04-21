using UnityEngine;
using UnityEngine.UI;
using System.IO;
using TMPro;

public class NameCaptureHandler : MonoBehaviour
{
    public TMP_InputField nameInputField;
    private float bestTime;

    // Attach this method to the "On Name Captured" event in the Unity Editor
    public void OnNameCaptured()
    {
        // Retrieve the player's name from the input field
        string playerName = nameInputField.text;

        // Retrieve the player's best time from wherever it's stored
        bestTime = // Get the player's best time from wherever it's stored;

            // Write the player's name and best time to a text file
            SavePlayerData(playerName, bestTime);
    }

    private void SavePlayerData(string playerName, float bestTime)
    {
        // Construct the file path to the text file in the "Resources" folder
        string filePath = Application.dataPath + "/Resources/PlayerData.txt";

        // Create a string with the player's name and best time
        string playerData = playerName + "," + bestTime.ToString();

        // Write the player data to the text file
        File.WriteAllText(filePath, playerData);

        Debug.Log("Player data saved to: " + filePath);
    }
}