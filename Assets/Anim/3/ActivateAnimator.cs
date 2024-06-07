using UnityEngine;

public class ActivateAnimator : MonoBehaviour
{
    // ���������� ��� �������� ������ �� ������
    public GameObject targetObject;

    // ����� ��� ��������� ���������
    public void ActivateObjectAnimator()
    {
        if (targetObject != null)
        {
            Animator animator = targetObject.GetComponent<Animator>();
            if (animator != null)
            {
                animator.enabled = true;
            }
            else
            {
                Debug.LogWarning("�������� �� ������ �� ������� �������.");
            }
        }
        else
        {
            Debug.LogWarning("������� ������ �� ��������.");
        }
    }
}
