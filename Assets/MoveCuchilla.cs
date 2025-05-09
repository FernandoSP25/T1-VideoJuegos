using UnityEngine;

public class MoveCuchilla : MonoBehaviour
{
    public float velocidad = 6f;
    public Vector2 direccion = Vector2.up; // Ajusta según el movimiento que quieras


    void Update()
    {
        transform.Translate(direccion * velocidad * Time.deltaTime);
    }
}
