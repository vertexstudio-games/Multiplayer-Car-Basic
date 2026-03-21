using Unity.VisualScripting;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0f, 6f, -7.5f);


    private void Update()
    {

    }
    // Update is called once per frame
    void LateUpdate()
    {
        // Colocando a câmera pra trás do jogador adiconando a posição do jogador (deslocamento -> offset)
        transform.position = player.transform.position + offset;
    }
}
