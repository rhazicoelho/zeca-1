using UnityEngine;

public class Exlistalivre_3 : MonoBehaviour
{
    private int loot ;
    void Start()
    {
        
    }

    
    void Update()
    {

        int numerodeloot;
        int totaldeloot = 0;
        if (Input.anyKeyDown)
        {
            
            for (int i = 0; i < 8; i++)
            {
                numerodeloot = Random.Range(0, 11);
                totaldeloot = numerodeloot + totaldeloot;
            }
            print("jogador tem: " + totaldeloot);
        }
        
        
    }
}
