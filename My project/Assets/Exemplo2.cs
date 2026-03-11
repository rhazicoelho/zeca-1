using UnityEngine;

public class Exemplo2 : MonoBehaviour
{
    [SerializeField] private string nomefuncionario = "alex";
    [SerializeField] private float numerohora = 8;
    [SerializeField] private float totaldinheiro = 1200;

    void Start()
    {
        print(nomefuncionario + " ganhou dinheiro total no fim do dia: " + (numerohora * totaldinheiro));


    }

    
    void Update()
    {
        
    }
}
