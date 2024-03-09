
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : Personagem
{
    public Inimigo(string _name, int _hp, int _power) : base(_name, _hp, _power)
    {
        
    }

    public new void SocaFofo(Personagem alvo)
    {
        // Aplicar pouco dano, soco fofinho, amavel e de bom coração. Um carinho.
        alvo.hp -= power;
        Debug.Log(string.Format("{1} HP {0}", alvo.hp, alvo.name));
    }
}
