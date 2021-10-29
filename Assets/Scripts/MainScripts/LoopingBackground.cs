using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopingBackground : MonoBehaviour
{
    public float bgSpeed;
    public Renderer backgroundRenderer;

    // Update is called once per frame
    void Update()
    {
        backgroundRenderer.material.mainTextureOffset += new Vector2(bgSpeed * Time.deltaTime, 0f);
    }
}
