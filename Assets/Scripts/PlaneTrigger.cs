using UnityEngine;

public class PlaneTrigger : MonoBehaviour
{
    public TaskManager taskManager;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            taskManager.CompleteFirstTask();
        }
    }
}
