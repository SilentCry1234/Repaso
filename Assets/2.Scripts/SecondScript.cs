using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondScript : MonoBehaviour
{
    public float a = 1, b = 2; 

    void Start()
    {
        Sumar(); 
    }

    private void Sumar()
    {
        float suma = a + b;
        Debug.Log(suma);    
    }

}
