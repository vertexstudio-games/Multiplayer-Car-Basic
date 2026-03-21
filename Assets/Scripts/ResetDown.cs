using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetDown : MonoBehaviour
{
    public int sceneCurrent;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(sceneCurrent);
        }
    }
}
