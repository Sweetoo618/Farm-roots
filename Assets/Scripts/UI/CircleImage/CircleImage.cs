using UnityEngine;
using UnityEngine.UI;

namespace UI.CircleImage
{
    public class CircleImage : MaskableGraphic
    {
        [Header("Circle Radius Attribute")]
        [Range(0.1f, 200f)]
        [SerializeField] private float radius = 50f;
        
        [Header("Circle Segments Attribute")]
        [Range(3, 128)]
        [SerializeField] private int segments = 64;
        
        [Header("Circle Fill Amount Attribute")]
        [Range(0f, 1f)]
        [SerializeField] private float fillAmount = 1f;

        public float Radius => radius;
        public int Segments => segments;
        public float FillAmount => fillAmount;

        protected override void OnPopulateMesh(VertexHelper vh)
        {
            vh.Clear();

            if (fillAmount <= 0f) return;

            Vector2 center = Vector2.zero;
            float startAngle = -90f;
            float totalAngle = fillAmount * 360f;
            
            int vertexCount = Mathf.CeilToInt(segments * fillAmount) + 1;

            vh.AddVert(center, color, new Vector2(0.5f, 0.5f));

            for (int i = 0; i <= Mathf.CeilToInt(segments * fillAmount); i++)
            {
                float angle = startAngle + (i / (float)segments) * totalAngle;
                float radian = angle * Mathf.Deg2Rad;
                
                Vector2 vertexPosition = center + new Vector2(
                    Mathf.Cos(radian) * radius,
                    Mathf.Sin(radian) * radius
                );

                float uvX = 0.5f + vertexPosition.x / (radius * 2f);
                float uvY = 0.5f + vertexPosition.y / (radius * 2f);

                vh.AddVert(vertexPosition, color, new Vector2(uvX, uvY));

                if (i > 0)
                {
                    vh.AddTriangle(0, i, i + 1);
                }
            }
        }

        public void SetRadius(float newRadius)
        {
            radius = newRadius;
            SetVerticesDirty();
        }

        public void SetSegments(int newSegments)
        {
            segments = Mathf.Max(3, newSegments);
            SetVerticesDirty();
        }

        public void SetFillAmount(float newFillAmount)
        {
            fillAmount = Mathf.Clamp01(newFillAmount);
            SetVerticesDirty();
        }
    }
}
