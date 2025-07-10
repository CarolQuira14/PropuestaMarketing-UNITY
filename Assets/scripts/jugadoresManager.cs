using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using TMPro;
using UnityEngine;
using static listaJugadores;
using static UnityEditor.Experimental.GraphView.GraphView;

public class jugadoresManager : MonoBehaviour
{
    //string filePath;
    public TMP_InputField txtNombre;
    public TMP_InputField txtCorreo;
    public TMP_InputField txtCelular;

    public List<jugadores> listaJugadores;

    //private Dictionary<string, jugadores> DiccionarioJugadores = new Dictionary<string, jugadores>();

    // Start is called before the first frame update
    void Start()
    {
        listaJugadores = new List<jugadores>();
        //filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
    }

    public void noseQpasa() 
    {
        string Nombre = txtNombre.text;
        string Email = txtCorreo.text;
        string Celular = txtCelular.text;
        int Puntaje = GetComponentInParent<barra>().puntaje;

        AgregarJugador(Nombre,Email,Celular, Puntaje);
    }
    // M�todo para agregar un jugador al diccionario
    public void AgregarJugador(string nombre, string correo, string celular, int puntaje)
    {
        jugadores nuevoJugador = new jugadores
        {
            nombre = nombre,
            correo = correo,
            celular = celular,
            puntaje = puntaje,
        };
        listaJugadores.Add(nuevoJugador);
        // A�adir el jugador al diccionario
        Debug.Log(nuevoJugador.nombre + " Jugador agregado");
        Debug.Log(listaJugadores.Count);
    }

    

    

    /*public void mandarAJson ()
    {
        string jsonContent = JsonUtility.ToJson(new JugadoresList(DiccionarioJugadores), true); // Formato bonito (pretty print)
        string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "jugadores.json");

        File.WriteAllText(filePath, jsonContent);
        Debug.Log(DiccionarioJugadores.Count + "mandaraJson");
        Debug.Log("Archivo guardado en: " + filePath);
    }*/


    /*public void loadJson()
    {
        string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "jugadores.json");

        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            JugadoresList serializableDictionary = JsonUtility.FromJson<JugadoresList>(json);

            DiccionarioJugadores.Clear();
            for (int i = 0; i < serializableDictionary.keys.Count; i++)
            {
                DiccionarioJugadores.Add(serializableDictionary.keys[i], serializableDictionary.values[i]);
            }

            Debug.Log("Players loaded from " + path);

            string playerName = "joan"; // Este es el nombre o ID del jugador que quieres acceder

            if (DiccionarioJugadores.ContainsKey(playerName))
            {
                jugadores player = DiccionarioJugadores[playerName];
                Debug.Log("Player Name: " + player.name + ", Score: " + player.puntaje);
            }
            else
            {
                Debug.LogWarning("Player not found: " + playerName);
            }
        }
        else
        {
            Debug.LogWarning("No players file found at " + path);
        }
    }*/

    // M�todo para obtener un jugador del diccionario
    /*public jugadores ObtenerJugador(string nombre)
    {

        if (DiccionarioJugadores.TryGetValue(nombre, out jugadores jugador))
        {
            return jugador;
        }
        else
        {
            Debug.LogWarning("Jugador no encontrado: " + nombre);
            return null;
        }
     }*/

}
