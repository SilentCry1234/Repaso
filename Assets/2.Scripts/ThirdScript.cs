using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdScript : MonoBehaviour
{
    int numero;
    float numeroFloat; 

    void Start()
    {
        Enemy enemy1 = new Enemy();

        enemy1.vida = 5;
        
        enemy1.MeleeAttack();

        /////////

        FlyingEnemy flyingEnemy1= new FlyingEnemy();
        
        flyingEnemy1.FlyingAttack();

        //PlayerPrefs.SetInt("NumeroInt", 4);
        //PlayerPrefs.SetFloat("NumeroFloat", 7.5f);
        
        //StartCoroutine(Coroutine(3.5f)); 
        //Invoke("Disparar", 3);
        
        //numero = PlayerPrefs.GetInt("NumeroInt");
        //numeroFloat = PlayerPrefs.GetFloat("NumeroFloat"); 
    }

    private void Update()
    {

        //Debug.Log(numero);
        //Debug.Log(numeroFloat);

    }
    void GuardarInfo()
    {
        // vidas, puntos, nombres de skins
        //PlayerPrefs.Set...
    }

    void CargarInfo()
    {
        //Carga las cosas
        //... = PlayerPrefs.Get...
        
    }

    //void Disparar()
    //{
    //    Debug.Log("Disparo"); 
    //}


    //IEnumerator Coroutine (float time)
    //{
    //    Debug.Log("Hola");

    //    yield return new WaitForSeconds(time);

    //    Debug.Log("Buenos Dias");

    //    yield return new WaitForSeconds(time);

    //    Debug.Log("Hasta Luego");


    //    StartCoroutine(Coroutine(3));

    //}

    class Enemy
    {
        public int vida;

        public float attack;

        public string nombre;

        public void MeleeAttack() 
        {
            Debug.Log("MeleeAttack"); 
        }
    }

    class FlyingEnemy : Enemy
    {
        public void FlyingAttack()
        {
            Debug.Log("FLyingAttack");
        }
    }
}
