using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlplayer : MonoBehaviour
{
    private Vector2 input;
    private Animator controleAnimacao;
    float agachar;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        controleAnimacao = GetComponent<Animator>();
    }

    
    void Update()
    {
        input.x = Input.GetAxis("Horizontal");
        input.y = Input.GetAxis("Vertical");

        controleAnimacao.SetFloat("inputX", input.x);
        controleAnimacao.SetFloat("inputY", input.y);

        if (Input.GetKeyDown(KeyCode.C))
        {
            agachar = 1;
            
        }

        if (Input.GetKeyUp(KeyCode.C))
        {
            agachar = 0;
        }
        controleAnimacao.SetFloat("agachar", agachar);
    }
}
