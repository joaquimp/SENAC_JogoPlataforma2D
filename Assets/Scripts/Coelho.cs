using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coelho : Personagem
{
  public float alturaPulo;

  // Update is called once per frame
  void Update()
  {
    // Vem antes do if para o personagem poder fazer
    // update de alguma acao, mesmo que o personagem
    // esteja desativado
    base.Update();

    //Para a execução se o personagem estiver desativado
    if (!ativo) return;
    if (Input.GetKeyDown(KeyCode.Space)) Pular();
  }

  void Pular()
  {
    rb.velocity = new Vector2(rb.velocity.x, alturaPulo);
  }
}
