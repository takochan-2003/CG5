using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostEffectAttacher : MonoBehaviour
{

    public Shader shader;
    private Material material;

    private void Awake()
    {
        material = new Material(shader);
    }

    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, material);
    }

}
