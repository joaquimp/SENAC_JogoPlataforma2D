using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abelha : Personagem
{
    public float velocidadeVertical;

    void Update()
    {
        // Vem antes do if para o personagem poder fazer
        // update de alguma acao, mesmo que o personagem
        // esteja desativado
        base.Update();

        // Para a execução se o personagem estiver desativado
        if (!ativo) return;
        if (Input.GetKey(KeyCode.UpArrow)) Voar();
        if (Input.GetKey(KeyCode.DownArrow)) Descer();
    }

    public void Voar()
    {
        rb.velocity = new Vector2(rb.velocity.x, velocidadeVertical);
    }

    public void Descer()
    {
        rb.velocity = new Vector2(rb.velocity.x, -velocidadeVertical);
    }
}
