using UnityEngine;

public class Exercicio4_lista4 : MonoBehaviour
{
    [SerializeField] private int velocidade = 5;
    void Start()
    {
        if (velocidade > 10)
        {
            print("muito rapido!");
        }
        else if (velocidade <= 10)
        {
            print("velocidade normal");
        }
    }

    
    void Update()
    {
        
    }
}
