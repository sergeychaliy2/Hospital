using UnityEngine;

public class ActivateAnimator : MonoBehaviour
{
    // Переменная для хранения ссылки на объект
    public GameObject targetObject;

    // Метод для включения аниматора
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
                Debug.LogWarning("Аниматор не найден на целевом объекте.");
            }
        }
        else
        {
            Debug.LogWarning("Целевой объект не назначен.");
        }
    }
}
