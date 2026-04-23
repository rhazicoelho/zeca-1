using UnityEngine;

public class Ex8_prepcp2 : MonoBehaviour
{
    [SerializeField] private string senhasecreta;
    private string senhacorreta;
    bool achousenha;

    void Start()
    {
        
        print("use a palavra magíca para entrar");
    }

    
    void Update()
    {
        
        
        
        if (Input.anyKeyDown && achousenha == false)
        {
            

            if (senhasecreta == "dragao123")
            {
                print(senhacorreta.Substring(0, 6) + "portal liberado");
                achousenha = true;
            }
            else
            {
                print("senha incorreta, tente novamente");
            }
        }
    }
}
