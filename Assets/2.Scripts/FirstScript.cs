using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    // Operadores Logicos 
    //    &&  And
    //    ||  Or
    //    !   Not
    // for (int i = 0; i< 10; i++)

    //int[] array = {2, 5, 7, 0}; 
    List<int> numerosEnteros = new List<int>();
    List<float> numerosFlotantes = new List<float>();

    List<string> nombres = new List<string>();
    string frase = "Me gustan los Videojuegos";

    int[] numeros = { 0, 2, 4, 5, 6, 9 }; 

    private void Start()
    {
     
        //for (int i = 0; i < array.Length; i++)
        //{
        //    Debug.Log(array[i]);
        //}
        numerosEnteros.Add(0);
        numerosEnteros.Add(1); 
        numerosEnteros.Add(2);

        numerosEnteros.Insert(3, 5);



        //foreach (int numero in numerosEnteros)
        //{
        //    Debug.Log(numero);
        //}

        //foreach (char character in frase)
        //{
        //    Debug.Log(character);
        //}

        foreach(int numero in numeros)
        {
            Debug.Log(numero);  
        }
    }



}
