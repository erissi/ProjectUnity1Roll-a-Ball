using System.Collections;
using UnityEngine;

[ExecuteInEditMode]
public class Processamento : MonoBehaviour
{

	// Use this for initialization
    public Material mat;
    void OnRenderImage(RenderTexture src, RenderTexture dest)
    {
        Graphics.Blit(src, dest, mat);
    }
    
	
}
