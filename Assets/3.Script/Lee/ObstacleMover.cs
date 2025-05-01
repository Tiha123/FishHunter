using UnityEngine;

public class ObstacleMover : MonoBehaviour
{
    public float moveSpeed = 5f;                // �̵� �ӵ�
    public float destroyZ = -5f;                // ī�޶� ���ʿ� �����ϸ� ����

    void Update()
    {
        // z- �������� �̵�
        transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);

        // ���� ��ġ ������ ����
        if (transform.position.z < destroyZ)
        {
            Destroy(gameObject);
        }
    }
}
