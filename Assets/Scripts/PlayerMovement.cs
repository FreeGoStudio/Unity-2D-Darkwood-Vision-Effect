using UnityEngine;
/// <summary>
/// Simple script to move a player
/// </summary>
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float m_MoveSpeed = 5f;

    void Update()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0) * m_MoveSpeed * Time.deltaTime;
    }
}
