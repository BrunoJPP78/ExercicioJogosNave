using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoController : MonoBehaviour
{
    [SerializeField]
    private float _speed = -8f;

    private Rigidbody2D _rb2d;

    private void Start()
    {
        _rb2d = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _rb2d.MovePosition(_rb2d.position + new Vector2(0, _speed) * Time.deltaTime);

        // Verifica se o inimigo passou da metade da tela no eixo Y.
        if (transform.position.y < 0)
        {
            // Se passou da metade da tela, muda aleatoriamente a direção no eixo X.
            float randomXDirection = Random.Range(-1f, 1f);
            _rb2d.velocity = new Vector2(randomXDirection, _speed);
        }
    }

    public void Destruir()
    {
        ControladorPontuacao.Pontuacao++;
        Destroy(this.gameObject);
    }
}
