using UnityEngine;

public class NinjaPlayer : MonoBehaviour
{
    public GameController gameController;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Cuchilla"))
        {
            Debug.Log("¡Ninja golpeado!");
            gameObject.SetActive(false); // Desactiva el ninja
            gameController.NinjaMurio(); // Llama al mensaje de Game Over
        }
    }
}
