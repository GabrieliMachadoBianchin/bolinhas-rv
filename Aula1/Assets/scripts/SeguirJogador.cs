using UnityEngine;

public class SeguirJogador : MonoBehaviour
{
    public GameObject jogador ;
    private Vector3 d;
    void Start()
    {
        d = transform.position - jogador.transform.position;
    }

    void LateUpdate()
    {
        transform.position = d + jogador.transform.position;
    }
}
