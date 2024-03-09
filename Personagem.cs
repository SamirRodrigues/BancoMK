using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem 
{
    public string name;
    public int hp;
    public int power;    

    public Personagem(string _name, int _hp, int _power) 
    {    
        name = _name;
        hp = _hp;
        power = _power;
    }

    public Personagem() { }

    public void SocaFofo(Personagem alvo)
    {
        // Aplicar pouco dano, soco fofinho, amavel e de bom coração. Um carinho.
        alvo.hp -= 1;
        Debug.Log(string.Format("{1} HP {0}", alvo.hp, alvo.name));
    }
}
