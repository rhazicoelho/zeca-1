using UnityEngine;

public class Exercicio4_lista3 : MonoBehaviour
{
    [SerializeField] private int numeroA;
    [SerializeField] private int numeroB;
    void Start()
    {
        if (numeroA == numeroB)
        {
            print("numeros são iguais.");
        }
        else
        {
            print("numeros são diferentes.");
        }
    }

    
    void Update()
    {
        
    }
}
