using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColMat : MonoBehaviour
{

    public MeshRenderer[] renderers;
    
    // Start is called before the first frame update
    void Start()
    {
        Color newColour = Random.ColorHSV();
        ApplyMaterial(newColour,0);
    }

    // Update is called once per frame
   public void ApplyMaterial(Color colour, int targetMatIndex)
    {
       Material genMat = new Material(Shader.Find("Standard"));
       genMat.SetColor("_Color", colour);

       for (int i = 0; i < renderers.Length; i++)
       {
           renderers[i].material = genMat;
       }
    }
}
