using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cookie : MonoBehaviour
{
    private bool isCollected = false;  
    //���������� �������� � �������� "�������". ����� ������� ����������� ������ �� ����������� ������ � "��������",
    //��� ���������� ��������� �� ��, ��� "�������" ������� ����� ������� ���������������

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!isCollected)
        {
            if (collision.CompareTag("Golem"))
            {
                isCollected = true;
                Destroy(gameObject);
            }
        }

    }
}
