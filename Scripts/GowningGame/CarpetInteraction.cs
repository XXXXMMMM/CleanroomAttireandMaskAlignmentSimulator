using UnityEngine;

public class CarpetInteraction : MonoBehaviour
{
    private bool isCleaned = false;

    public void InteractWithCarpet()
    {
        if (!isCleaned)
        {
            // ִ����ϴ��̺���߼�
            CleanCarpet();
            // ���õ�̺�ѱ���ϴ�ı�־
            isCleaned = true;
        }
    }

    private void CleanCarpet()
    {
        // ��ϴ��̺�ľ������
        Debug.Log("Carpet cleaned successfully!");
    }
}
