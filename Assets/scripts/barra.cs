using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class barra : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Panel;
    public TMP_Text puntos;
    public Animator anim;
    public bool termino;
    public int puntaje;
    public List<int> valor;
    public bool botonPulsado;
    public int numActual;
    private float temporizador = 0f;  // Temporizador para controlar el intervalo
    private int indiceActual = 0;  // �ndice actual en la lista
    public float intervalo; // Tiempo en segundos entre cada iteraci�n
    public Image imagenCarga;

    void Start()
    {
        botonPulsado=true;
        Panel.SetActive(false);
        valor = new List<int>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (botonPulsado)
        {   
            temporizador += Time.deltaTime;

            if (temporizador >= intervalo)
            {
                // Procesar el n�mero actual en la lista
                if (indiceActual < valor.Count)
                {
                    numActual = valor[indiceActual];
                    //Debug.Log($"Este es el valor de numActual: {numActual}");
                    //Debug.Log($"Este es el indiceActual: {indiceActual}");

                    // Avanzar al siguiente �ndice
                    imagenCarga.fillAmount = numActual / 10f;
                    indiceActual++;
                    //mostrarNumeroSel(numActual);
                }

                // Reiniciar el temporizador
                temporizador = 0f;
                if (indiceActual >= valor.Count)
                {
                    indiceActual = 0;  // Reiniciar el �ndice si deseas que comience de nuevo en el pr�ximo bot�n pulsado
                }
            }
        }

    }
    public void mostrarNumeroSel()
    {
        //float division= imagenCarga.fillAmount = numActual/10f;
        //Debug.Log("Division=" + division);
        Debug.Log("Numero escogido: " + valor[indiceActual]);
    }
    public void cambiarAFalse()
    {
        numActual = valor[indiceActual];
        puntaje = numActual * 100;
        botonPulsado = false;
        anim.SetBool("Termino", true);

        puntos.text = puntaje.ToString() + " puntos";
        Panel.SetActive(true);

        //return botonPulsado;
    }
    public void cambiarATrue() 
    { 
        botonPulsado=true;
    }
    public void darValores()
    {
        for (int i = 1; i <= 10; i++)
        {
            valor.Add(i);
        }
        Debug.Log(valor.Count + "Valor total");
    }

    public void ReiniciarJuego()
    {
        botonPulsado = true;
    }


}
