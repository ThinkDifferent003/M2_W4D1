using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class Player
{
    public string nome;
    private int punteggio;

    public void IncrementaPunteggio(int newpunteggio)
    {
        punteggio = newpunteggio + punteggio;
    }
    public int GetPunteggio()
    {
        return punteggio;
    }
    public void SetPunteggio(int hp)
    {
        if (hp < 0)
        {
            punteggio = 0;
        }
        else
        {
            punteggio = hp;
        }

    }
    public bool IsVincitore()
    {
        if (punteggio >= 100)
        {
            return true;
        }
        return false;
    }

    public void AttaccaNemico(Enemy nemico, int danno)
    {
        nemico.SubisciDanno(danno);
        Debug.Log($" { nome } Danni inferti {danno}");
  
    }
}
   
