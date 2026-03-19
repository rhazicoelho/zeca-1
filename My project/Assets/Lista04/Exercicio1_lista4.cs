using UnityEngine;

public class Exercicio1_lista4 : MonoBehaviour
{
    [SerializeField] private int vidajogador;
    void Start()
    {
        if (vidajogador == 0)
        {
            print("sem vida restante, GAME OVER.");
        }
        else
        {
            print("vida do jogador: " + vidajogador);
        }
    }

    
    void Update()
    {
        
    }
}
