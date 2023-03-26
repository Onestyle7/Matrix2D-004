using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixLib
{
    public class Matrix2D : IEnumerable<Matrix2D>
    {
        public int A { get; init; }
        public int B { get; init; }
        public int C { get; init; }
        public int D { get; init; }
        
        public Matrix2D(int a, int b, int c, int d)
        {
            A = a;
            B = b;
            C = c;
            D = d;  
        }
        public Matrix2D() : this(1,0,0,1) {  }

        public override string ToString() => $"[[{A}, {B}], [{C}, {D}]]";

       public bool Equals(Matrix2D? other)
        {
            if(other == null) return false;
            if(ReferenceEquals(this, other)) return true;

            return A == other.A && B == other.B && C == other.C && D == other.D;
        }

        public IEnumerator<Matrix2D> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object? obj)
        {
            if(obj is null) return false;           
            if (ReferenceEquals(this, obj)) return true;            
            if(obj is not Matrix2D) return false;

            return this.Equals(obj as Matrix2D);
        }
        public override int GetHashCode() => HashCode.Combine(A, B, C, D);

        public static bool operator == (Matrix2D? left, Matrix2D? right)
        {
            if (left == null && right == null) return true;
            if (left == null) return false;

            return left.Equals(right);
        }
        public static bool operator != (Matrix2D left, Matrix2D right)
        {
            return !(left == right);
        }

    }
}
