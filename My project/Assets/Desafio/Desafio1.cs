using UnityEngine;

public class Desafio1 : MonoBehaviour
{
    int jogadorA;
    int jogadorB;
    int pontosA;
    int pontosB;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.anyKeyDown)
        {
            jogadorA = Random.Range(0, 7);
            jogadorB = Random.Range(0, 7);

            print("dado de jogador A: " + jogadorA);
            print("dado do jogador B:" + jogadorB);
            if (jogadorA > jogadorB)
            {
                pontosA = pontosA + 1;
                print("ponto para jogador A, pontos atuais: " + pontosA); 
                
            }
            else if (jogadorB > jogadorA)
            {
                pontosB = pontosB + 1;
                print("ponto para jogador B, pontos atuais:" + pontosB);
                
            }
            else
            {
                print("empate.");
            }
            if (pontosA == 3)
            {
                print("jogador A ganhou");
            }
            else if (pontosB == 3)
            {
                print("jogador B venceu");
            }
                
        }

    }
}
