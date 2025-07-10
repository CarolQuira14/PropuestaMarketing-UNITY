using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musica : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource AudioSource;
    public bool sonando = false;
    public void Start()
    {
        AudioSource = GetComponent<AudioSource>();
    }
    public void sonar() 
    {
        if (AudioSource != null) 
        {
            if (!sonando) 
            {
                AudioSource.Play();
                sonando=true;
            }else
            {
                AudioSource.Stop();
                sonando = false;
            }
        }
        
    }
}
