using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public void Cargar1Jugador()
    {
        SceneManager.LoadScene("1jugador");
    }
    public void Cargar2Jugadores()
    {
        SceneManager.LoadScene("2jugadores");
    }
}   
