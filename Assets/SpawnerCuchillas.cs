using UnityEngine;

public class SpawnerCuchillas : MonoBehaviour
{
    public GameObject Kunai;
    public float tiempoEntreSpawns = 1.5f;
    public Transform ninja; // Referencia al ninja

    void Start()
    {
        InvokeRepeating("SpawnCuchilla", 1f, tiempoEntreSpawns);
    }

    void SpawnCuchilla()
    {
        float x = ninja.position.x + 40f;
        float y = Random.Range(-2f, 0.5f); // Variación aleatoria en Y
        Vector3 posicionAleatoria = new Vector3(x, y, 0);

        GameObject kunaiInstanciado = Instantiate(Kunai, posicionAleatoria, Quaternion.Euler(0, 0, 90));
        Destroy(kunaiInstanciado, 6f); // Se destruye a los 2 segundos
    }
}
