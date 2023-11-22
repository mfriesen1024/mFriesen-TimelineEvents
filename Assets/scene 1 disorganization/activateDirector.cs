using System.Diagnostics.CodeAnalysis;
using UnityEngine;

public class activateDirector : MonoBehaviour
{
    [SerializeField]    GameObject o;
    bool b = false;

    private void OnTriggerEnter(Collider other)
    {
        if (b) { o.SetActive(false); b = false; }
        else { o.SetActive(true); b = true; }
    }
}
