using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEngine.UI;

public class SetName : MonoBehaviour
{
    public InputField inputField;
    public static string animalName { get; set; }


    public void StartGame(){
        SceneManager.LoadScene(3);

        SetTheText();
    }

    public void SetTheText(){
        animalName = inputField.text;
    }
}
