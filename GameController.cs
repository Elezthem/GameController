using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text attemptsText; // ������ �� �����, ������������ ���������� �������
    private int attemptsCount = 0; // ���������� ��� �������� ���������� �������

    void Start()
    {
        if (attemptsText == null)
        {
            Debug.LogError("���������� ��������� ������ Text ��� attemptsText � ��������� Unity.");
        }
        else
        {
            UpdateAttemptsText(); // ������������� ������ � ������� ����������� �������
        }
    }

    void UpdateAttemptsText()
    {
        attemptsText.text = "�������: " + attemptsCount.ToString(); // ���������� ������ � ����������� �������
    }

    // ���������� ��� ������������ � ������ �����������
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Spike") // �������� "Obstacle" �� ��� �������, � ������� ������������ ��� ������
        {
            PlayerDied();
        }
    }

    // ���������� ��� �������������� ������� ������� (��������, ����� ������)
    void RespawnPlayer()
    {
        // ������ �������������� ������� ������
    }

    void PlayerDied()
    {
        attemptsCount++; // ���������� ���������� ������� ��� ������ ������
        UpdateAttemptsText(); // ���������� ������ ����� ��������� ���������� �������

        // ������ �������������� ������� ������
        RespawnPlayer();
    }
}
