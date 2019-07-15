using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPageViewItem : UIPanel
{
	// NOTE:
	// 不要直接引用 TestListView, 记住 UIPanel 是可能在多个地方使用
	public System.Action<TestPageViewItem> onItemClick = null;

	// public Item 
	private void Awake() 
	{
		// Debug.Log("xx-- item awake");
	}

	void Start()
	{
		// Debug.Log("xx-- item start");
	}

	public void OnClick()
	{
		Debug.Log("xx-- on click item");
		if (onItemClick != null)
			onItemClick(this);
	}
}
