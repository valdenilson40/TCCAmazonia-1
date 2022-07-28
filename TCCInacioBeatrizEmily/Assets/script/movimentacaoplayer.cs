using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentacaoplayer : MonoBehaviour
{
    private Vector2 input;
    private Animator animacao;
    
    void Start()
    {
        animacao = GetComponent<Animator>();

    }

    
    void Update()
    {
        input.x = Input.GetAxis("Horizontal");
        input.y = Input.GetAxis("Vertical");
        animacao.SetFloat("inputX", input.x);
        animacao.SetFloat("inputY", input.y);
    }
}
