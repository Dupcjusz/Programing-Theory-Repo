using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Penguin : AnimalManager //INHERITANCE
{
    public override void DealPoint() //POLYMORPHISM
    {
        point -= 1;
    }
    void Update(){
        if(Animal == "penguin"){
            penguinMovement(); //ABSTRACTION
            DealPoint(); //ABSTRACTION
        }
    }
}