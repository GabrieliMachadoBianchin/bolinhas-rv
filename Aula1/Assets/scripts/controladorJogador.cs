using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Animations;

public class controladorJogador : MonoBehaviour
{
    private Rigidbody rb;
    private int placar;
    public Text txtpont;
    public Text txtpont2;
    public Button btnReiniciar;

    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        placar = 0;
        txtpont2.gameObject.SetActive(false);
        btnReiniciar.gameObject.SetActive(false);

    }

    void FixedUpdate()
    {
        float movH = Input.GetAxis("Horizontal");
        float movV = Input.GetAxis("Vertical");
        Vector3 f = new Vector3(movH,0, movV);

        rb.AddForce(f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Tag Coletavel"))
        other.gameObject.SetActive(false);
        placar++;
        txtpont.text = "Placar: " + placar;
        // Debug.Log("Placar: " + placar);
        exibeFimJogo();
    }


    private void exibeFimJogo()
    {
        if(placar == 3)
        {
            txtpont2.gameObject.SetActive(true);
            btnReiniciar.gameObject.SetActive(true);
        }
    }

    public void ReiniciarFase()
    {
        Scene cena = SceneManager.GetActiveScene();
        SceneManager.LoadScene(cena.name);
    }
}
