using UnityEngine;

public class SpawnerCuchillas : MonoBehaviour
{
    public GameObject Kunai;
    public float tiempoEntreSpawns = 1.5f;
    public Transform ninja;
    public GameController gameController;

    void Start()
    {
        if (ninja == null)
        {
            GameObject ninjaObj = GameObject.FindWithTag("Player");
            if (ninjaObj != null)
            {
                ninja = ninjaObj.transform;
            }
        }

        InvokeRepeating("SpawnCuchilla", 1f, tiempoEntreSpawns);
    }


    void SpawnCuchilla()
    {
        if (gameController.juegoTerminado) return;

        float x = ninja.position.x + 40f;
        float y = ninja.position.y + Random.Range(0f, 1f); 
        Vector3 posicionAleatoria = new Vector3(x, y, 0);

        GameObject kunaiInstanciado = Instantiate(Kunai, posicionAleatoria, Quaternion.Euler(0, 0, 90));
        Destroy(kunaiInstanciado, 6f); 
    }
}
