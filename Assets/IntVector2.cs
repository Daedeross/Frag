using UnityEngine;

public struct IntVector2
{
    public readonly int x;
    public readonly int y;

    public IntVector2(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    
    /// <summary>
    /// The square of the euclidian length of the vector.
    /// For faster computation that need it.
    /// </summary>
    public int sqrMagnitude
    {
        get {
            return x * x + y * y;
        }
    }

    /// <summary>
    /// The euclidian length of the vector
    /// </summary>
    public float magnitude
    {
        get
        {
            return Mathf.Sqrt(sqrMagnitude);
        }
    }

    /// <summary>
    /// The length of the vector using "taxicab geometry." aka Manhattan Distance/Length
    /// </summary>
    public int manhattanMagnitude
    {
        get { return x + y; }
    }

    #region Operators
    public static explicit operator Vector2(IntVector2 iv)
    {
        return new Vector2(iv.x, iv.y);
    }

    public static explicit operator IntVector2(Vector2 v)
    {
        return new IntVector2((int)Mathf.Floor(v.x), (int)Mathf.Floor(v.y));
    }

    public static IntVector2 operator +(IntVector2 lhs, IntVector2 rhs)
    {
        return new IntVector2(lhs.x + rhs.x, lhs.y + rhs.y);
    }

    public static IntVector2 operator -(IntVector2 lhs, IntVector2 rhs)
    {
        return new IntVector2(lhs.x - rhs.x, lhs.y - rhs.y);
    }

    public static IntVector2 operator -(IntVector2 v)
    {
        return new IntVector2(-v.x, -v.y);
    }

    /// <summary>
    /// Scale the vector.
    /// </summary>
    /// <param name="lhs">The original vector to scale</param>
    /// <param name="rhs">The factor to scale by</param>
    /// <returns>The result as a new IntVector2</returns>
    public static IntVector2 operator *(IntVector2 lhs, int rhs)
    {
        return new IntVector2(lhs.x * rhs, lhs.y * rhs);
    }

    /// <summary>
    /// Scale the vector.
    /// </summary>
    /// <param name="lhs">The factor to scale by</param>
    /// <param name="rhs">The original vector to scale</param>
    /// <returns>The result as a new IntVector2</returns>
    public static IntVector2 operator *(int lhs, IntVector2 rhs)
    {
        return new IntVector2(lhs * rhs.x, lhs * rhs.y);
    }
    #endregion // Operators

    #region Other Math Things

    /// <summary>
    /// Calulates the cross (scalar) product of two vectors.
    /// </summary>
    /// <param name="other"></param>
    /// <returns></returns>
    public int Cross(IntVector2 other)
    {
        return x * other.x + y * other.y;
    }

    #endregion
}