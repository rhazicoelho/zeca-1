using UnityEngine;

public class Exercicio2_lista3 : MonoBehaviour
{
    [SerializeField] private int idade;
    void Start()
    {
        if (idade >= 18)
        {
            print("pode acessar site.");
        }
        else
        {
            print("não pode acessar site.");
        }
    }

    
    void Update()
    {
        
    }
}
