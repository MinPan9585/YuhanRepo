using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class Line : MonoBehaviour
{
    [SerializeField] private LineRenderer lineRenderer;
    private List<Vector2> points = new List<Vector2>();

    public void SetPosition(Vector2 pos)
    {
        if (!CanAppend(pos)) return;

        points.Add(pos);
        lineRenderer.positionCount++;
        lineRenderer.SetPosition(lineRenderer.positionCount - 1, pos);
    }

    private bool CanAppend(Vector2 pos)
    {
        if (lineRenderer.positionCount == 0) return true;
        return Vector2.Distance(lineRenderer.GetPosition(lineRenderer.positionCount - 1), pos) > DrawManager.RESOLUTION;
    }
}
