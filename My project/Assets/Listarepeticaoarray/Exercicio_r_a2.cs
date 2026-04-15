using UnityEngine;

public class Exercicio_r_a2 : MonoBehaviour
{
    [SerializeField] int[] numeros = new int[5] {1, 2, 3, 4, 5 };
    [SerializeField] int soma= 0; 

    void Start()
    {
        int i = 0;
        while (i < numeros.Length)
        {
            
            soma = soma + numeros[i];
            print(soma);
            i++;
        }
    }

    
    void Update()
    {
        
    }
}
