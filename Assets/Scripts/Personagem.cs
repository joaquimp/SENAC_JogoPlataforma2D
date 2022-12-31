using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour
{
  public float velocidade;
  protected Rigidbody2D rb;
  protected Animator animator;
  protected bool faceDireita = true;
  public bool ativo = true;

  protected void Start()
  {
    rb = GetComponent<Rigidbody2D>();
    animator = GetComponent<Animator>();
  }

  protected void Update()
  {
    animator.SetFloat("velocidade", System.Math.Abs(rb.velocity.x));

    //Para a execução se o personagem estiver desativado
    if (!ativo) return;
    if (Input.GetKey(KeyCode.RightArrow)) MoverDireita();
    if (Input.GetKey(KeyCode.LeftArrow)) MoverEsquerda();
    Virar();
  }

  void MoverDireita()
  {
    rb.velocity = new Vector2(velocidade, rb.velocity.y);
    faceDireita = true;
  }

  void MoverEsquerda()
  {
    rb.velocity = new Vector2(-velocidade, rb.velocity.y);
    faceDireita = false;
  }

  void Virar()
  {
    if (faceDireita)
    {
      this.transform.localScale = new Vector3(1, 1, 1);
    }
    else
    {
      this.transform.localScale = new Vector3(-1, 1, 1);
    }
  }
}
