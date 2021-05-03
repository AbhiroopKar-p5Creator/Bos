using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delay : MonoBehaviour
{
    public Transform rotationGameObject;
    public Transform rotationCamera;
    
    public Transform target;
   
    void Start()
    {
    }


    void Update()
    {
        target = rotationCamera;
        target = rotationGameObject;
    }
}
