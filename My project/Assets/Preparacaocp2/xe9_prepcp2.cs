using UnityEngine;

public class xe9_prepcp2 : MonoBehaviour
{
    [SerializeField] int[] fases = new int[] { 50, 100, 30, 80, 150 };

    
    void Start()
    {
       
    }

    
    void Update()
    {
        if (Input.anyKeyDown)
        {
            int totalpontos = 0;

            for (int i = 0; i < fases.Length; i++)
            {
                totalpontos += fases[i];
            }

            if (totalpontos == 500)
            {
                print("jogador passou de nível");
            }
            else
            {
                print("tente de novo");
            }
        }
    }
}
