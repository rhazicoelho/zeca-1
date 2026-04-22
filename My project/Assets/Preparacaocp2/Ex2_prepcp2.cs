using UnityEditor.Experimental.GraphView;
using UnityEditor.UIElements;
using UnityEngine;

public class Ex2_prepcp2 : MonoBehaviour
{
    string[] nomes = new string[] {"joão", "roberto", "douglas", "laura", "marcio"};
   
    void Start()
    {
        
    }

     
    void Update()
    {

        if (Input.anyKeyDown)
        {
            foreach (var ns in nomes)
            {
                
                print(ns.ToUpper());

            }
        }
    }
}
