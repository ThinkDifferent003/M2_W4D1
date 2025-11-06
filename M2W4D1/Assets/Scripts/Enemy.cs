using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy
{
    public string nome;
    public int salute;
    public int livello;

    public void SubisciDanno(int danno)
    {
        salute = salute - danno;
        if (salute <= 0)
        {
            salute = 0;
            
        }
        Debug.Log($"Danni ricevuti {danno}");
     
        
    }
    
}
