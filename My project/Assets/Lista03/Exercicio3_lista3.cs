using UnityEngine;

public class Exercicio3_lista3 : MonoBehaviour
{
    [SerializeField] private int numero;
    [SerializeField] private int resposta;
     void Start()
    {
        if (numero % 2 == 0) 
        {
            print("numero par.");
        }
        else
        {
            print("numero impar.");
        }
    }

    
    void Update()
    {
        
    }
}
