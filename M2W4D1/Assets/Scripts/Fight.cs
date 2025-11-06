using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Fight : MonoBehaviour
{
    [SerializeField] private int punteggio;
    // Start is called before the first frame update
    void Start()
    {
        Player personaggio1 = new Player();
        personaggio1.nome = "Micio";
        personaggio1.SetPunteggio(punteggio);
        Debug.Log($"Ciao sono {personaggio1.nome} ed ho {personaggio1.GetPunteggio()} vite");
        
        
        //Player personaggio2 = new Player();
        //personaggio2.nome = "Cane";
        //personaggio2.punteggio = 1;
        //Debug.Log($"Ciao sono {personaggio2.nome} ed ho solo {personaggio2.punteggio} vita..");

        //personaggio1.IncrementaPunteggio(2);
        //Debug.Log($"Ora ho {personaggio1.punteggio} vite ");
        //personaggio2.IncrementaPunteggio(1);
        //Debug.Log($"Io invece ho {personaggio2.punteggio} vite ora");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
