using UnityEngine;

public class Exercicio10 : MonoBehaviour
{
    [SerializeField] private float salario = 1000f;
    void Start()
    {
        print(salario + (salario * 0.10f));
    }

    
    void Update()
    {
        
    }
}
