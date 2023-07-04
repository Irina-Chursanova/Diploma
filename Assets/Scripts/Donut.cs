using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Donut : MonoBehaviour
{
    private bool isCollected = false;
    //���������� �������� � �������� "�������". ����� ������� ����������� ������ �� ����������� ������ � "��������",
    //��� ���������� ��������� �� ��, ��� "�������" ������� ����� ������� ���������������

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!isCollected)
        {
            if (collision.CompareTag("Slimecat"))
            {
                isCollected = true;
                Destroy(gameObject);
            }
        }

    }
}
