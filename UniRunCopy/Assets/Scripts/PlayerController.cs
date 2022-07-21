using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// PlayerController�� �÷��̾� ĳ���ͷμ� Player ���� ������Ʈ�� ������
public class PlayerController : MonoBehaviour
{
    public AudioClip deathClip; // ��� �� ����� ����� Ŭ��
    public float jumpForce = 700f; //���� ��
    private int jumpCount = 0; // ���� ���� Ƚ��
    private bool isGrounded = false; // �ٴڿ� ��Ҵ��� ��Ÿ��
    private bool isDead = false; //��� ����

    private Rigidbody2D playerRigidbody; // ����� �ִϸ����� ������Ʈ
    private Animator animator; // ����� �ִϸ����� ������Ʈ
    private AudioSource playerAudio; // ����� ����� �ҽ� ������Ʈ

    // Start is called before the first frame update
    private void Start()
    {
        //�ʱ�ȭ
        //���� ������Ʈ�κ��� ����� ������Ʈ���� ������ ������ �Ҵ�
        playerRigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    private void Update()
    {
        // ����� �Է��� �����ϰ� �����ϴ� ó��
        if (isDead)
        {
            //��� �� ó���� �� �̻� �������� �ʰ� ����
            return;
        }
        //���콺 ���� ��ư�� �������� && �ִ� ���� Ƚ��(2)�� �������� �ʾҴٸ�
        if (Input.GetButtonDown(0) && jumpCount < 2)
        {
            //���� Ƚ�� ����
        }
    }
    private void Die()
    { 
    // ���ó��
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Ʈ���� �ݶ��̴��� ���� ��ֹ����� �浹�� ����
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // �ٴڿ� ������� �����ϴ� ó��
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        // �ٴڿ� ������� �����ϴ� ó��
    }
}
