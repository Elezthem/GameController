using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text attemptsText; // ссылка на текст, отображающий количество попыток
    private int attemptsCount = 0; // переменная для хранения количества попыток

    void Start()
    {
        if (attemptsText == null)
        {
            Debug.LogError("Необходимо присвоить объект Text для attemptsText в редакторе Unity.");
        }
        else
        {
            UpdateAttemptsText(); // инициализация текста с текущим количеством попыток
        }
    }

    void UpdateAttemptsText()
    {
        attemptsText.text = "Попытки: " + attemptsCount.ToString(); // обновление текста с количеством попыток
    }

    // Вызывается при столкновении с другим коллайдером
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Spike") // Замените "Obstacle" на тег объекта, с которым сталкивается ваш объект
        {
            PlayerDied();
        }
    }

    // Вызывается при восстановлении позиции объекта (например, после смерти)
    void RespawnPlayer()
    {
        // Логика восстановления позиции игрока
    }

    void PlayerDied()
    {
        attemptsCount++; // увеличение количества попыток при смерти игрока
        UpdateAttemptsText(); // обновление текста после изменения количества попыток

        // Логика восстановления позиции игрока
        RespawnPlayer();
    }
}
