using UnityEngine;

public class Exlistalivre_2 : MonoBehaviour
{
   
    void Start()
    {
        string nome = "Leandro";
        string primeiraletra = nome.Substring(0, 1).ToUpper();
        string restonome = nome.Substring(1).ToLower();
        print(primeiraletra + restonome);
    }

    
    void Update()
    {
        
    }
}
