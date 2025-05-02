using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameController : MonoBehaviour
{
    public TextMeshProUGUI mensajeFinal;
    public GameObject ninja;
    private float tiempoTranscurrido;
    private bool juegoTerminado = false;

    void Update()
    {
        if (juegoTerminado) return;

        tiempoTranscurrido += Time.deltaTime;

        if (tiempoTranscurrido >= 60f)
        {
            JuegoSuperado();
        }
    }

    public void NinjaMurio()
    {
        if (juegoTerminado) return;

        juegoTerminado = true;
        mensajeFinal.text = "GAME OVER";
        mensajeFinal.gameObject.SetActive(true);
    }

    void JuegoSuperado()
    {
        juegoTerminado = true;
        mensajeFinal.text = "JUEGO SUPERADO";
        mensajeFinal.gameObject.SetActive(true);
    }
}
