using UnityEngine;

public class Exercicio13 : MonoBehaviour
{
    [SerializeField] private int inimigopequeno = 10;
    [SerializeField] private int inimigomedio = 25;
    [SerializeField] private int chefe = 100;
     
    void Start()
    {
        print("pontos de inimigos pequenos= " + (inimigopequeno * 3));
        print ("pontos de inimigos médios= " + (inimigomedio * 2));
        print("pontos de chefão= " + (chefe));
        print("total de pontos=" + (inimigopequeno * 3 + inimigomedio * 2 + chefe));




    }

    
    void Update()
    {
        
    }
}
