using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    Personagem personagemAtual;

    public Personagem personagem1;

    public Personagem personagem2;

    void Start()
    {
        personagemAtual = personagem1;
        personagem1.ativo = true;
        personagem2.ativo = false;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1)) EscolherPersonagem1();
        if (Input.GetKey(KeyCode.Alpha2)) EscolherPersonagem2();
        SeguirPersonagem();
    }

    void EscolherPersonagem1()
    {
        personagemAtual = personagem1;
        personagem1.ativo = true;
        personagem2.ativo = false;
    }

    void EscolherPersonagem2()
    {
        personagemAtual = personagem2;
        personagem1.ativo = false;
        personagem2.ativo = true;
    }

    void SeguirPersonagem()
    {
        transform.position =
            new Vector3(personagemAtual.transform.position.x,
                personagemAtual.transform.position.y + 2.7f,
                -10);
    }
}
