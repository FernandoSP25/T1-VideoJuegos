using UnityEngine;

public class NinjaPlayer : MonoBehaviour
{
    private GameController gameController;

    void Start()
    {
        gameController = FindFirstObjectByType<GameController>();
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Cuchilla"))
        {
            Debug.Log("¡Ninja golpeado!");
            gameController.PerderJuego(); 
            Destroy(gameObject); 
        }
    }
}
