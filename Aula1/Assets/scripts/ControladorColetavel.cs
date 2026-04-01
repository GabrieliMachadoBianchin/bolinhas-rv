using UnityEngine;

public class ControladorColetavel : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(new Vector3 (45, 15, 15) * Time.deltaTime);
    }
}
