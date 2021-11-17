using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : AnimalManager //INHERITANCE
{
    public override void DealPoint() //POLYMORPHISM
    {
        point -= 1;
    }
    void Update(){
        if(Animal == "chicken"){
            chickenMovement(); //ABSTRACTION
            DealPoint(); //ABSTRACTION
        }
    }
}
