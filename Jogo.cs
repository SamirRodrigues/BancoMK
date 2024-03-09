using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogo : MonoBehaviour
{
    Personagem player = new Personagem("Samirzinho", 100, 75);
    Inimigo inimigo = new Inimigo("Lucifer", 100, 99);

    Personagem[] inimigos = new Personagem[10];
    // Start is called before the first frame update
    void Start()
    {
        //print(player.name);       
        
        player.SocaFofo(inimigo);        
        inimigo.SocaFofo(player);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
