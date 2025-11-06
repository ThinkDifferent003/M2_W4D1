using System.Collections;
using System.Collections.Generic;
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
    public int SetPunteggio(int  punteggio)
    {
        if (punteggio < 0)
        {
            punteggio = 0;
        }
        return punteggio;
    }
    bool IsVincitore(int punteggio)
    {
        if ( punteggio >= 100)
        {
            return true;
        }
        return false;
    }
}
