using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OffPC : MonoBehaviour
{
    public RawImage raw_1;
    public RawImage raw_2;

    public void OffPc()
    {
        if (raw_1 != null && raw_2 != null)
        {
            raw_1.enabled = !raw_1.enabled;
            raw_2.enabled = !raw_2.enabled;
        }
    }
}
