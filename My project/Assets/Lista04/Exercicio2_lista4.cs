using UnityEngine;

public class Exercicio2_lista4 : MonoBehaviour
{
    [SerializeField] private int dano = 10;
    [SerializeField] private int vidajg = 100;
    
    void Start()
    {
       
    }

    
    void Update()
    {
        if (Input.anyKeyDown)
        {
            vidajg = vidajg - dano;
            print("jogador levou: " + dano + " de Dano, vida restante:" + vidajg);

            if (vidajg <= 50)

                print("cuidado!");                
        }
    }
}
