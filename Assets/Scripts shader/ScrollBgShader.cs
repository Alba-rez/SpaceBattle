using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBgShader : MonoBehaviour
{
    [SerializeField] float speed;
    Renderer render;
void Start()
    {
        render = GetComponent<Renderer>();
        
    }

   
    void Update()
    {
        Vector2 offset = Vector2.up * speed * Time.time;
        render.material.mainTextureOffset = offset;
    }
}
