using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cambiodeescena : MonoBehaviour
{
    // Start is called before the first frame update
    public string escena;
    public void cambioDeEscena(string escena)
    {
        SceneManager.LoadScene(escena);
    }
    // Update is called once per frame
}
