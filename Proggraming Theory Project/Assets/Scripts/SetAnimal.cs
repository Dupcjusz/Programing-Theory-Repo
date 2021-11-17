using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEngine.UI;

public class SetAnimal : MonoBehaviour
{
    public static string animal { get; private set; } //ENCAPSULATION

    public void penguin(){
        animal = "penguin";
        SceneManager.LoadScene(2);
    }

    public void cat(){
        animal = "cat";
        SceneManager.LoadScene(2);
    }

    public void chicken(){
        animal = "chicken";
        SceneManager.LoadScene(2);
    }
}
