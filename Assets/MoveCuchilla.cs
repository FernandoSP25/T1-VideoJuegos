using UnityEngine;

public class MoveCuchilla : MonoBehaviour
{
    public float velocidad = 6f;
    public Vector2 direccion = Vector2.up; // Ajusta según el movimiento que quieras

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direccion * velocidad * Time.deltaTime);
    }
}
