using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro;using UnityEngine.UI;
using System.IO;
using UnityEngine;
using static listaJugadores;

public class mostrarRanking : MonoBehaviour
{
    private string filePath;
    //private Dictionary<string, jugadores> playerScores;
    public TMP_InputField txtNombre;
    public TMP_InputField txtCorreo;
    public TMP_InputField txtCelular;
    public TMP_InputField barraPunt;
    //private JugadoresList jugadoresLista = new JugadoresList();
    //public List<jugadores> jugadoresLista;
    //public string jsonFilePath = "Assets/Resources/jsonfile.json"; // Ajusta la ruta según sea necesario


    // Start is called before the first frame update
    void Start()
    {
        filePath = Application.persistentDataPath + "/userData.json";
        //jugadoresLista = new List<jugadores>();
        //string jsonData = JsonUtility.ToJson(new jugadores("jaime", 100, "15151", "a@gmail.com"));
        //playerScores = new Dictionary<string, jugadores>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void guardarInfoUser()
    {

        jugadores nuevoJugador = new jugadores {
            nombre = txtNombre.text,
            puntaje = int.Parse(barraPunt.text),
            celular = txtCorreo.text,
            correo = txtCorreo.text
        };

        /*if (jugadoresLista != null && jugadoresLista.jugadores != null)
        {
            jugadoresLista.jugadores.Add(nuevoJugador);
        }
        else
        {
            Debug.LogError("La lista de jugadores no está inicializada.");
        }

        //jugadoresLista.jugadores.Add(nuevoJugador);

        string jsonContent = JsonUtility.ToJson(jugadoresLista, true); // Formato bonito (pretty print)

        string filePath = Path.Combine(Application.persistentDataPath, "jugadores.json");

        File.WriteAllText(filePath, jsonContent);

        Debug.Log("Archivo JSON guardado en: " + filePath);
        /*string jsonData = JsonUtility.ToJson(new jugadores(txtNombre.text, int.Parse(barraPunt.text), txtCelular.text, txtCorreo.text));
        File.WriteAllText(filePath, jsonData);
        Debug.Log("Datos guardados en: " + filePath);
        Debug.Log("nombre: "+ txtNombre.text);*/

    }
    public void cargarInfoUser()
    {
        filePath = Path.Combine(Application.persistentDataPath, "jugadores.json");

        if (File.Exists(filePath))
        {
            // Leer el contenido del archivo JSON
            string jsonContent = File.ReadAllText(filePath);

            // Deserializar el JSON en una lista de jugadores
            JugadoresList playersList = JsonUtility.FromJson<JugadoresList>(jsonContent);

            // Utilizar los datos cargados
            if (File.Exists(filePath))
            {
                // Leer el contenido del archivo JSON
                 jsonContent = File.ReadAllText(filePath);

                // Deserializar el JSON en una lista de jugadores
                 playersList = JsonUtility.FromJson<JugadoresList>(jsonContent);

                // Validar el contenido deserializado
               /* if (playersList != null && playersList.jugadores != null)
                {
                    foreach (var jugador in playersList.jugadores)
                    {
                        if (jugador != null)
                        {
                            Debug.Log("Nombre: " + jugador.nombre);
                            Debug.Log("Puntaje: " + jugador.puntaje);
                        }
                        else
                        {
                            Debug.LogError("Jugador es null.");
                        }
                    }
                }
                else
                {
                    Debug.LogError("Error al deserializar el JSON o la lista de jugadores es null.");
                }*/
            }
            else
            {
                Debug.LogError("No se encuentra el archivo JSON en la ruta especificada.");
            }
            /*if (File.Exists(filePath))
            {
                // Leer el contenido del archivo JSON
                string jsonContent = File.ReadAllText(filePath);

                // Deserializar el JSON en un objeto PlayerData
                jugadores playerData = JsonUtility.FromJson<jugadores>(jsonContent);
                Debug.Log("Nombre: " + playerData.nombre);
                Debug.Log("Puntaje: " + playerData.puntaje);
            }
            else
            {
                Debug.LogError("No se encuentra el archivo JSON en la ruta especificada.");
            }*/
        }
    }
    /*void SaveUserData()
    {

        //playerScores.Add("User1", new jugadores(txtNombre.text,int.Parse(barraPunt.text),txtCelular.text,txtCorreo.text));
        string jsonData = JsonUtility.ToJson(new jugadores(txtNombre.text,int.Parse(barraPunt.text),txtCelular.text,txtCorreo.text);
        File.WriteAllText(filePath, jsonData);
        Debug.Log("Datos guardados en: " + filePath);
    }*
    /*public void ingresarPuntaje() //metodo que llama el onclick del boton "ingresar"
    {
        nombre = barraNombre.text;
        puntaje = int.Parse(barraPunt.text);
        playerScores.Add(nombre, puntaje);
        SaveUserData();
    }*/

    /*public void LoadUserData()
    {
        if (File.Exists(filePath))
        {
            string jsonData = File.ReadAllText(filePath);
            SerializableDictionary<string, int> loadedUsers = JsonUtility.FromJson<SerializableDictionary<string, int>>(jsonData);
            playerScores = new Dictionary<string, int>(loadedUsers.dictionary);
            Debug.Log("Datos cargados exitosamente.");
        }
        else
        {
            Debug.Log("No se encontró ningún archivo de datos.");
        }
    }

    public void mostrarRankingLog()
    {
        foreach (KeyValuePair<string, int> entry in playerScores)
        {
            Debug.Log("Nombre: " + entry.Key + ", Puntaje: " + entry.Value);
        }
    }*/
}
