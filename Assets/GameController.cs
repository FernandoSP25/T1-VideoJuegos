using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public TextMeshProUGUI mensajeFinal;
    public TextMeshProUGUI temporizadorTexto;
    public GameObject ninja;
    public Button botonReiniciar;

    private float tiempoRestante = 10f;
    private bool juegoGanado = false;
    public bool juegoTerminado = false;

    float tiempoTranscurrido = 0f;
    public float tiempoLimite = 10f;

    void Start()
    {
        botonReiniciar.gameObject.SetActive(false); 
    }

    void Update()
    {
        if (juegoTerminado) return;
        //tiempoRestante -= Time.deltaTime;
        //tiempoRestante = Mathf.Max(tiempoRestante, 0);
        //temporizadorTexto.text = Mathf.CeilToInt(tiempoRestante).ToString();

        //if (tiempoRestante <= 0 && !juegoGanado)
        //{
        //    GanarJuego();
        //}


        tiempoTranscurrido += Time.deltaTime;
        tiempoTranscurrido = Mathf.Min(tiempoTranscurrido, tiempoLimite);
        temporizadorTexto.text = Mathf.FloorToInt(tiempoTranscurrido).ToString();

        if (tiempoTranscurrido >= tiempoLimite && !juegoGanado)
        {
            GanarJuego();
        }
    }

    public void PerderJuego()
    {
        mensajeFinal.text = "GAME OVER";
        mensajeFinal.gameObject.SetActive(true);
        botonReiniciar.gameObject.SetActive(true);
        juegoTerminado = true;
        Time.timeScale = 0; 
    }

    void GanarJuego()
    {
        mensajeFinal.text = "¡JUEGO SUPERADO!";
        mensajeFinal.gameObject.SetActive(true);
        botonReiniciar.gameObject.SetActive(true);
        juegoTerminado = true;
        juegoGanado = true;
        Time.timeScale = 0;
    }

    public void ReiniciarJuego()
    {
        Time.timeScale = 1; 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
