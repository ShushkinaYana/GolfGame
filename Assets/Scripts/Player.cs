using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	[SerializeField]
	private Transform m_tool;

	public static Animator animator;
	bool m_target;

	public float range = 30f;
	public float speed = 1f;
	private float m_timer = 0f;

	private bool m_isDown;

	void Start()
	{
		animator = GetComponent<Animator>();
	}

	//private void Update()
	//{
		//var angels = m_tool.localEulerAngles;
		//var target = range * (m_isDown ? -1f : 1f);
		//var x = Mathf.MoveTowardsAngle(angels.x, target, speed * Time.deltaTime);
		//angels.x = x;
		//m_tool.localEulerAngles = angels;
	//}

	public void OnDown()
	{
		m_target = true;
        animator.SetBool("Target", m_target);

       // m_isDown = true;
	}

	public void OnUp()
	{
        m_target = false;
        animator.SetBool("Target", m_target);

       // m_isDown = false;
	}

	void changeAnimations(bool m_target)
	{
        animator.SetBool("Target", m_target);
    }
}
