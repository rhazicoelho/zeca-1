using UnityEngine;

public class Exercicio3_lista4 : MonoBehaviour
{
    [SerializeField] private int numeropontos = 0;
    void Start()
    {
        
    }

   
    void Update()
    {
        if (Input.anyKeyDown)
        {
            numeropontos = numeropontos + 10;
            print("ganhou 10 pontos e agora tem:" + numeropontos + " pontos.");
            if (numeropontos >= 100)
            {
                print("você venceu!");
            }
        }
    }
}
