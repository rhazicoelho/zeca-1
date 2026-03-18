using UnityEngine;

public class Exercicio1_lista3 : MonoBehaviour
{
    [SerializeField] private int numeroA;
    [SerializeField] private int numeroB;
    void Start()
    {
        if (numeroA > numeroB)
        {
            print("primeiro numero é maior.");
        }
        else
        {
            print("segundo numero é maior");
        }


    }

    
    void Update()
    {
        
    }
}
