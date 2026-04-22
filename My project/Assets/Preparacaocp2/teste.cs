using UnityEngine;

public class teste : MonoBehaviour
{
    [SerializeField] string inicial;

    string[] nomes = new string[] { "Fabio", "Maria", "Jose", "Juca" };

    void Start()
    {
        foreach (string nome in nomes)
        {
            if (nome.Substring(0, 1).ToUpper() == inicial.ToUpper())
            {
                print(nome);
            }
        }
    }
}
