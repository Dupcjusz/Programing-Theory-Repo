using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : AnimalManager //INHERITANCE
{
    public override void DealPoint() //POLYMORPHISM
    {
        point -= 1;
    }
    void Update(){
        if(Animal == "cat"){
            catMovement(); //ABSTRACTION
            DealPoint(); //ABSTRACTION
        }
    }
}
