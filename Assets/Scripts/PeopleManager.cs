using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleManager : MonoBehaviour
{
    public GameObject people;
    public float value;
    public Vector3 sizeChange;

    public void MoveLeft(){
        value = value - 0.1f;
        people.transform.position = new Vector3(value+0.902f, 0.0649f, -23.713f);
    }
    public void MoveRight(){
        value = value + 0.1f;
        people.transform.position = new Vector3(value+0.902f, 0.0649f, -23.713f);
    }
    
    public void RotateLeft(){
        people.transform.Rotate(0f,20f,0f);
    }
    public void RotateRight(){
        people.transform.Rotate(0f,-20f,0f);
    }

    public void Gorw(){
        people.transform.localScale = people.transform.localScale + sizeChange;
    }
    public void lessen(){
        people.transform.localScale = people.transform.localScale - sizeChange;
        }
    public void Reset(){
        people.transform.position = new Vector3(0.902f, 0.0649f, -23.713f);
        people.transform.rotation = Quaternion.Euler(new Vector3(0,0,0));
        people.transform.localScale = new Vector3(1,1,1);
    }
}
