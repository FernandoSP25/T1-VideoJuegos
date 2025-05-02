using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f; // Velocidad del jugador
    [SerializeField] private float jumpForce = 10f; // Fuerza del salto
    private Vector3 startPosition;
    private bool isGrounded; // Para saber si el personaje está tocando el suelo
    private Rigidbody2D rb; // Componente Rigidbody2D del jugador
    private Animator animator; // Add Animator reference

    void Start()
    {
        startPosition = transform.position;
        rb = GetComponent<Rigidbody2D>(); // Obtener el Rigidbody2D
        animator = GetComponent<Animator>(); // Get the Animator component
    }

    void Update()
    {
        // Movimiento del personaje
        float moveX = moveSpeed * Time.deltaTime;
        transform.Translate(new Vector3(moveX, 0, 0));

        // Verificar si el jugador está tocando el suelo
        isGrounded = Physics2D.Raycast(transform.position, Vector2.down, 2.2f, LayerMask.GetMask("Ground"));

        // Dibujar el raycast en la escena para depurar
        Debug.DrawRay(transform.position, Vector2.down * 2.2f, Color.red);

        // Update jumping animation state
        animator.SetBool("jumping", !isGrounded);

        // Salto
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded) // Si el jugador presiona espacio y está en el suelo
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce); // Aplicar velocidad en el eje Y
            animator.SetBool("jumping", true); // Set jumping animation when jump starts
        }
    }
}
