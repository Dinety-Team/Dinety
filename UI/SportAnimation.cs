using UnityEngine;
using UnityEngine.UI;

public class iOSStyleUIMover : MonoBehaviour
{
    [Header("动画设置")]
    public AnimationType animationType = AnimationType.EaseInOut;
    public float duration = 0.5f; // 动画持续时间(秒)
    public float dampingRatio = 0.8f; // 弹簧阻尼(0-1)
    public float angularFrequency = 20f; // 弹簧振动频率
    
    [Header("调试控制")]
    public bool debugMode = true;
    public Vector2 debugTargetPosition = new Vector2(100, 0);

    private RectTransform rectTransform;
    private Vector2 startPosition;
    private Vector2 targetPosition;
    private Vector2 velocity;
    private bool isAnimating;
    
    public enum AnimationType
    {
        EaseInOut,  // iOS标准缓入缓出
        Spring      // iOS弹簧效果
    }

    void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        startPosition = rectTransform.anchoredPosition;
        targetPosition = startPosition;
    }

    void Update()
    {
        if (debugMode && Input.GetKeyDown(KeyCode.Space))
        {
            MoveTo(debugTargetPosition);
        }

        if (!isAnimating) return;

        switch (animationType)
        {
            case AnimationType.EaseInOut:
                UpdateEaseInOutAnimation();
                break;
            case AnimationType.Spring:
                UpdateSpringAnimation();
                break;
        }
    }

    /// <summary>
    /// 移动UI到指定位置
    /// </summary>
    /// <param name="target">目标位置(相对于锚点的位置)</param>
    public void MoveTo(Vector2 target)
    {
        startPosition = rectTransform.anchoredPosition;
        targetPosition = target;
        velocity = Vector2.zero;
        isAnimating = true;
        
        // 取消所有协程以确保动画独立运行
        StopAllCoroutines();
    }

    /// <summary>
    /// iOS风格缓入缓出动画(使用三次方缓动函数)
    /// </summary>
    private void UpdateEaseInOutAnimation()
    {
        // 使用协程实现更精确的时间控制
        StartCoroutine(EaseInOutCoroutine());
    }
    
    private IEnumerator EaseInOutCoroutine()
    {
        float elapsed = 0f;
        Vector2 currentPos = rectTransform.anchoredPosition;
        
        while (elapsed < duration)
        {
            elapsed += Time.unscaledDeltaTime; // 使用unscaledDeltaTime避免受TimeScale影响
            float t = Mathf.Clamp01(elapsed / duration);
            
            // iOS风格的三次方缓动函数
            t = EaseInOutCubic(t);
            
            rectTransform.anchoredPosition = Vector2.Lerp(currentPos, targetPosition, t);
            yield return null;
        }
        
        rectTransform.anchoredPosition = targetPosition;
        isAnimating = false;
    }
    
    /// <summary>
    /// iOS风格弹簧动画(基于物理的阻尼振荡模型)
    /// </summary>
    private void UpdateSpringAnimation()
    {
        // 使用物理公式计算弹簧运动
        Vector2 currentPosition = rectTransform.anchoredPosition;
        Vector2 displacement = currentPosition - targetPosition;
        
        // 弹簧力计算 (F = -kx - bv)
        Vector2 springForce = -angularFrequency * angularFrequency * displacement;
        Vector2 dampingForce = -2.0f * dampingRatio * angularFrequency * velocity;
        Vector2 acceleration = springForce + dampingForce;
        
        // 更新速度和位置
        velocity += acceleration * Time.unscaledDeltaTime;
        Vector2 newPosition = currentPosition + velocity * Time.unscaledDeltaTime;
        
        rectTransform.anchoredPosition = newPosition;
        
        // 检查是否到达目标位置
        float positionError = Vector2.Distance(newPosition, targetPosition);
        float velocityMagnitude = velocity.magnitude;
        
        // 当位置接近且速度足够小时停止动画
        if (positionError < 0.1f && velocityMagnitude < 5f)
        {
            rectTransform.anchoredPosition = targetPosition;
            isAnimating = false;
            velocity = Vector2.zero;
        }
    }
    
    /// <summary>
    /// iOS标准缓动函数 (三次方缓入缓出)
    /// </summary>
    private float EaseInOutCubic(float t)
    {
        // 精确匹配iOS的UIViewAnimationCurveEaseInOut
        return t < 0.5f ? 
            4f * t * t * t : 
            1f - Mathf.Pow(-2f * t + 2f, 3f) / 2f;
    }
    
    /// <summary>
    /// iOS弹簧动画参数设置(匹配系统默认值)
    /// </summary>
    public void SetDefaultSpringParameters()
    {
        // 匹配iOS的UIView弹簧动画默认参数
        dampingRatio = 0.8f;   // 阻尼系数(0.8 = 轻微过冲)
        angularFrequency = 20f; // 角频率(控制动画速度)
    }
    
    /// <summary>
    /// iOS标准缓动参数设置
    /// </summary>
    public void SetDefaultEaseParameters()
    {
        duration = 0.5f; // iOS标准动画时长
    }

    // 编辑器调试按钮
    void OnDrawGizmosSelected()
    {
        if (!debugMode || !Application.isPlaying) return;
        
        // 在场景视图中绘制动画路径
        Gizmos.color = Color.green;
        Gizmos.DrawSphere(transform.position, 5f);
        Gizmos.color = Color.blue;
        Vector3 targetWorldPos = transform.TransformPoint((Vector3)debugTargetPosition);
        Gizmos.DrawSphere(targetWorldPos, 5f);
        Gizmos.DrawLine(transform.position, targetWorldPos);
    }
}
