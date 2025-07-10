using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rankingMostrar : MonoBehaviour
{
    public TMPro.TMP_Text puntaje1, puntaje2, puntaje3, puntaje4;
    // Start is called before the first frame update
    public jugadoresManager manager;
    public List<jugadores> listaJugadoresRanking;

    void Start()
    {
        listaJugadoresRanking = new List<jugadores>();
        
        listaJugadoresRanking = manager.listaJugadores;
        
    }

    private void Update()
    {
        mostrarJugador();
    }
    public void mostrarJugador()
    {
        
        listaJugadoresRanking.Sort((a, b) => b.puntaje.CompareTo(a.puntaje));
       
        if (listaJugadoresRanking.Count > 0)
            puntaje1.text = $" {listaJugadoresRanking[0].nombre} - {listaJugadoresRanking[0].puntaje} puntos";
        if (listaJugadoresRanking.Count > 1)
            puntaje2.text = $" {listaJugadoresRanking[1].nombre} - {listaJugadoresRanking[1].puntaje} puntos";

        if (listaJugadoresRanking.Count > 2)
            puntaje3.text = $" {listaJugadoresRanking[2].nombre} - {listaJugadoresRanking[2].puntaje} puntos";

        if (listaJugadoresRanking.Count > 3)
            puntaje4.text = $" {listaJugadoresRanking[2].nombre} - {listaJugadoresRanking[2].puntaje} puntos";

        /*foreach (jugadores Jugador in listaJugadoresRanking)
        {

            string nombreRanking = Jugador.nombre;
            int puntajeRanking = Jugador.puntaje;
            Debug.Log("Nombre: " + nombreRanking + "Puntaje" + puntajeRanking);
        }*/
        /*listaJugadoresRanking.Sort((a, b) => b.puntaje.CompareTo(a.puntaje));
        for (int i = 0; i >= 4; i++) 
        {
            listaPuntajeStr[i].text = listaJugadoresRanking[i].name;   
        }*/
    }
}
