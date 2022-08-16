using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movimentocamera : MonoBehaviour
{
    public float velocidadeCamera;
    private Camera cameraPrincial;
    private float cameraY;
    public float vidaInicial;
    public float vidaAtual;
    public float porcentVida;
    public Image imgVida;


    void Start()
    {
        cameraPrincial = Camera.main;
        vidaAtual = vidaInicial;
    }

    private void FixedUpdate() {
        cameraY = cameraPrincial.transform.rotation.eulerAngles.y;
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0f, cameraY, 0f), velocidadeCamera * Time.fixedDeltaTime);
    }
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "vida")
        {
            vidaAtual -= 1;
            porcentVida = vidaAtual / vidaInicial;
            imgVida.fillAmount = porcentVida;
        }

        if (other.gameObject.tag == "ganharVida")
        {
            vidaAtual = vidaInicial;
            porcentVida = vidaAtual / vidaInicial;
            imgVida.fillAmount = porcentVida;
        }
    }
}
