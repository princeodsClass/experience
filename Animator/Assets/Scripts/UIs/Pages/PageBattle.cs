using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public partial class PageBattle : MonoBehaviour // , IPointerDownHandler, IDragHandler, IPointerUpHandler
{
	[Header("===== Game Objects =====")]

	[SerializeField] FloatingJoystick _joystick = null;
	private bool m_bIsDirtyUpdateUIsState = true;

	private Camera _camera = null;


	void Awake()
	{
		_camera = Camera.main;
	}

	void Start()
	{
		Canvas canvas = GetComponentInParent<Canvas>();
	}

	


}
