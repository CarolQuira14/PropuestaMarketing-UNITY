using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class listaJugadores : MonoBehaviour
{
    [System.Serializable]
    public class JugadoresList
    {
        public List<string> keys = new List<string>();
        public List<jugadores> values= new List<jugadores>();

        public JugadoresList(Dictionary<string, jugadores> dictionary)
        {
            foreach (KeyValuePair<string,jugadores> kvp in dictionary)
            {
                keys.Add(kvp.Key);
                values.Add(kvp.Value);
            }
        }
    }// Start is called before the first frame update
}
