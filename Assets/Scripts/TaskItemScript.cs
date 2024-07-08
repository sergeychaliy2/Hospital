using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TaskItemScript : MonoBehaviour
{
    public TextMeshProUGUI taskText;
    public Toggle taskToggle;

    public void SetupTask(string task)
    {
        taskText.text = task;
        taskToggle.isOn = false;
    }

    public void CompleteTask()
    {
        taskToggle.isOn = true;
    }
}
