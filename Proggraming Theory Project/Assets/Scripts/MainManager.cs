using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEngine.UI;

public class MainManager : MonoBehaviour
{
    private string animalName;
    private string animal;

    void Start(){
        animalName = SetName.animalName;
        animal = SetAnimal.animal;

    }
}
