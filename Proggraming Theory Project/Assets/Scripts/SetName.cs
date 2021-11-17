using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEngine.UI;

public class SetName : MonoBehaviour
{
    public InputField iField;
    public static string animalName { get; private set; } //ENCAPSULATION


    public void StartGame(){
        SceneManager.LoadScene(3);

        SetTheText(); //ABSTRACTION
    }

    public void SetTheText(){
        animalName = iField.text;
    }
}
