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
        Enemy nemico1 = new Enemy();
        nemico1.nome = "Ratto";
        nemico1.salute = 10;


        Player personaggio1 = new Player();
        personaggio1.nome = "Micio";
        personaggio1.SetPunteggio(7);
        Debug.Log($"Ciao sono {personaggio1.nome} ed ho {personaggio1.GetPunteggio()} vite");


        Player personaggio2 = new Player();
        personaggio2.nome = "Cane";
        personaggio2.SetPunteggio(1);
        Debug.Log($"Ciao sono {personaggio2.nome} ed ho solo {personaggio2.GetPunteggio()} vita..");

        personaggio1.IncrementaPunteggio(99);
        Debug.Log($"Ora ho {personaggio1.GetPunteggio()} vite ");
        personaggio2.IncrementaPunteggio(1);
        Debug.Log($"Io invece ho {personaggio2.GetPunteggio()} vite ora");

        if (personaggio1.IsVincitore())
        {
            Debug.Log($"{personaggio1.nome} vincitore");
        }

        personaggio1.AttaccaNemico(nemico1, 10);
 
            

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
