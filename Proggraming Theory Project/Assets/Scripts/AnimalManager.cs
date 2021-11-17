using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEngine.UI;
using TMPro;

public class AnimalManager : MonoBehaviour
{
    public static string aName { get; private set;} //ENCAPSULATION
    public static string Animal {get; private set;} //ENCAPSULATION
    public GameObject chicken;
    public GameObject cat;
    public GameObject penguin;
    public int point = 100;
    public TextMeshProUGUI nameText;

    //PlayerController
    public float movementSpeed = 3;
    public float jumpForce;
    public float timeBeforeNextJump = 1.2f;
    private float canJump = 0f;
    Rigidbody rb;

    void Awake(){
        aName = SetName.animalName;
        Animal = SetAnimal.animal;
    } 

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        nameText.text = aName;
    }

    void Update(){
        if(Animal == "chicken"){
            chicken.SetActive(true);
        }

        else if(Animal == "penguin"){
            penguin.SetActive(true);
        }

        else if(Animal == "cat"){
            cat.SetActive(true);
        }
    }

    public void chickenMovement(){
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        if (movement != Vector3.zero)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement), 0.15f);
        }

        transform.Translate(movement * movementSpeed * Time.deltaTime, Space.World);

        if (Input.GetKeyDown(KeyCode.Space) && Time.time > canJump)
        {
            rb.AddForce(0, jumpForce, 0, ForceMode.Impulse);
            canJump = Time.time + timeBeforeNextJump;
        }
    }

    public void catMovement(){
        jumpForce = 5;
        movementSpeed = 10;
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        if (movement != Vector3.zero)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement), 0.15f);
        }

        transform.Translate(movement * movementSpeed * Time.deltaTime, Space.World);

        if (Input.GetKeyDown(KeyCode.Space) && Time.time > canJump)
        {
            rb.AddForce(0, jumpForce + 2, 0, ForceMode.Impulse);
            canJump = Time.time + timeBeforeNextJump;
        }
    }
    public void penguinMovement(){
        jumpForce = 0;
        movementSpeed = 7;
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        if (movement != Vector3.zero)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement), 0.15f);
        }

        transform.Translate(movement * movementSpeed * Time.deltaTime, Space.World);

        if (Input.GetKeyDown(KeyCode.Space) && Time.time > canJump)
        {
            rb.AddForce(0, jumpForce + 2, 0, ForceMode.Impulse);
            canJump = Time.time + timeBeforeNextJump;
        }
    }

    public virtual void DealPoint(){ //POLYMORPHISM
        point -= 10;
    }
}



