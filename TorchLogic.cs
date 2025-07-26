using UnityEngine;
using System;
using System.Collections.Generic;

/// <summary>
/// TouchManager 是一个单例，用于在 Android（及其他多点触控设备）上捕获并管理触摸事件。
/// 它会自动启用多点触控，跟踪每个触点的 fingerId 和位置，暴露开始、移动、结束三个回调事件，
/// 并记录运行时检测到的最大并发触点数。
/// </summary>
public class TouchManager : MonoBehaviour
{
    public static TouchManager Instance { get; private set; }

    /// <summary>运行时检测到的最大并发触点数</summary>
    public int MaxTouchCountReached { get; private set; } = 0;

    /// <summary>触摸开始事件：参数 (fingerId, position)</summary>
    public event Action<int, Vector2> OnTouchBegin;
    /// <summary>触摸移动事件：参数 (fingerId, position)</summary>
    public event Action<int, Vector2> OnTouchMove;
    /// <summary>触摸结束事件：参数 (fingerId, position)</summary>
    public event Action<int, Vector2> OnTouchEnd;

    // 内部字典：活跃触点 ID 到当前位置的映射
    private Dictionary<int, Vector2> activeTouches = new Dictionary<int, Vector2>();

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
            return;
        }
        Instance = this;
        // 确保多点触控已启用
        Input.multiTouchEnabled = true;
    }

    void Update()
    {
        // 更新最大触点数记录
        int currentTouchCount = Input.touchCount;
        if (currentTouchCount > MaxTouchCountReached)
            MaxTouchCountReached = currentTouchCount;

        // 遍历所有当前触点
        foreach (Touch touch in Input.touches)
        {
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    // 新触点，触发开始回调
                    if (!activeTouches.ContainsKey(touch.fingerId))
                    {
                        activeTouches.Add(touch.fingerId, touch.position);
                        OnTouchBegin?.Invoke(touch.fingerId, touch.position);
                    }
                    break;
                case TouchPhase.Moved:
                case TouchPhase.Stationary:
                    // 触点移动或保持，触发移动回调
                    if (activeTouches.ContainsKey(touch.fingerId))
                    {
                        activeTouches[touch.fingerId] = touch.position;
                        OnTouchMove?.Invoke(touch.fingerId, touch.position);
                    }
                    break;
                case TouchPhase.Ended:
                case TouchPhase.Canceled:
                    // 触点结束或取消，触发结束回调并移除记录
                    if (activeTouches.ContainsKey(touch.fingerId))
                    {
                        activeTouches.Remove(touch.fingerId);
                        OnTouchEnd?.Invoke(touch.fingerId, touch.position);
                    }
                    break;
            }
        }
    }

    /// <summary>
    /// 外部访问当前所有活跃触点。
    /// key: fingerId, value: 当前屏幕坐标
    /// </summary>
    public IReadOnlyDictionary<int, Vector2> ActiveTouches => activeTouches;
}
